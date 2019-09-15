﻿using Cpnucleo.Application.Interfaces;
using Cpnucleo.Application.ViewModels;
using Cpnucleo.RazorPages.Pages.Sistema;
using Moq;
using SparkyTestHelpers.AspNetMvc.Core;
using SparkyTestHelpers.DataAnnotations;
using Xunit;

namespace Cpnucleo.RazorPages.Test.Pages.Sistema
{
    public class IncluirTest
    {
        private readonly Mock<IAppService<SistemaViewModel>> _sistemaAppService;

        public IncluirTest()
        {
            _sistemaAppService = new Mock<IAppService<SistemaViewModel>>();
        }

        [Theory]
        [InlineData("Sistema de Teste", "Descrição de Teste")]
        public void Test_OnPost(string nome, string descricao)
        {
            // Arrange
            SistemaViewModel sistemaMock = new SistemaViewModel { Nome = nome, Descricao = descricao };

            _sistemaAppService.Setup(x => x.Incluir(sistemaMock));

            IncluirModel pageModel = new IncluirModel(_sistemaAppService.Object);
            PageModelTester<IncluirModel> pageTester = new PageModelTester<IncluirModel>(pageModel);

            // Act
            pageTester
                .Action(x => x.OnPost)

                // Assert
                .WhenModelStateIsValidEquals(false)
                .TestPage();

            // Act
            pageTester
                .Action(x => x.OnPost)

                // Assert
                .WhenModelStateIsValidEquals(true)
                .TestRedirectToPage("Listar");

            // Assert
            Validation.For(sistemaMock).ShouldReturn.NoErrors();
        }
    }
}