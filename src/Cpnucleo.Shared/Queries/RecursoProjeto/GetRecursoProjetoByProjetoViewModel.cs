﻿namespace Cpnucleo.Infra.CrossCutting.Shared.Queries.RecursoProjeto;

public record GetRecursoProjetoByProjetoViewModel : BaseQuery
{
    public IEnumerable<RecursoProjetoDTO> RecursoProjetos { get; set; }
    public OperationResult OperationResult { get; set; }
}