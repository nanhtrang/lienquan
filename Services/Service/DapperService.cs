using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using lienquan.garena.vn.Services.Interface;

namespace lienquan.garena.vn.Services.Service
{
    public class DapperService : IDapperService
    {
        private IDbConnection db;

        public DapperService(IDbConnection db)
        {
            this.db = db;
        }

        public async Task<List<T>> SelectAsync<T>(string sql, object sqlParams)
        {
            var list = await this.db.QueryAsync<T>(sql, sqlParams);
            return list.ToList();
        }

        public async Task<dynamic> SelectAsync(string sql)
        {
            var list = await this.db.QueryAsync(sql);
            return list.ToList();
        }

        public async Task<List<TReturn>> SelectAsync<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, object queryParams, string splitOn)
        {
            var list = await this.db.QueryAsync<TFirst, TSecond, TReturn>(sql, map, queryParams, splitOn : splitOn);
            return list.ToList();
        }

        public Task<T> SingleSelectAsync<T>(string sql, object sqlParams)
        {
            var model = this.db.QuerySingleOrDefaultAsync<T>(sql, sqlParams);
            return model;
        }
    }
}