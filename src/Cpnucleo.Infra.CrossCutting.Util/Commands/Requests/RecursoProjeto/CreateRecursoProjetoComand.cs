﻿using Cpnucleo.Infra.CrossCutting.Util.Commands.Responses.RecursoProjeto;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using MediatR;

namespace Cpnucleo.Infra.CrossCutting.Util.Commands.Requests.RecursoProjeto
{
    public class CreateRecursoProjetoComand : IRequest<CreateRecursoProjetoResponse>
    {
        public RecursoProjetoViewModel RecursoProjeto { get; set; }
    }
}
