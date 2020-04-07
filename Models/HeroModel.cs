using System.Collections.Generic;

namespace lienquan.garena.vn.Models
{
    public class HeroModel
    {
        public int id { get; set; }
        public string avatar { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        public List<SkillModel> listSkin { get; set; }
    }
}