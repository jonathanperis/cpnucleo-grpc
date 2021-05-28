﻿using Cpnucleo.Infra.CrossCutting.Util.Commands.Responses.Projeto;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using MediatR;

namespace Cpnucleo.Infra.CrossCutting.Util.Commands.Requests.Projeto
{
    public class CreateProjetoCommand : IRequest<CreateProjetoResponse>
    {
        public ProjetoViewModel Projeto { get; set; }
    }
}