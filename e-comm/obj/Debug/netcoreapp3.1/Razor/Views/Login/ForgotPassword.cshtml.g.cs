#pragma checksum "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\Login\ForgotPassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03a8a994af0818b0eb0de61156062201b4270bb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_ForgotPassword), @"mvc.1.0.view", @"/Views/Login/ForgotPassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03a8a994af0818b0eb0de61156062201b4270bb5", @"/Views/Login/ForgotPassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec88c34a14430e15ec040061fbbe4da3b76a0a6f", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_ForgotPassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<e_comm.ViewModels.Login.ForgotPasswordVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SendConfirmation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\Login\ForgotPassword.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\Login\ForgotPassword.cshtml"
  string errorMessage = (string)TempData["errorMessage"];
    string successMessage = (string)TempData["successMessage"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE HTML>\r\n<html lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03a8a994af0818b0eb0de61156062201b4270bb55024", async() => {
                WriteLiteral(@"
    <title>WATCHO - Forgot Password</title>

    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta charset=""UTF-8"" />
    <script>
        addEventListener(""load"", function () {
            setTimeout(hideURLbar, 0);
        }, false);

        function hideURLbar() {
            window.scrollTo(0, 1);
        }
    </script>
    <link rel=""stylesheet"" href=""../css/Login/style.css"" type=""text/css"" media=""all"" />
    <link rel=""stylesheet"" href=""../css/Login/fontawesome-all.css"">
    <link href=""//fonts.googleapis.com/css?family=Reem+Kufi&amp;subset=arabic"" rel=""stylesheet"">
    <link href=""//fonts.googleapis.com/css?family=Open+Sans:300,300i,400,400i,600,600i,700,700i,800,800i"" rel=""stylesheet"">

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03a8a994af0818b0eb0de61156062201b4270bb56770", async() => {
                WriteLiteral("\r\n    <h1>\r\n        W A T C H O\r\n    </h1>\r\n    <div class=\"sub-main-w3\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "03a8a994af0818b0eb0de61156062201b4270bb57119", async() => {
                    WriteLiteral("\r\n            <div class=\"form-style-agile\">\r\n");
#nullable restore
#line 42 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\Login\ForgotPassword.cshtml"
                 if (errorMessage != null)
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <p class=\"change-par\">");
#nullable restore
#line 44 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\Login\ForgotPassword.cshtml"
                                     Write(errorMessage);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</p>\r\n");
#nullable restore
#line 45 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\Login\ForgotPassword.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
                    WriteLiteral("                    <p class=\"change-par\">Please enter your email address so we can send confirmation mail to you!</p>\r\n");
#nullable restore
#line 49 "C:\Users\adisk\Desktop\watches\e-commerce\e-comm\Views\Login\ForgotPassword.cshtml"
                }

#line default
#line hidden
#nullable disable
                    WriteLiteral("\r\n\r\n\r\n                <input class=\"top-margin-ten\" placeholder=\"Email\" name=\"Email\" type=\"text\"");
                    BeginWriteAttribute("required", " required=\"", 1761, "\"", 1772, 0);
                    EndWriteAttribute();
                    WriteLiteral(@">
                <small class=""email-error-message text-muted""></small>
            </div>



            <div class=""wthree-text"">
                <ul>
                    <li>
                        <a href=""#"">Don't have an account?</a>
                    </li>
                    <li>
                        <a href=""#"">Forgot Password?</a>
                    </li>
                </ul>
            </div>

            <input type=""submit"" value=""Send"">

        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n    <script src=\"../js/Login/jquery.min.js\"></script>\r\n    <script src=\"../js/Login/jquery.validate.min.js\"></script>\r\n    <script src=\"../js/Login/validate.js\"></script>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<e_comm.ViewModels.Login.ForgotPasswordVM> Html { get; private set; }
    }
}
#pragma warning restore 1591