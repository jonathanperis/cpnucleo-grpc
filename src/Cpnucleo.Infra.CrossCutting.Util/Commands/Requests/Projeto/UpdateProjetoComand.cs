﻿using Cpnucleo.Infra.CrossCutting.Util.Commands.Responses.Projeto;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using MediatR;

namespace Cpnucleo.Infra.CrossCutting.Util.Commands.Requests.Projeto
{
    public class UpdateProjetoComand : IRequest<UpdateProjetoResponse>
    {
        public ProjetoViewModel Projeto { get; set; }
    }
}
