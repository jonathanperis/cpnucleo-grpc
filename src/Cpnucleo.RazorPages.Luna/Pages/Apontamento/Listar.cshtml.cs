﻿using Cpnucleo.Application.Interfaces;
using Cpnucleo.Infra.CrossCutting.Identity.Interfaces;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Cpnucleo.RazorPages.Luna.Pages.Apontamento
{
    [Authorize]
    public class ListarModel : PageModel
    {
        private readonly IClaimsManager _claimsManager;
        private readonly IApontamentoAppService _apontamentoAppService;
        private readonly IRecursoTarefaAppService _recursoTarefaAppService;

        public ListarModel(IClaimsManager claimsManager,
                                    IApontamentoAppService apontamentoAppService,
                                    IRecursoTarefaAppService recursoTarefaAppService)
        {
            _claimsManager = claimsManager;
            _apontamentoAppService = apontamentoAppService;
            _recursoTarefaAppService = recursoTarefaAppService;
        }

        [BindProperty]
        public ApontamentoViewModel Apontamento { get; set; }

        public IEnumerable<ApontamentoViewModel> Lista { get; set; }

        public IEnumerable<RecursoTarefaViewModel> ListaRecursoTarefas { get; set; }

        public IActionResult OnGet()
        {
            string retorno = _claimsManager.ReadClaimsPrincipal(HttpContext.User, ClaimTypes.PrimarySid);
            Guid idRecurso = new Guid(retorno);

            Lista = _apontamentoAppService.ListarPorRecurso(idRecurso);
            ListaRecursoTarefas = _recursoTarefaAppService.ListarPorRecurso(idRecurso);

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                string retorno = _claimsManager.ReadClaimsPrincipal(HttpContext.User, ClaimTypes.PrimarySid);
                Guid idRecurso = new Guid(retorno);

                Lista = _apontamentoAppService.ListarPorRecurso(idRecurso);
                ListaRecursoTarefas = _recursoTarefaAppService.ListarPorRecurso(idRecurso);

                return Page();
            }

            _apontamentoAppService.Incluir(Apontamento);

            return RedirectToPage("Listar");
        }
    }
}