﻿namespace Cpnucleo.Infra.CrossCutting.Shared.Commands.RecursoTarefa;

public record UpdateRecursoTarefaCommand(Guid Id, Guid IdRecurso, Guid IdTarefa) : BaseCommand, IRequest<OperationResult>;