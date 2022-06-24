﻿using Cpnucleo.Shared.Common.DTOs;
using Cpnucleo.Shared.Common.Models;

namespace Cpnucleo.Shared.Requests.Auth;

public class AuthResponse
{
    public string Token { get; set; }
    public RecursoDTO Recurso { get; set; }
    public OperationResult Status { get; set; }
}
