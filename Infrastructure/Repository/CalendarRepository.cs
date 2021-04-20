using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TecnicalAssistence.Infrastructure.Models;
using TecnicalAssistence.Infrastructure.Repository.Context;

namespace TecnicalAssistence.Infrastructure.Repository
{
    public class CalendarRepository
    {
        private readonly DataBaseContext context;
        
        public CalendarRepository()
        {
            // Criando um instância da classe de contexto do EntityFramework
            context = new DataBaseContext();
        }
        
        
        public IList<DataAssistenciaEntity> Listar()
        {
            String sql = "select * from " +
                         "(select adddate('2020-01-01',t4.i*10000 + t3.i*1000 + t2.i*100 + t1.i*10 + t0.i) DT_DISPONIVEL from " +
                         "(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t0, " +
                         "(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t1, " +
                         "(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t2, " +
                         "(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t3, " +
                         "(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9) t4) v " +
                         "where DT_DISPONIVEL between (DATE(NOW()) + INTERVAL 5 DAY) and (DATE(NOW()) + INTERVAL 89 DAY)";
            
            return context.DataAssistenciaEntity.FromSqlRaw(sql).ToList<DataAssistenciaEntity>();
        }
        
        public IList<DataAssistenciaEntity> ListarHoratios(String data)
        {
            String sql = "select * from " +
                "(select addtime('" + data +" 09:00:00', 10000 * t0.i ) DT_DISPONIVEL from " +
                "(select 0 i union select 1 union select 2 union select 3 union select 4 union select 5 union select 6 union select 7 union select 8 union select 9 union select 10 ) t0) v";
            
            return context.DataAssistenciaEntity.FromSqlRaw(sql).ToList<DataAssistenciaEntity>();
        }
    }
}