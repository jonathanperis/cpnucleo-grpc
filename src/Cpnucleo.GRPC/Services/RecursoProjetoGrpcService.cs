﻿namespace Cpnucleo.GRPC.Services;

[Authorize]
public class RecursoProjetoGrpcService : ServiceBase<IRecursoProjetoGrpcService>, IRecursoProjetoGrpcService
{
    private readonly ISender _sender;

    public RecursoProjetoGrpcService(ISender sender)
    {
        _sender = sender;
    }

    /// <summary>
    /// Incluir recurso de projeto
    /// </summary>
    /// <remarks>
    /// # Incluir recurso de projeto
    /// 
    /// Inclui um recurso de projeto na base de dados.
    /// </remarks>
    /// <param name="command">Objeto de envio com os parametros necessários</param>        
    public async UnaryResult<OperationResult> CreateRecursoProjeto(CreateRecursoProjetoCommand command)
    {
        return await _sender.Send(command);
    }

    /// <summary>
    /// Listar recursos de projetos
    /// </summary>
    /// <remarks>
    /// # Listar recursos de projetos
    /// 
    /// Lista recursos de projetos da base de dados.
    /// </remarks>
    /// <param name="query">Objeto de consulta com os parametros necessários</param>        
    public async UnaryResult<ListRecursoProjetoViewModel> ListRecursoProjeto(ListRecursoProjetoQuery query)
    {
        return await _sender.Send(query);
    }

    /// <summary>
    /// Consultar recurso de projeto
    /// </summary>
    /// <remarks>
    /// # Consultar recurso de projeto
    /// 
    /// Consulta um recurso de projeto na base de dados.
    /// </remarks>
    /// <param name="query">Objeto de consulta com os parametros necessários</param>        
    public async UnaryResult<GetRecursoProjetoViewModel> GetRecursoProjeto(GetRecursoProjetoQuery query)
    {
        return await _sender.Send(query);
    }

    /// <summary>
    /// Consultar recurso de projeto por projeto
    /// </summary>
    /// <remarks>
    /// # Consultar recurso de projeto por projeto
    /// 
    /// Consulta um recurso de projeto por projeto na base de dados.
    /// </remarks>
    /// <param name="query">Objeto de consulta com os parametros necessários</param>        
    public async UnaryResult<ListRecursoProjetoByProjetoViewModel> GetRecursoProjetoByProjeto(ListRecursoProjetoByProjetoQuery query)
    {
        return await _sender.Send(query);
    }

    /// <summary>
    /// Remover recurso de projeto
    /// </summary>
    /// <remarks>
    /// # Remover recurso de projeto
    /// 
    /// Remove um recurso de projeto da base de dados.
    /// </remarks>
    /// <param name="command">Objeto de envio com os parametros necessários</param>        
    public async UnaryResult<OperationResult> RemoveRecursoProjeto(RemoveRecursoProjetoCommand command)
    {
        return await _sender.Send(command);
    }

    /// <summary>
    /// Alterar recurso de projeto
    /// </summary>
    /// <remarks>
    /// # Alterar recurso de projeto
    /// 
    /// Altera um recurso de projeto na base de dados.
    /// </remarks>
    /// <param name="command">Objeto de envio com os parametros necessários</param>        
    public async UnaryResult<OperationResult> UpdateRecursoProjeto(UpdateRecursoProjetoCommand command)
    {
        return await _sender.Send(command);
    }
}
