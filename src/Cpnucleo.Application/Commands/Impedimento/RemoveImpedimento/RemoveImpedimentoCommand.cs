﻿namespace Cpnucleo.Application.Commands.Impedimento.RemoveImpedimento;

public class RemoveImpedimentoCommand : IRequest<OperationResult>
{
    public Guid Id { get; set; }
}