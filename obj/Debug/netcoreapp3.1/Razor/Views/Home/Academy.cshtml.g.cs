#pragma checksum "/Users/toan/Documents/learning/net core/lienquan.garena.vn/Views/Home/Academy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03c1c78adce75ca04ac42d04b93290ee55609496"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Academy), @"mvc.1.0.view", @"/Views/Home/Academy.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/toan/Documents/learning/net core/lienquan.garena.vn/Views/_ViewImports.cshtml"
using lienquan.garena.vn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/toan/Documents/learning/net core/lienquan.garena.vn/Views/_ViewImports.cshtml"
using lienquan.garena.vn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/toan/Documents/learning/net core/lienquan.garena.vn/Views/_ViewImports.cshtml"
using lienquan.garena.vn.Models.JoinModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03c1c78adce75ca04ac42d04b93290ee55609496", @"/Views/Home/Academy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cf0a9c882c32d427dabe41eab96294a3a4b80a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Academy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/toan/Documents/learning/net core/lienquan.garena.vn/Views/Home/Academy.cshtml"
  
    ViewData["Title"] = "Học viện";
    var ranks = (List<RankModel>) ViewBag.Ranks;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"div-config\">\r\n    <div class=\"slidershow middle\">\r\n        <div class=\"sliders\">\r\n            <img class=\"img-slider\" id=\"i1\" src=\"https://lienquan.garena.vn/kg/images/img-banner.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 291, "\"", 297, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"img-slider\" id=\"i2\" src=\"https://lienquan.garena.vn/kg/images/img-banner-1.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 404, "\"", 410, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"img-slider\" id=\"i3\" src=\"https://lienquan.garena.vn/kg/images/img-banner-2.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 517, "\"", 523, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <img class=\"img-slider\" id=\"i4\" src=\"https://lienquan.garena.vn/kg/images/img-banner-3.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 630, "\"", 636, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"div-config\">\r\n    <div class=\"title\">CẠNH TRANH ĐẤU HẠNG - THÁCH THỨC ĐỈNH CAO</div>\r\n    <div class=\"row w-75 container-fluid text-light ranks\">\r\n");
#nullable restore
#line 21 "/Users/toan/Documents/learning/net core/lienquan.garena.vn/Views/Home/Academy.cshtml"
          
            foreach (var rank in ranks)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-4\">\r\n                    <div class=\"rank\">\r\n                         <img");
            BeginWriteAttribute("src", " src=\"", 1016, "\"", 1033, 1);
#nullable restore
#line 26 "/Users/toan/Documents/learning/net core/lienquan.garena.vn/Views/Home/Academy.cshtml"
WriteAttributeValue("", 1022, rank.image, 1022, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1034, "\"", 1040, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <div class=\"rank-name\">");
#nullable restore
#line 27 "/Users/toan/Documents/learning/net core/lienquan.garena.vn/Views/Home/Academy.cshtml"
                                          Write(rank.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 30 "/Users/toan/Documents/learning/net core/lienquan.garena.vn/Views/Home/Academy.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>

<script>
        var i1 = document.getElementById(""i1"");
        var i2 = document.getElementById(""i2"");
        var i3 = document.getElementById(""i3"");
        var i4 = document.getElementById(""i4"");
        hiddenAll();
        i1.hidden = false;
        setInterval(() => {
            if (!i1.hidden) {
                show(i2);
            }else if (!i2.hidden) {
                show(i3);
            }else if(!i3.hidden){
                show(i4);
            }else if(!i4.hidden){
                show(i1);
            }
        }, 3000);

        function show(item) {
            hiddenAll();
            debugger;
            item.hidden = false;
        }

        function hiddenAll() {
            i1.hidden = true;
            i2.hidden = true;
            i3.hidden = true;
            i4.hidden = true;
        }
    </script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
