﻿using Cpnucleo.Application.Interfaces;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace Cpnucleo.RazorPages.Luna.Pages.Tarefa
{
    [Authorize]
    public class RemoverModel : PageModel
    {
        private readonly ITarefaAppService _tarefaAppService;

        public RemoverModel(ITarefaAppService tarefaAppService)
        {
            _tarefaAppService = tarefaAppService;
        }

        [BindProperty]
        public TarefaViewModel Tarefa { get; set; }

        public IActionResult OnGet(Guid id)
        {
            Tarefa = _tarefaAppService.Consultar(id);

            return Page();
        }

        public IActionResult OnPost()
        {
            _tarefaAppService.Remover(Tarefa.Id);

            return RedirectToPage("Listar");
        }
    }
}