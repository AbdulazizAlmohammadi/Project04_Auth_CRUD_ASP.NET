#pragma checksum "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b1a5ff07c9eaabce875c0b30d18d2b54f226c75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b1a5ff07c9eaabce875c0b30d18d2b54f226c75", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c6aa953201e15c20aee30c746aafda07a79ad64", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SubmitOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml"
  

    string bgImage = "/pexels-lumn.jpg";
    var products = (List<ProductModel>) ViewBag.Products;
    var cart = (CartModal) ViewBag.Cart;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 164, "\"", 172, 0);
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 173, "\"", 269, 11);
            WriteAttributeValue("", 181, "background:", 181, 11, true);
            WriteAttributeValue(" ", 192, "url(", 193, 5, true);
#nullable restore
#line 9 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml"
WriteAttributeValue("", 197, bgImage, 197, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 205, ")", 205, 1, true);
            WriteAttributeValue(" ", 206, "no-repeat", 207, 10, true);
            WriteAttributeValue(" ", 216, "center", 217, 7, true);
            WriteAttributeValue(" ", 223, "center;", 224, 8, true);
            WriteAttributeValue(" ", 231, "background-size:", 232, 17, true);
            WriteAttributeValue(" ", 248, "cover;", 249, 7, true);
            WriteAttributeValue(" ", 255, "height:", 256, 8, true);
            WriteAttributeValue(" ", 263, "800px", 264, 6, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div class=\"text-center\" style=\"height: 800px; background-color: rgba(0,0,0,0.5); \">\r\n        ");
#nullable restore
#line 11 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml"
   Write(await Html.PartialAsync("_PartialNavbar"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div style="" height:100%; display:flex; flex-direction:column;justify-content: center"">
            <h1 class=""display-4"" style=""color: white; font-size: 120px; font-weight: bold; font-family: Pattaya,serif;"">Cart</h1>
            
        </div>
    </div>
</div>

<div class=""Homebody container text-center"">
    
    <h1 style=""font-family: Pattaya,serif;"">Your Cart</h1>
    <div class=""row order-body"">
");
#nullable restore
#line 23 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml"
         foreach (var product in products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4 \">\r\n           \r\n                <div class=\"category-card box-shadow\"");
            BeginWriteAttribute("style", " style=\"", 997, "\"", 1041, 4);
            WriteAttributeValue("", 1005, "background-image:", 1005, 17, true);
            WriteAttributeValue(" ", 1022, "url(", 1023, 5, true);
#nullable restore
#line 27 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml"
WriteAttributeValue("", 1027, product.img, 1027, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1039, ");", 1039, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"category-body\" style=\"display: flex ; flex-direction: column\">\r\n                    \r\n                        <h4 style=\"color: white; font-weight: bold\">");
#nullable restore
#line 30 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml"
                                                               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h5 style=\"color: white; font-weight: bold\">");
#nullable restore
#line 31 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml"
                                                               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h5>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b1a5ff07c9eaabce875c0b30d18d2b54f226c758715", async() => {
                WriteLiteral("\r\n                            <input class=\"large material-icons\" value=\"delete\" type=\"submit\"/>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml"
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 38 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        \r\n    </div>\r\n    <div style=\"margin-top: 20px\">\r\n        <h3 style=\"font-family: Pattaya,serif;\">Total price</h3>\r\n        <h3 style=\"font-family: Pattaya,serif;\">");
#nullable restore
#line 44 "D:\Developing\Tuwaiq\dotNet\Projects\Final Project\Project04_Auth_CRUD_ASP.NET\EzzRestaurant\EzzRestaurant\Views\Cart\Index.cshtml"
                                           Write(cart.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h3>\r\n    </div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5b1a5ff07c9eaabce875c0b30d18d2b54f226c7512414", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Submit order\">\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
