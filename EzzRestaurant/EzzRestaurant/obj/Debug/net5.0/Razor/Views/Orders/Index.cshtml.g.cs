#pragma checksum "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88fcc096a80c17e773720331ac62ffdc42af487c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
#line 1 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\_ViewImports.cshtml"
using EzzRestaurant;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\_ViewImports.cshtml"
using EzzRestaurant.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88fcc096a80c17e773720331ac62ffdc42af487c", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c6aa953201e15c20aee30c746aafda07a79ad64", @"/Views/_ViewImports.cshtml")]
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Orders\Index.cshtml"
  

    string bgImage = "/pexels-lumn.jpg";
    var orders = (List<OrderModel>) ViewBag.Orders;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 110, "\"", 118, 0);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 119, "\"", 215, 11);
            WriteAttributeValue("", 127, "background:", 127, 11, true);
            WriteAttributeValue(" ", 138, "url(", 139, 5, true);
#nullable restore
#line 7 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Orders\Index.cshtml"
WriteAttributeValue("", 143, bgImage, 143, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 151, ")", 151, 1, true);
            WriteAttributeValue(" ", 152, "no-repeat", 153, 10, true);
            WriteAttributeValue(" ", 162, "center", 163, 7, true);
            WriteAttributeValue(" ", 169, "center;", 170, 8, true);
            WriteAttributeValue(" ", 177, "background-size:", 178, 17, true);
            WriteAttributeValue(" ", 194, "cover;", 195, 7, true);
            WriteAttributeValue(" ", 201, "height:", 202, 8, true);
            WriteAttributeValue(" ", 209, "800px", 210, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"text-center\" style=\"height: 800px; background-color: rgba(0,0,0,0.5); \">\r\n        ");
#nullable restore
#line 9 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Orders\Index.cshtml"
   Write(await Html.PartialAsync("_PartialNavbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div style="" height:100%; display:flex; flex-direction:column;justify-content: center"">
            <h1 class=""display-4"" style=""color: white; font-size: 120px; font-weight: bold; font-family: Pattaya,serif;"">Orders</h1>
            
        </div>
    </div>
</div>

<div class=""Homebody container text-center"">
    
    <h1 style=""font-family: Pattaya,serif;"">Orders here</h1>
    <div class=""row order-body"">
");
#nullable restore
#line 21 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Orders\Index.cshtml"
         foreach (var order in orders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4 order-card-container\" style=\"font-family: Pattaya,serif;\">\r\n                <div class=\"order-card\">\r\n                    <h3>#");
#nullable restore
#line 25 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Orders\Index.cshtml"
                    Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h4>");
#nullable restore
#line 26 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Orders\Index.cshtml"
                   Write(order.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h4>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 29 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Orders\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
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
