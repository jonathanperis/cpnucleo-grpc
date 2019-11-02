﻿using Cpnucleo.Application.Interfaces;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cpnucleo.RazorPages.Luna.Pages.Recurso
{
    [Authorize]
    public class IncluirModel : PageModel
    {
        private readonly IRecursoAppService _recursoAppService;

        public IncluirModel(IRecursoAppService recursoAppService)
        {
            _recursoAppService = recursoAppService;
        }

        [BindProperty]
        public RecursoViewModel Recurso { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _recursoAppService.Incluir(Recurso);

            return RedirectToPage("Listar");
        }
    }
}