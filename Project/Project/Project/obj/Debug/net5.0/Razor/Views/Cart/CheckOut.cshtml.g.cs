#pragma checksum "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e125463abcb8b76ac08842c6ce0fa9ec29e6be81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_CheckOut), @"mvc.1.0.view", @"/Views/Cart/CheckOut.cshtml")]
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
#line 1 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/_ViewImports.cshtml"
using Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/_ViewImports.cshtml"
using Project.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e125463abcb8b76ac08842c6ce0fa9ec29e6be81", @"/Views/Cart/CheckOut.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab8b600f572989f5418c110eca7fb976d35748e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_CheckOut : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Project.Models.CartItem>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
Write(await Html.PartialAsync("_CartPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 4 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
  
    ViewBag.Title = "Thanh to??n";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"content\">\n    <div class=\"section group\">\n");
#nullable restore
#line 11 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
         if (Model.Count > 0)
        {
            decimal total = 0;
            int stt = 1;


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table"">
                <tr>
                    <th>STT</th>
                    <th>S???n ph???m</th>
                    <th>H??nh ???nh</th>
                    <th>Gi??</th>
                    <th>S??? l?????ng</th>
                    <th>Th??nh ti???n</th>
                    <th></th>
                </tr>
");
#nullable restore
#line 26 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
                 foreach (var cartitem in Model)
                {
                    var thanhtien = cartitem.Quantity * cartitem.product.ProductPrice;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 30 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
                        Write(stt++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 31 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
                       Write(cartitem.product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td><img");
            BeginWriteAttribute("src", " src=\"", 914, "\"", 953, 1);
#nullable restore
#line 32 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
WriteAttributeValue("", 920, cartitem.product.ProductImageUrl, 920, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"100\" /></td>\n                        <td>");
#nullable restore
#line 33 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
                       Write(cartitem.product.ProductPrice.GetValueOrDefault(0).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e125463abcb8b76ac08842c6ce0fa9ec29e6be816032", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 34 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => cartitem.Quantity);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 34 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
AddHtmlAttributeValue("", 1143, $"quantity-{cartitem.product.ProductId}", 1143, 43, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 35 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
                        Write((total += cartitem.product.ProductPrice.GetValueOrDefault(0) * cartitem.Quantity).ToString("N0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    </tr>\n");
#nullable restore
#line 37 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <td colspan=\"4\" class=\"text-right\">T???ng ti???n</td>\n                    <td>");
#nullable restore
#line 40 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
                    Write(total.ToString("n0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                    <td></td>\n                </tr>\n            </table>\n");
#nullable restore
#line 44 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"alert alert-danger\">Gi??? h??ng tr???ng</p>\n");
#nullable restore
#line 48 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n    <div class=\"section group\">\n        <div class=\"col-md-6\">\n");
#nullable restore
#line 53 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
             using (Html.BeginForm("CheckOut", "Cart", FormMethod.Post))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""form-group"">
                    <label>Ng?????i nh???n</label>
                    <input name=""shipName"" class=""form-control"" />
                </div>
                <div class=""form-group"">
                    <label>??i???n tho???i</label>
                    <input name=""mobile"" class=""form-control"" />
                </div>
                <div class=""form-group"">
                    <label>?????a ch???</label>
                    <input name=""address"" class=""form-control"" />
                </div>
                <div class=""form-group"">
                    <label>Email</label>
                    <input name=""email"" class=""form-control"" />
                </div>
");
#nullable restore
#line 73 "/Users/lehoanganh/Documents/HoangVan/PhatTrienWeb/Project/Project/Project/Views/Cart/CheckOut.cshtml"
                                                                                                           
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Project.Models.CartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
