﻿namespace Cpnucleo.GRPC.Services;

[Authorize]
public class SistemaGrpcService : ServiceBase<ISistemaGrpcService>, ISistemaGrpcService
{
    private readonly ISender _sender;

    public SistemaGrpcService(ISender sender)
    {
        _sender = sender;
    }

    /// <summary>
    /// Incluir sistema
    /// </summary>
    /// <remarks>
    /// # Incluir sistema
    /// 
    /// Inclui um sistema na base de dados.
    /// </remarks>
    /// <param name="command">Objeto de envio com os parametros necessários</param>        
    public async UnaryResult<OperationResult> CreateSistema(CreateSistemaCommand command)
    {
        return await _sender.Send(command);
    }

    /// <summary>
    /// Listar sistemas
    /// </summary>
    /// <remarks>
    /// # Listar sistemas
    /// 
    /// Lista sistemas da base de dados.
    /// </remarks>
    /// <param name="query">Objeto de consulta com os parametros necessários</param>        
    public async UnaryResult<ListSistemaViewModel> ListSistema(ListSistemaQuery query)
    {
        return await _sender.Send(query);
    }

    /// <summary>
    /// Consultar sistema
    /// </summary>
    /// <remarks>
    /// # Consultar sistema
    /// 
    /// Consulta um sistema na base de dados.
    /// </remarks>
    /// <param name="query">Objeto de consulta com os parametros necessários</param>        
    public async UnaryResult<GetSistemaViewModel> GetSistema(GetSistemaQuery query)
    {
        return await _sender.Send(query);
    }

    /// <summary>
    /// Remover sistema
    /// </summary>
    /// <remarks>
    /// # Remover sistema
    /// 
    /// Remove um sistema da base de dados.
    /// </remarks>
    /// <param name="command">Objeto de envio com os parametros necessários</param>        
    public async UnaryResult<OperationResult> RemoveSistema(RemoveSistemaCommand command)
    {
        return await _sender.Send(command);
    }

    /// <summary>
    /// Alterar sistema
    /// </summary>
    /// <remarks>
    /// # Alterar sistema
    /// 
    /// Altera um sistema na base de dados.
    /// </remarks>
    /// <param name="command">Objeto de envio com os parametros necessários</param>        
    public async UnaryResult<OperationResult> UpdateSistema(UpdateSistemaCommand command)
    {
        return await _sender.Send(command);
    }
}
