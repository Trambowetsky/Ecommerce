#pragma checksum "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1edb4447cc3076a3fa77c88522731801b23be98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__ProductCard), @"mvc.1.0.view", @"/Views/Home/_ProductCard.cshtml")]
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
#line 1 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\_ViewImports.cshtml"
using StoreApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\_ViewImports.cshtml"
using StoreApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1edb4447cc3076a3fa77c88522731801b23be98", @"/Views/Home/_ProductCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f56b154dc0cc3714514908c1b7ac3a6900dc0b31", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__ProductCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductCardModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <div class=\"product-card\">\r\n        <div class=\"product-image\">\r\n");
#nullable restore
#line 5 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
             if (Model.Product.IsNew)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"discount-tag\">new</span>\r\n");
#nullable restore
#line 8 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <img src=\"/img/card1.jpg\" class=\"product-thumb\"");
            BeginWriteAttribute("alt", " alt=\"", 279, "\"", 285, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n            <button class=\"card-btn\">add to cart</button>\r\n        </div>\r\n        <div class=\"product-info\">\r\n            <h4 class=\"product-brand\">");
#nullable restore
#line 13 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
                                 Write(Model.Product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n            <p class=\"product-short-description\">a short line about the cloth..</p>\r\n");
#nullable restore
#line 15 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
             if (Model.Product.DiscountPrice != 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"price\">");
#nullable restore
#line 17 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
                               Write(Model.ProjectSettings.ShopCurrency);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
                                                                   Write(Model.Product.DiscountPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><span class=\"actual-price\">");
#nullable restore
#line 17 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
                                                                                                                                 Write(Model.ProjectSettings.ShopCurrency);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
                                                                                                                                                                     Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 18 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
            }
            else {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"price\">");
#nullable restore
#line 20 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
                               Write(Model.ProjectSettings.ShopCurrency);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
                                                                   Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 21 "C:\Users\depry\source\repos\Ecommerce\StoreApplication\Views\Home\_ProductCard.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductCardModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
