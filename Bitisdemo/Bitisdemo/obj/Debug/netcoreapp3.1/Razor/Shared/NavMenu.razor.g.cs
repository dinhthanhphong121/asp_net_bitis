#pragma checksum "D:\Bitisdemo\Bitisdemo\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af51ed8dceb324293e58699298c68729b02742d0"
// <auto-generated/>
#pragma warning disable 1591
namespace Bitisdemo.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Bitisdemo\Bitisdemo\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Bitisdemo\Bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Bitisdemo\Bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Bitisdemo\Bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Bitisdemo\Bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Bitisdemo\Bitisdemo\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Bitisdemo\Bitisdemo\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Bitisdemo\Bitisdemo\_Imports.razor"
using Bitisdemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Bitisdemo\Bitisdemo\_Imports.razor"
using Bitisdemo.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""navbar"">
    <div class=""grid wide "">
        <div class=""row "">
            <div class=""navbar-top col l-12"">
                <ul class=""navbar-list"">
                    <li class=""navbar-item "">Hotline : <a href class=""navbar-link"">0966 158 666 </a>(8h- 12h,13h30- 17h) </li>
                    <li class=""navbar-item ""><a href class=""navbar-link"">Tìm cửa hàng</a></li>
                    <li class=""navbar-item ""><a href class=""navbar-link"">Liên hệ hợp tác</a></li>
                    <li class=""navbar-item ""><a href class=""navbar-link"">Mua hàng tại Amazon</a></li>
                    <li class=""navbar-item ""><a href class=""navbar-link"">Kiểm tra đơn hàng</a></li>
                    <ul class=""navbar-fomr"">
                        <li class=""navbar-fomr-item ""><a href class=""navbar-fomr-link"">Đăng ký</a></li>
                        <li class=""navbar-fomr-item ""><a href class=""navbar-fomr-link"">Đăng nhập</a></li>
                    </ul>
                    <li class=""navbar-item ""><a href class=""navbar-link""><img src=""asset/img/logo_vn.png"" alt class=""navbar-img""></a></li>

                </ul>

            </div>
        </div>
    </div>
</div>
");
            __builder.AddMarkupContent(1, "<div class=\"navbar-with-seach\">\r\n    <div class=\"grid wide\">\r\n        <div class=\"row\">\r\n            <div class=\"col l-1\">\r\n                <div class=\"navbar-logo\">\r\n                    <a href class=\"navbar-logo__logo\">\r\n                        <img src=\"asset/img/logo_bitis.png\" alt class=\"navbar-logo__img\">\r\n                    </a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col l-7\">\r\n                <ul class=\"navbar-menu\">\r\n                    <li class=\"navbar-menu__item\"><a href class=\"navbar-menu__link navbar-menu__link--active\">Về bitis</a></li>\r\n                    <li class=\"navbar-menu__item\"><a href class=\"navbar-menu__link\">nam</a></li>\r\n                    <li class=\"navbar-menu__item\"><a href class=\"navbar-menu__link\">nữ</a></li>\r\n                    <li class=\"navbar-menu__item\"><a href class=\"navbar-menu__link\">gosto</a></li>\r\n                    <li class=\"navbar-menu__item\"><a href class=\"navbar-menu__link\">bé trai</a></li>\r\n                    <li class=\"navbar-menu__item\"><a href class=\"navbar-menu__link\">bé gái</a></li>\r\n                    <li class=\"navbar-menu__item\"><a href class=\"navbar-menu__link\">Flash sale</a></li>\r\n                    <li class=\"navbar-menu__item\">\r\n                        <a href class=\"navbar-menu__link\">\r\n                            Nông sản\r\n                            <img src=\"//theme.hstatic.net/1000230642/1000679613/14/hello-fresh-logo.png?v=3715\" class=\"navbar-menu__img\">\r\n                        </a>\r\n                    </li>\r\n\r\n                </ul>\r\n            </div>\r\n            <div class=\"col l-3\">\r\n                <div class=\" navbar-seach\">\r\n                    <input type=\"text\" class=\"navbar-seach__input\" placeholder=\"Nhập thông tin cần tìm\">\r\n                    <button class=\"navbar-seach__btn\">\r\n                        <i class=\" fas fa-search navbar-seach__icon \"></i>\r\n                    </button>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"col l-1\">\r\n                <div class=\"navbar-item\">\r\n                    <a href class=\"navbar-item__item\">\r\n                        <i class=\"far fa-heart navbar-item__icon\"></i>\r\n                    </a>\r\n                    <a href class=\"navbar-item__item navbar-item__cart\">\r\n                        <i class=\"fas fa-shopping-cart navbar-item__icon\"></i>\r\n                        <span class=\"navbar-item__notice\">3</span>\r\n\r\n\r\n                        \r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"contenr\">\r\n    <div class=\"silider\">\r\n        <div class=\"grid wide \">\r\n            <div class=\"row \">\r\n                <div class=\"navbar-top col l-12\">\r\n\r\n                    \r\n                    <div class=\"slideshow-container\">\r\n\r\n                        \r\n                        <div class=\"mySlides fade\">\r\n                            <div class=\"numbertext\">1 / 4</div>\r\n                            <img src=\"asset/img/anh 1.jpg\" style=\"width:100%\">\r\n                            <div class=\"text\">Caption Text</div>\r\n                        </div>\r\n\r\n                        <div class=\"mySlides fade\">\r\n                            <div class=\"numbertext\">2 / 4</div>\r\n                            <img src=\"asset/img/anh2.jpg\" style=\"width:100%\">\r\n                            <div class=\"text\">Caption Two</div>\r\n                        </div>\r\n\r\n                        <div class=\"mySlides fade\">\r\n                            <div class=\"numbertext\">3 / 4</div>\r\n                            <img src=\"asset/img/anh3.jpg\" style=\"width:100%\">\r\n                            <div class=\"text\">Caption Three</div>\r\n                        </div>\r\n\r\n                        <div class=\"mySlides fade\">\r\n                            <div class=\"numbertext\">4 / 4</div>\r\n                            <img src=\"asset/img/anh4.jpg\" style=\"width:100%\">\r\n                            <div class=\"text\">Caption Three</div>\r\n                        </div>\r\n\r\n                        \r\n                        <a class=\"prev\" onclick=\"plusSlides(-1)\">&#10094;</a>\r\n                        <a class=\"next\" onclick=\"plusSlides(1)\">&#10095;</a>\r\n                    </div>\r\n                    <br>\r\n\r\n                    \r\n                    <div style=\"text-align:center\">\r\n                        <span class=\"dot\" onclick=\"currentSlide(1)\"></span>\r\n                        <span class=\"dot\" onclick=\"currentSlide(2)\"></span>\r\n                        <span class=\"dot\" onclick=\"currentSlide(3)\"></span>\r\n                        <span class=\"dot\" onclick=\"currentSlide(4)\"></span>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 136 "D:\Bitisdemo\Bitisdemo\Shared\NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
