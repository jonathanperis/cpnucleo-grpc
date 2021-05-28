﻿using Cpnucleo.Infra.CrossCutting.Util.Commands.Responses.Workflow;
using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using MediatR;

namespace Cpnucleo.Infra.CrossCutting.Util.Commands.Requests.Workflow
{
    public class UpdateWorkflowCommand : IRequest<UpdateWorkflowResponse>
    {
        public WorkflowViewModel Workflow { get; set; }
    }
}