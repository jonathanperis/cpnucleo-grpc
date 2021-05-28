﻿using Cpnucleo.Infra.CrossCutting.Util.Commands.Responses.Recurso;
using MediatR;
using System;

namespace Cpnucleo.Infra.CrossCutting.Util.Commands.Requests.Recurso
{
    public class RemoveRecursoCommand : IRequest<RemoveRecursoResponse>
    {
        public Guid Id { get; set; }
    }
}