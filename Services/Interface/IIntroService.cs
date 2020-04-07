using System.Collections.Generic;
using System.Threading.Tasks;
using lienquan.garena.vn.Models;

namespace lienquan.garena.vn.Services.Interface
{
    public interface IIntroService
    {
        Task<IntroModel> LoadIntroAsync();
        Task<IEnumerable<ConfigModel>> LoadConfigInfo();
        Task<IEnumerable<RankModel>> LoadRank();
    }
}