#pragma checksum "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9859c8af137467187ac60f7a9c6ee34bdc6f50ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
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
#nullable restore
#line 1 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9859c8af137467187ac60f7a9c6ee34bdc6f50ad", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c6aa953201e15c20aee30c746aafda07a79ad64", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-dark mr-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("white-space: nowrap;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
  
    string bgImage = "/pexels-lumn.jpg";
    var product = (ProductModel) ViewBag.Product;
    var category = (CategoryModel) ViewBag.Category;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 298, "\"", 306, 0);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 307, "\"", 407, 11);
            WriteAttributeValue("", 315, "background:", 315, 11, true);
            WriteAttributeValue(" ", 326, "url(", 327, 5, true);
#nullable restore
#line 11 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
WriteAttributeValue("", 331, product.img, 331, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 343, ")", 343, 1, true);
            WriteAttributeValue(" ", 344, "no-repeat", 345, 10, true);
            WriteAttributeValue(" ", 354, "center", 355, 7, true);
            WriteAttributeValue(" ", 361, "center;", 362, 8, true);
            WriteAttributeValue(" ", 369, "background-size:", 370, 17, true);
            WriteAttributeValue(" ", 386, "cover;", 387, 7, true);
            WriteAttributeValue(" ", 393, "height:", 394, 8, true);
            WriteAttributeValue(" ", 401, "800px", 402, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"text-center\" style=\"height: 800px; background-color: rgba(0,0,0,0.5); \">\r\n        ");
#nullable restore
#line 13 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
   Write(await Html.PartialAsync("_PartialNavbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div style=\" height:100%; display:flex; flex-direction:column;justify-content: center\">\r\n            <h1 class=\"display-4\" style=\"color: white; font-size: 120px; font-weight: bold; font-family: Pattaya,serif;\">");
#nullable restore
#line 15 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
                                                                                                                    Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            \r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"Homebody container text-center\">\r\n    <h1 style=\" font-weight: bold; font-family: Pattaya,serif;\">");
#nullable restore
#line 22 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
                                                           Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h4 style=\" font-weight: bold; font-family: Pattaya,serif;\">");
#nullable restore
#line 23 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
                                                           Write(category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h5 style=\" font-weight: bold; font-family: Pattaya,serif;\">");
#nullable restore
#line 24 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
                                                           Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h5>\r\n    \r\n");
#nullable restore
#line 26 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"d-flex justify-content-center\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9859c8af137467187ac60f7a9c6ee34bdc6f50ad9796", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
                                                                                                                            WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9859c8af137467187ac60f7a9c6ee34bdc6f50ad12472", async() => {
                WriteLiteral("\r\n                 <input type=\"submit\" class=\"btn btn-outline-danger\" value=\"Delete\">\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
                                                                  WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 34 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Products\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n       ");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
