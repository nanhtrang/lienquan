using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using lienquan.garena.vn.Models;
using lienquan.garena.vn.Models.JoinModels;
using lienquan.garena.vn.Services.Interface;

namespace lienquan.garena.vn.Services.Service
{
    public class HeroService : IHeroService
    {
        private IDapperService dapperService;
        public HeroService(IDapperService dapperService)
        {
            this.dapperService = dapperService;
        }

        public async Task<HeroModel> GetAsync(int id)
        {
            string sql = "select * from hero where id = @Id;";
            var param = new { Id = id };
            var hero = await this.dapperService.SingleSelectAsync<HeroModel>(sql, param);
            return hero;
        }

        public async Task<List<HeroModel>> GetAllAsync()
        {
            string sql = "select * from hero;";
            var heroes = await this.dapperService.SelectAsync<HeroModel>(sql, null);
            return heroes;
        }

        public async Task<List<HeroTypeModel>> GetTypeAsync()
        {
            string sql = "select * from hero_type;";
            var types = await this.dapperService.SelectAsync<HeroTypeModel>(sql, null);
            return types;
        }

        Task<List<HeroModel>> IHeroService.GetAllHeroTypeAsync()
        {
            throw new System.NotImplementedException();
        }

        public async Task<HeroModel> GetByNameAsync(string name)
        {
            string sql = "select * from hero where name = @Name;";
            var param = new { Name = name };
            var hero = await this.dapperService.SingleSelectAsync<HeroModel>(sql, param);
            return hero;
        }

        public async Task<HeroSkinModel> getHeroSkinAsync(int id)
        {
            var dic = new Dictionary<int, HeroSkinModel>();
            string sql = "select h.id as Id,h.name as Name, skn.avatar as Avatar, skn.image as Image from hero h inner join skin skn on h.id = skn.heroId where h.id = @Id";
            var param = new { Id = id };
            Func<HeroSkinModel, SkinMapModel, HeroSkinModel> map =
            (p, c) =>
            {
                if (!dic.TryGetValue(p.id, out var pOut))
                {
                    pOut = p;
                    pOut.listSkin = new List<SkinMapModel>();
                    dic.Add(p.id, pOut);
                }
                pOut.listSkin.Add(c);
                return pOut;
            };

            string splitOn = "Avatar";
            var list = await this.dapperService.SelectAsync<HeroSkinModel, SkinMapModel, HeroSkinModel>(sql, map, param, splitOn);
            if (list.ToList().Count == 0)
            {
                return null;
            }else{
                return list.FirstOrDefault();
            }
        }

        public async Task<List<SkillModel>> GetSkillAsync(int id)
        {
            string sql = "SELECT * FROM lienquanmobile.skill where heroId = @Id order by skillId;";
            var param = new {Id = id};
            var skills = await this.dapperService.SelectAsync<SkillModel>(sql, param);
            return skills.ToList();
        }
    }
}