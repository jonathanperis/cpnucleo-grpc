﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnet_cpnucleo_pages.Repository.RecursoProjeto;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;

namespace dotnet_cpnucleo_pages.Pages.RecursoProjeto
{
    [Authorize]
    public class ListarModel : PageModel
    {
        private readonly IRecursoProjetoRepository _recursoProjetoRepository;

        public ListarModel(IRecursoProjetoRepository recursoProjetoRepository)
        {
            _recursoProjetoRepository = recursoProjetoRepository;
        }

        [BindProperty]
        public RecursoProjetoItem RecursoProjeto { get; set; }

        [BindProperty]
        public IEnumerable<RecursoProjetoItem> Lista { get; set; }

        public async Task<IActionResult> OnGetAsync(int idProjeto)
        {
            Lista = await _recursoProjetoRepository.ListarPoridProjeto(idProjeto);

            ViewData["idProjeto"] = idProjeto;

            return Page();
        }
    }
}