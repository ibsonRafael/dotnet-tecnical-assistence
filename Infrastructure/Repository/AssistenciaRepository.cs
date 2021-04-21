using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TecnicalAssistence.Api.Dto.Request;
using TecnicalAssistence.Infrastructure.Models;
using TecnicalAssistence.Infrastructure.Repository.Context;

namespace TecnicalAssistence.Infrastructure.Repository
{
    public class AssistenciaRepository
    {
        private readonly DataBaseContext context;
        
        public AssistenciaRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }
        
        
        public AssistenciaEntity Inserir(AssistenciaEntity assistenciaEntity)
        {
            context.AssistenciaEntity.Add(assistenciaEntity);
            context.SaveChanges();
            return assistenciaEntity;
        }
        
        public IList<AssistenciaEntity> Listar()
        {
            return context.AssistenciaEntity.ToList();
        }

        public List<AssistenciaEntity> Listar(FiltroAgendamento filtros)
        {
            var assistenciaEntities = context.AssistenciaEntity;

            String sql = " SELECT t.* FROM cyrela.ASSISTENCIA t WHERE 1 = 1 ";

            if (filtros.IdAssunto != null)
                sql = $"{sql} AND t.ID_ASSUNTO = {filtros.IdAssunto.ToString()}";
            
            
            if (filtros.IdTipoAtividade != null)
                sql = $"{sql} AND t.ID_TIPO_ATIVIDADE = {filtros.IdTipoAtividade.ToString()}";
            
            if (filtros.IdSituacao != null)
                sql = $"{sql} AND t.ID_TIPO_ATIVIDADE = {filtros.IdSituacao.ToString()}";
            
            if (filtros.IdBloco != null)
                sql = $"{sql} AND t.ID_BLOCO = {filtros.IdBloco.ToString()}";
            
            if (filtros.IdEmpreendimento != null)
                sql = $"{sql} AND t.ID_EMPREENDIMENTO = {filtros.IdEmpreendimento.ToString()}";
            
            if (filtros.IdUnidade != null)
                sql = $"{sql} AND t.ID_UNIDADE = {filtros.IdUnidade.ToString()}";
            
            if (filtros.IdAgendamentoOrigem != null)
                sql = $"{sql} AND t.ID_VISITA = {filtros.IdAgendamentoOrigem.ToString()}";
            
            return assistenciaEntities.FromSqlRaw(sql).ToList();
        }
    }
}