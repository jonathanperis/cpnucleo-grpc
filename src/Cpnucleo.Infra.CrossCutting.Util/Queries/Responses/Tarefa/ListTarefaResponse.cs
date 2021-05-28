﻿using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using System.Collections.Generic;

namespace Cpnucleo.Infra.CrossCutting.Util.Queries.Responses.Tarefa
{
    public class ListTarefaResponse
    {
        public OperationResult Status { get; set; }
        public IEnumerable<TarefaViewModel> Tarefas { get; set; }
    }
}
