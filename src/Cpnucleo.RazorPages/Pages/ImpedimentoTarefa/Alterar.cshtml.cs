﻿using Cpnucleo.Infra.CrossCutting.Communication.API.Interfaces;
using Cpnucleo.Infra.CrossCutting.Identity.Interfaces;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Cpnucleo.RazorPages.Pages.ImpedimentoTarefa
{
    [Authorize]
    public class AlterarModel : PageBase
    {
        private readonly IImpedimentoTarefaApiService _impedimentoTarefaApiService;
        private readonly ICrudApiService<ImpedimentoViewModel> _impedimentoApiService;

        public AlterarModel(IClaimsManager claimsManager,
                                    IImpedimentoTarefaApiService impedimentoTarefaApiService,
                                    ICrudApiService<ImpedimentoViewModel> impedimentoApiService)
            : base(claimsManager)
        {
            _impedimentoTarefaApiService = impedimentoTarefaApiService;
            _impedimentoApiService = impedimentoApiService;
        }

        [BindProperty]
        public ImpedimentoTarefaViewModel ImpedimentoTarefa { get; set; }

        public SelectList SelectImpedimentos { get; set; }

        public IActionResult OnGet(Guid id)
        {
            ImpedimentoTarefa = _impedimentoTarefaApiService.Consultar(Token, id);
            SelectImpedimentos = new SelectList(_impedimentoApiService.Listar(Token), "Id", "Nome");

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                SelectImpedimentos = new SelectList(_impedimentoApiService.Listar(Token), "Id", "Nome");

                return Page();
            }

            _impedimentoTarefaApiService.Alterar(Token, ImpedimentoTarefa);

            return RedirectToPage("Listar", new { idTarefa = ImpedimentoTarefa.IdTarefa });
        }
    }
}