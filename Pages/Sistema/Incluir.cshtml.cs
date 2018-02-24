﻿using dotnet_cpnucleo_pages.Repository2;
using dotnet_cpnucleo_pages.Repository2.Sistema;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace dotnet_cpnucleo_pages.Pages.Sistema
{
    [Authorize]
    public class IncluirModel : PageModel
    {
        private readonly IRepository<SistemaItem> _sistemaRepository;

        public IncluirModel(IRepository<SistemaItem> sistemaRepository)
        {
            _sistemaRepository = sistemaRepository;
        }

        [BindProperty]
        public SistemaItem Sistema { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync(SistemaItem sistema)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await _sistemaRepository.Incluir(sistema);

            return RedirectToPage("Listar");
        }
    }
}