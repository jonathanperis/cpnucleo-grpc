using dotnet_cpnucleo_pages.Security;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_cpnucleo_pages.Repository.Recurso
{
    public class RecursoRepository : IRecursoRepository
    {
        private readonly RecursoContext _context;

        public RecursoRepository(RecursoContext context)
        {
            _context = context;
        }        

        public async Task Incluir(RecursoItem recurso)
        {
            CryptographyManager.CryptPbkdf2(recurso.Senha, out string itemCriptografado, out string salt);

            recurso.SenhaCriptografada = itemCriptografado;
            recurso.Salt = salt;

            recurso.DataInclusao = DateTime.Now;
            
            _context.Recursos.Add(recurso);
            await _context.SaveChangesAsync();
        }

        public async Task Alterar(RecursoItem recurso)
        {
            var recursoItem = _context.Recursos.Find(recurso.IdRecurso);

            CryptographyManager.CryptPbkdf2(recurso.Senha, out string itemCriptografado, out string salt);

            recursoItem.SenhaCriptografada = itemCriptografado;
            recursoItem.Salt = salt;

            recursoItem.Nome = recurso.Nome;
            recursoItem.Ativo = recurso.Ativo;

            recursoItem.DataAlteracao = DateTime.Now;

            _context.Recursos.Update(recursoItem);
            await _context.SaveChangesAsync();
        }

        public async Task<RecursoItem> Consultar(int idRecurso)
        {
            return await _context.Recursos
                .AsNoTracking()
                .SingleOrDefaultAsync(x => x.IdRecurso == idRecurso);
        }

        public async Task<IEnumerable<RecursoItem>> Listar()
        {
            return await _context.Recursos
                .AsNoTracking()
                .OrderBy(y => y.DataInclusao)
                .ToListAsync();
        }

        public async Task Remover(RecursoItem recurso)
        {    
            var recursoItem = _context.Recursos.Find(recurso.IdRecurso);            

            _context.Recursos.Remove(recursoItem);
            await _context.SaveChangesAsync();
        }

        public RecursoItem ValidarRecurso(string login, string senha, out bool valido)
        {
            valido = false;

            var recursoItem = _context.Recursos.SingleOrDefault(x => x.Login == login);

            if (recursoItem == null) return null;

            valido = CryptographyManager.VerifyPbkdf2(senha, recursoItem.SenhaCriptografada, recursoItem.Salt);

            return recursoItem;
        }        
    }
}