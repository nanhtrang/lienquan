using System.Collections.Generic;
using System.Threading.Tasks;
using lienquan.garena.vn.Models;
using lienquan.garena.vn.Services.Interface;

namespace lienquan.garena.vn.Services.Service
{
    public class IntroService : IIntroService
    {
        private IDapperService dapperService;
        public IntroService(IDapperService dapperService)
        {
            this.dapperService = dapperService;
        }

        public async Task<IEnumerable<ConfigModel>> LoadConfigInfo()
        {
            string sql = "select * from config";
            var configs = await this.dapperService.SelectAsync<ConfigModel>(sql, null);
            return configs;
        }

        public async Task<IntroModel> LoadIntroAsync()
        {
            string sql = "SELECT * FROM intro;";
            var introModel = await this.dapperService.SingleSelectAsync<IntroModel>(sql, null);
            return introModel;
        }

        public async Task<IEnumerable<RankModel>> LoadRank()
        {
            string sql = "SELECT * FROM rank ORDER BY id";
            var rankModel = await this.dapperService.SelectAsync<RankModel>(sql, null);
            return rankModel;
        }
    }
}