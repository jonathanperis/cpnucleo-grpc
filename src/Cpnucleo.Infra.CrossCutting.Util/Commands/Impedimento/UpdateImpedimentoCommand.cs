﻿namespace Cpnucleo.Infra.CrossCutting.Util.Commands.Impedimento;

public class UpdateImpedimentoCommand : IRequest<OperationResult>
{
    public Guid Id { get; set; }
    public string Nome { get; set; }
}