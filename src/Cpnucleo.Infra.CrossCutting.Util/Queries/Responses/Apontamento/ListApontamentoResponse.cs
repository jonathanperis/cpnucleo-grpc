﻿using Cpnucleo.Infra.CrossCutting.Util.ViewModels;
using System.Collections.Generic;

namespace Cpnucleo.Infra.CrossCutting.Util.Queries.Responses.Apontamento
{
    public class ListApontamentoResponse
    {
        public OperationResult Status { get; set; }
        public IEnumerable<ApontamentoViewModel> Apontamentos { get; set; }
    }
}
