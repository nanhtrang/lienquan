using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lienquan.garena.vn.Models;
using lienquan.garena.vn.Services.Interface;

namespace lienquan.garena.vn.Controllers
{
    public class HomeController : Controller
    {
        private IIntroService introService;
        private IHeroService heroService;

        public HomeController(IIntroService introService,IHeroService heroService)
        {
            this.introService = introService;
            this.heroService = heroService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var introModel = await this.introService.LoadIntroAsync();
            var configs = await this.introService.LoadConfigInfo();
            ViewBag.Intro = introModel;
            ViewBag.Configs = configs.ToList();
            return View();
        }

        public async Task<IActionResult> AcademyAsync()
        {
            var ranks = await this.introService.LoadRank();
            ViewBag.Ranks = ranks.ToList();
            return View();
        }

        public async Task<IActionResult> HeroAsync(){
            var heroes = await this.heroService.GetAllAsync();
            var heroTypes = await this.heroService.GetTypeAsync();
            ViewBag.Heroes = heroes;
            ViewBag.HeroTypes = heroTypes;
            return View();
        }

        public async Task<IActionResult> HeroDetailAsync(int id)
        {
            var hero = await this.heroService.GetAsync(id);
            if (hero == null)
            {
                return Redirect("../Hero");
            }
            var heroSkin = await this.heroService.getHeroSkinAsync(hero.id);
            if (heroSkin == null)
            {
                return Redirect("../Hero");
            }

            var heroSkill = await this.heroService.GetSkillAsync(id);
            if (heroSkill == null)
            {
                return Redirect("../Hero");
            }
            ViewBag.Hero = hero;
            ViewBag.HeroSkin = heroSkin;
            ViewBag.HeroSkill = heroSkill;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
