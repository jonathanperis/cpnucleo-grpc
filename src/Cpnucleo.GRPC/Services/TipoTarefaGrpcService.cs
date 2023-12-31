﻿namespace Cpnucleo.GRPC.Services;

[Authorize]
public class TipoTarefaGrpcService : ServiceBase<ITipoTarefaGrpcService>, ITipoTarefaGrpcService
{
    private readonly ISender _sender;

    public TipoTarefaGrpcService(ISender sender)
    {
        _sender = sender;
    }

    /// <summary>
    /// Incluir tipo de tarefa
    /// </summary>
    /// <remarks>
    /// # Incluir tipo de tarefa
    /// 
    /// Inclui um tipo de tarefa na base de dados.
    /// </remarks>
    /// <param name="command">Objeto de envio com os parametros necessários</param>        
    public async UnaryResult<OperationResult> CreateTipoTarefa(CreateTipoTarefaCommand command)
    {
        return await _sender.Send(command);
    }

    /// <summary>
    /// Listar tipos de tarefa
    /// </summary>
    /// <remarks>
    /// # Listar tipos de tarefa
    /// 
    /// Lista tipos de tarefa da base de dados.
    /// </remarks>
    /// <param name="query">Objeto de consulta com os parametros necessários</param>        
    public async UnaryResult<ListTipoTarefaViewModel> ListTipoTarefa(ListTipoTarefaQuery query)
    {
        return await _sender.Send(query);
    }

    /// <summary>
    /// Consultar tipo de tarefa
    /// </summary>
    /// <remarks>
    /// # Consultar tipo de tarefa
    /// 
    /// Consulta um tipo de tarefa na base de dados.
    /// </remarks>
    /// <param name="query">Objeto de consulta com os parametros necessários</param>        
    public async UnaryResult<GetTipoTarefaViewModel> GetTipoTarefa(GetTipoTarefaQuery query)
    {
        return await _sender.Send(query);
    }

    /// <summary>
    /// Remover tipo de tarefa
    /// </summary>
    /// <remarks>
    /// # Remover tipo de tarefa
    /// 
    /// Remove um tipo de tarefa da base de dados.
    /// </remarks>
    /// <param name="command">Objeto de envio com os parametros necessários</param>        
    public async UnaryResult<OperationResult> RemoveTipoTarefa(RemoveTipoTarefaCommand command)
    {
        return await _sender.Send(command);
    }

    /// <summary>
    /// Alterar tipo de tarefa
    /// </summary>
    /// <remarks>
    /// # Alterar tipo de tarefa
    /// 
    /// Altera um tipo de tarefa na base de dados.
    /// </remarks>
    /// <param name="command">Objeto de envio com os parametros necessários</param>        
    public async UnaryResult<OperationResult> UpdateTipoTarefa(UpdateTipoTarefaCommand command)
    {
        return await _sender.Send(command);
    }
}
