using System.Collections.Generic;

namespace lienquan.garena.vn.Models.JoinModels
{
    public class HeroSkinModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public List<SkinMapModel> listSkin{get;set;}
    }
}