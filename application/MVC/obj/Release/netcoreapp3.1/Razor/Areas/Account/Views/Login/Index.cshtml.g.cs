#pragma checksum "C:\Users\billkoul\Downloads\app.track-pi.com\MVC\Areas\Account\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42ff6a8f8641e1ac3d6013282dc1c46b2a36d6a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Account_Views_Login_Index), @"mvc.1.0.view", @"/Areas/Account/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42ff6a8f8641e1ac3d6013282dc1c46b2a36d6a4", @"/Areas/Account/Views/Login/Index.cshtml")]
    public class Areas_Account_Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42ff6a8f8641e1ac3d6013282dc1c46b2a36d6a42787", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>App.Track-Pi - Login</title>
    <!-- plugins:css -->
    <link rel=""stylesheet"" href=""/assets/vendors/mdi/css/materialdesignicons.min.css"">
    <link rel=""stylesheet"" href=""/assets/vendors/flag-icon-css/css/flag-icon.min.css"">
    <link rel=""stylesheet"" href=""/assets/vendors/css/vendor.bundle.base.css"">
    <script src=""/js/jquery.min.js""></script>
    <script src=""/js/jquery.form.min.js""></script>
    <link rel=""stylesheet"" href=""/assets/css/style.css"">
    <!-- End layout styles -->
    <link rel=""shortcut icon"" href=""/assets/images/favicon.png"" />
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42ff6a8f8641e1ac3d6013282dc1c46b2a36d6a44514", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
        <div class=""container-fluid page-body-wrapper full-page-wrapper"">
            <div class=""content-wrapper d-flex align-items-center auth"">
                <div class=""row flex-grow"">
                    <div class=""col-lg-4 mx-auto"">
                        <div class=""auth-form-light text-left p-5"">
                            <div class=""brand-logo"">
                                <img src=""/assets/images/logo-dark.png"">
                            </div>
                            <h6 class=""font-weight-light"">Sign in to continue.</h6>
                            <form class=""pt-3"">
                                <input type=""hidden"" id=""ReturnUrl"" name=""ReturnUrl""");
                BeginWriteAttribute("value", " value=\"", 1527, "\"", 1559, 1);
#nullable restore
#line 30 "C:\Users\billkoul\Downloads\app.track-pi.com\MVC\Areas\Account\Views\Login\Index.cshtml"
WriteAttributeValue("", 1535, ViewData["ReturnUrl"], 1535, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                                <div class=""form-group"">
                                    <input type=""text"" class=""form-control form-control-lg"" name=""Username"" id=""exampleInputEmail1"" placeholder=""Username"">
                                </div>
                                <div class=""form-group"">
                                    <input type=""Password"" class=""form-control form-control-lg"" name=""Password"" id=""exampleInputPassword1"" placeholder=""Password"">
                                </div>
                                <div class=""mt-3"">
                                    <a id=""submit"" class=""btn btn-block btn-primary btn-lg font-weight-medium auth-form-btn"">SIGN IN</a>
                                </div>
                                <div class=""my-2 d-flex justify-content-between align-items-center"">
                                    <a href=""#"" class=""auth-link text-black"">Forgot password?</a>
                                </div>
                            </f");
                WriteLiteral(@"orm>
                        </div>
                    </div>
                </div>
            </div>
            <!-- content-wrapper ends -->
        </div>
        <!-- page-body-wrapper ends -->
    </div>
    <script src=""/js/login.js""></script>
    <!-- endinject -->
");
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
            WriteLiteral("\r\n</html>");
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
