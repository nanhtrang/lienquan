using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace lienquan.garena.vn.Services.Interface
{
    public interface IDapperService
    {
        Task<dynamic> SelectAsync(string sql);
        Task<List<T>> SelectAsync<T>(string sql, object sqlParams);
        Task<T> SingleSelectAsync<T>(string sql, object sqlParams);
        Task<List<TReturn>> SelectAsync<TFirst, TSecond, TReturn>(string sql, Func<TFirst, TSecond, TReturn> map, object queryParams, string splitOn);
    }
}