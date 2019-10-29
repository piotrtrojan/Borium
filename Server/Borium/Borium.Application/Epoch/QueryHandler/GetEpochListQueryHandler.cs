using Borium.Application.Epoch.Query;
using Borium.Application.Epoch.ResultDto;
using Borium.Application.Interfaces;
using Borium.Application.Utils;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace Borium.Application.Epoch.QueryHandler
{
    public class GetEpochListQueryHandler : IQueryHandler<GetEpochListQuery, ICollection<EpochDto>>
    {
        private readonly string _connectionString;

        public GetEpochListQueryHandler(QueryConnectionStringWrapper connectionStringWrapper)
        {
            _connectionString = connectionStringWrapper.Value;
        }
        public ICollection<EpochDto> Handle(GetEpochListQuery query)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                var res = sqlConnection.Query<EpochDto>(EpochSqlQueries.GetEpochList).ToList();
                return res;
            }
        }
    }
}
