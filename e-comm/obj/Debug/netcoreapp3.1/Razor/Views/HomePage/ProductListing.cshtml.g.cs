#pragma checksum "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\HomePage\ProductListing.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d89a0a22e1f85808cd74786e13407aca66f96506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomePage_ProductListing), @"mvc.1.0.view", @"/Views/HomePage/ProductListing.cshtml")]
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
#line 1 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\_ViewImports.cshtml"
using e_comm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\_ViewImports.cshtml"
using e_comm.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d89a0a22e1f85808cd74786e13407aca66f96506", @"/Views/HomePage/ProductListing.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec88c34a14430e15ec040061fbbe4da3b76a0a6f", @"/Views/_ViewImports.cshtml")]
    public class Views_HomePage_ProductListing : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<e_comm.ViewModels.HomePage.ProductListingVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("color1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "HomePage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProductListing", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-GenderId", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-GenderId", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\HomePage\ProductListing.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\HomePage\ProductListing.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89a0a22e1f85808cd74786e13407aca66f965065716", async() => {
                WriteLiteral(@"
    <title>Home Page</title>
    <link href=""../css/HomePage/bootstrap.css"" rel=""stylesheet"" type=""text/css"" media=""all"" />
    <script src=""../js/HomePage/jquery.min.js""></script>

    <link href=""../css/HomePage/style.css"" rel=""stylesheet"" type=""text/css"" media=""all"" />

    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />

    <script type=""application/x-javascript""> addEventListener(""load"", function() { setTimeout(hideURLbar, 0); }, false); function hideURLbar(){ window.scrollTo(0,1); } </script>


    <link href=""../css/HomePage/memenu.css"" rel=""stylesheet"" type=""text/css"" media=""all"" />



");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89a0a22e1f85808cd74786e13407aca66f965067432", async() => {
                WriteLiteral("\r\n    <!--header-->\r\n    <div class=\"header\">\r\n        <div class=\"header-top\">\r\n            <div class=\"container\">\r\n                <div class=\"search\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89a0a22e1f85808cd74786e13407aca66f965067882", async() => {
                    WriteLiteral("\r\n                        <input type=\"text\" value=\"Search \" onfocus=\"this.value = \'\';\" onblur=\"if (this.value == \'\') {this.value = \'Search\';}\">\r\n                        <input type=\"submit\" value=\"Go\">\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
                <div class=""header-left"">
                    <ul>
                        <li><a href=""login.html"">Login</a></li>
                        <li><a href=""register.html"">Register</a></li>

                    </ul>

                    <div class=""clearfix""> </div>
                </div>
                <div class=""clearfix""> </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""head-top"">
                <div class=""logo"">
                    <a href=""index.html""><img src=""../images/HomePage/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 2148, "\"", 2154, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                </div>\r\n                <div class=\" h_menu4\">\r\n                    <ul class=\"memenu skyblue\">\r\n                        <li class=\"active grid\"><a class=\"color8\" href=\"index.html\">Home</a></li>\r\n                        <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89a0a22e1f85808cd74786e13407aca66f9650610459", async() => {
                    WriteLiteral("Men");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-GenderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GenderId"] = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n\r\n                        <li class=\"grid\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89a0a22e1f85808cd74786e13407aca66f9650612607", async() => {
                    WriteLiteral("\tWomen");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-GenderId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["GenderId"] = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </li>
                        <li><a class=""color1"">Brands</a></li>
                        <li><a class=""color1"" href=""contact.html"">Get in touch</a></li>
                    </ul>
                </div>

                <div class=""clearfix""> </div>
            </div>
        </div>

    </div>

    <div class=""banner1"">
");
#nullable restore
#line 88 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\HomePage\ProductListing.cshtml"
         foreach (var item in Model.Rows)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <div class=\"inline\"><img");
                BeginWriteAttribute("src", " src=\"", 3143, "\"", 3160, 1);
#nullable restore
#line 90 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\HomePage\ProductListing.cshtml"
WriteAttributeValue("", 3149, item.Route, 3149, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 3161, "\"", 3167, 0);
                EndWriteAttribute();
                WriteLiteral(" /><p class=\"p1-first\">");
#nullable restore
#line 90 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\HomePage\ProductListing.cshtml"
                                                                               Write(item.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p> <p class=\"p2-second\">");
#nullable restore
#line 90 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\HomePage\ProductListing.cshtml"
                                                                                                                          Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("$</p> <p class=\"p2-second\">This is good watch</p> </div>\r\n");
#nullable restore
#line 91 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\HomePage\ProductListing.cshtml"
            
            
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


    </div>

    <!--content-->
    <div id=""special2"" class=""content"">
        
        <div class=""footer"">
            <div class=""container"">
                <div class=""footer-top-at"">

                    <div class=""col-md-4 amet-sed"">
                        <h4>MORE INFO</h4>
                        <ul class=""nav-bottom"">
                            <li><a href=""contact.html"">Mans</a></li>
                            <li><a href=""#"">Womans</a></li>
                            <li><a href=""#"">My orders</a></li>
                            <li><a href=""#"">Home</a></li>
                        </ul>
                    </div>
                    <div class=""col-md-4 amet-sed "">
                        <h4>CONTACT US</h4>

                        <p>
                            Say hello whenever you want!
                        </p>
                        <p class=""special3"">Send an email to: eklinika22@outlook.com <i class=""fas fa-at""></i></p>


                      ");
                WriteLiteral(@"  <p>Phone number: +38762 244 806 <i class=""fas fa-phone-square""></i></p>

                    </div>
                    <div class=""col-md-4 amet-sed"">
                        <h4>Newsletter</h4>
                        <p>
                            Sign Up to get all news update
                            and promo
                        </p>
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d89a0a22e1f85808cd74786e13407aca66f9650618318", async() => {
                    WriteLiteral("\r\n                            <input type=\"text\"");
                    BeginWriteAttribute("value", " value=\"", 5325, "\"", 5333, 0);
                    EndWriteAttribute();
                    WriteLiteral(" onfocus=\"this.value=\'\';\" onblur=\"if (this.value == \'\') {this.value =\'\';}\">\r\n                            <input type=\"submit\" value=\"Sign up\">\r\n                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"clearfix\"> </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<e_comm.ViewModels.HomePage.ProductListingVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
