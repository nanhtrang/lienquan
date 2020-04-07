using System.Collections.Generic;
using System.Threading.Tasks;
using lienquan.garena.vn.Models;
using lienquan.garena.vn.Models.JoinModels;

namespace lienquan.garena.vn.Services.Interface
{
    public interface IHeroService
    {
        Task<List<HeroModel>> GetAllAsync();
        Task<List<HeroModel>> GetAllHeroTypeAsync();
        Task<HeroModel> GetAsync(int id);
        Task<HeroModel> GetByNameAsync(string name);
        Task<List<HeroTypeModel>> GetTypeAsync();
        Task<HeroSkinModel> getHeroSkinAsync(int id);
        Task<List<SkillModel>> GetSkillAsync(int id);
    }
}