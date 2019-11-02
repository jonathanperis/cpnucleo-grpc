﻿using Cpnucleo.Application.Interfaces;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Cpnucleo.RazorPages.Luna.Pages.Recurso
{
    [Authorize]
    public class ListarModel : PageModel
    {
        private readonly IRecursoAppService _recursoAppService;

        public ListarModel(IRecursoAppService recursoAppService)
        {
            _recursoAppService = recursoAppService;
        }

        public RecursoViewModel Recurso { get; set; }

        public IEnumerable<RecursoViewModel> Lista { get; set; }

        public IActionResult OnGet()
        {
            Lista = _recursoAppService.Listar();

            return Page();
        }
    }
}