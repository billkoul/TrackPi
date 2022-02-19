#pragma checksum "C:\Users\billkoul\Downloads\trackpi\MVC\Views\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "872bc9447dd43ed9306097fc644430908fb57425"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views__Layout), @"mvc.1.0.view", @"/Views/_Layout.cshtml")]
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
#line 1 "C:\Users\billkoul\Downloads\trackpi\MVC\Views\_Layout.cshtml"
using MVVMEntityLayer;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"872bc9447dd43ed9306097fc644430908fb57425", @"/Views/_Layout.cshtml")]
    public class Views__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral(" \r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "872bc9447dd43ed9306097fc644430908fb574252858", async() => {
                WriteLiteral(@"
    <!-- Required meta tags -->
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Track-Pi</title>
    <!-- plugins:css -->
    <link rel=""stylesheet"" href=""assets/vendors/mdi/css/materialdesignicons.min.css"">
    <link rel=""stylesheet"" href=""assets/vendors/flag-icon-css/css/flag-icon.min.css"">
    <link rel=""stylesheet"" href=""assets/vendors/css/vendor.bundle.base.css"">
    <!-- endinject -->
    <!-- Plugin css for this page -->
    <link rel=""stylesheet"" href=""assets/vendors/font-awesome/css/font-awesome.min.css"" />
    <link rel=""stylesheet"" href=""assets/vendors/bootstrap-datepicker/bootstrap-datepicker.min.css"">
    <!-- End plugin css for this page -->
    <!-- inject:css -->
    <!-- endinject -->
    <!-- Layout styles -->
    <link rel=""stylesheet"" href=""assets/css/style.css"">
    <!-- End layout styles -->
    <link rel=""shortcut icon"" href=""assets/images/favicon.png"" />

    <link rel=""stylesheet"" hr");
                WriteLiteral("ef=\"https://unpkg.com/leaflet@1.7.1/dist/leaflet.css\"\r\n          integrity=\"sha512-xodZBNTC5n17Xt2atTPuE1HxjVMSvLVW9ocqUKLsCC5CXdbqCmblAshOMAS6/keqq/sMZMZ19scR4PsZChSR7A==\"");
                BeginWriteAttribute("crossorigin", "\r\n          crossorigin=\"", 1264, "\"", 1289, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <script src=\"/js/jquery.min.js\"></script>\r\n    <script src=\"/js/jquery.form.min.js\"></script>\r\n    <script src=\"/js/site.js\"></script>\r\n    <script src=\"/js/sweetalert2.all.min.js\"></script>\r\n    ");
#nullable restore
#line 33 "C:\Users\billkoul\Downloads\trackpi\MVC\Views\_Layout.cshtml"
Write(RenderSection("ScriptsHeader", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "872bc9447dd43ed9306097fc644430908fb574255738", async() => {
                WriteLiteral(@"
    <div class=""container-scroller"">
        <!-- partial:partials/_navbar.html -->
        <nav class=""navbar default-layout-navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row"">
            <div class=""text-center navbar-brand-wrapper d-flex align-items-center justify-content-center"">
                <a class=""navbar-brand brand-logo"" href=""index.html""><img src=""assets/images/logo.png"" alt=""logo"" /></a>
            </div>
            <div class=""navbar-menu-wrapper d-flex align-items-stretch"">
                <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
                    <span class=""mdi mdi-menu""></span>
                </button>
                <ul class=""navbar-nav navbar-nav-right"">
                    <li class=""nav-item d-md-block"">
                        <button type=""button"" class=""btn btn-outline-secondary"">Device: ");
#nullable restore
#line 49 "C:\Users\billkoul\Downloads\trackpi\MVC\Views\_Layout.cshtml"
                                                                                   Write(ViewData["deviceName"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</button>
                    </li>
                    <li class=""nav-item  dropdown d-none d-md-block"">
                        <a class=""nav-link dropdown-toggle"" id=""projectDropdown"" href=""#"" data-toggle=""dropdown"" aria-expanded=""false""> Trackers </a>
                        <div class=""dropdown-menu navbar-dropdown"" aria-labelledby=""projectDropdown"">
");
#nullable restore
#line 54 "C:\Users\billkoul\Downloads\trackpi\MVC\Views\_Layout.cshtml"
                              
                                List<Device> devices = (List<Device>)ViewData["devices"];

                                if (devices != null && devices.Count > 0)
                                {
                                    foreach (Device dev in devices)
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <a class=\"dropdown-item\"");
                BeginWriteAttribute("href", " href=\"", 3269, "\"", 3315, 2);
                WriteAttributeValue("", 3276, "/home/dev/", 3276, 10, true);
#nullable restore
#line 61 "C:\Users\billkoul\Downloads\trackpi\MVC\Views\_Layout.cshtml"
WriteAttributeValue("", 3286, Html.DisplayFor(m => dev.Id), 3286, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                            <i class=\"mdi mdi-car mr-2\"></i>Device ");
#nullable restore
#line 62 "C:\Users\billkoul\Downloads\trackpi\MVC\Views\_Layout.cshtml"
                                                                              Write(Html.DisplayFor(m => dev.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </a>\r\n");
#nullable restore
#line 64 "C:\Users\billkoul\Downloads\trackpi\MVC\Views\_Layout.cshtml"
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                    </li>
                    <li class=""nav-item nav-profile dropdown"">
                    <li class=""nav-item  dropdown d-none d-md-block"">
                        <a class=""nav-link dropdown-toggle"" id=""projectDropdown"" href=""#"" data-toggle=""dropdown"" aria-expanded=""false""> Account </a>
                        <div class=""dropdown-menu navbar-dropdown dropdown-menu-right p-0 border-0 font-size-sm"" aria-labelledby=""profileDropdown"" data-x-placement=""bottom-end"">
                            <div class=""p-2"">
                                <h5 class=""dropdown-header text-uppercase pl-2 text-dark"">Options</h5>
                                <a class=""dropdown-item py-1 d-flex align-items-center justify-content-between"" href=""/settings"">
                                    <span>Settings</span>
                                    <i class=""mdi mdi-settings""></i>
                                </a>
                                <div role=""separator");
                WriteLiteral(@""" class=""dropdown-divider""></div>
                                <a class=""dropdown-item py-1 d-flex align-items-center justify-content-between"" href=""/logout"">
                                    <span>Log Out</span>
                                    <i class=""mdi mdi-logout ml-1""></i>
                                </a>
                            </div>
                        </div>
                    </li>
                    <li class=""nav-item dropdown"">
                        <a class=""nav-link count-indicator dropdown-toggle"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
                            <i class=""mdi mdi-bell-outline""></i>
                            <span class=""count-symbol bg-danger""></span>
                        </a>
                        <div class=""dropdown-menu dropdown-menu-right navbar-dropdown preview-list"" aria-labelledby=""notificationDropdown"">
                            <h6 class=""p-3 mb-0 bg-primary text-white py-4"">Notifications</h6>
 ");
                WriteLiteral(@"                           <div class=""dropdown-divider""></div>
                            <a class=""dropdown-item preview-item"">
                                <div class=""preview-thumbnail"">
                                    <div class=""preview-icon bg-info"">
                                        <i class=""mdi mdi-alert-box""></i>
                                    </div>
                                </div>
                                <div class=""preview-item-content d-flex align-items-start flex-column justify-content-center"">
                                    <h6 class=""preview-subject font-weight-normal mb-1"">Account created</h6>
                                    <p class=""text-gray ellipsis mb-0""> Welcome! </p>
                                </div>
                            </a>
                            <div class=""dropdown-divider""></div>
                            <h6 class=""p-3 mb-0 text-center"">See all notifications</h6>
                        </div>
         ");
                WriteLiteral(@"           </li>
                </ul>
                <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
                    <span class=""mdi mdi-menu""></span>
                </button>
            </div>
        </nav>
        <!-- partial -->
        <div class=""container-fluid page-body-wrapper"">
            <!-- partial:partials/_sidebar.html -->
            <nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
                <ul class=""nav"">
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/"">
                            <span class=""icon-bg""><i class=""mdi mdi-view-dashboard menu-icon""></i></span>
                            <span class=""menu-title"">Dashboard</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/live"">
                            <span class=""icon-bg""><i clas");
                WriteLiteral(@"s=""mdi mdi-crosshairs-gps menu-icon""></i></span>
                            <span class=""menu-title"">Live track</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/trips"">
                            <span class=""icon-bg""><i class=""mdi mdi-road-variant menu-icon""></i></span>
                            <span class=""menu-title"">Trips</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/statistics"">
                            <span class=""icon-bg""><i class=""mdi mdi-chart-bar menu-icon""></i></span>
                            <span class=""menu-title"">Statistics</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/triggers"">
                            <span class=""icon-bg""><i class=""mdi mdi-");
                WriteLiteral(@"flash menu-icon""></i></span>
                            <span class=""menu-title"">Triggers</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/alerts"">
                            <span class=""icon-bg""><i class=""mdi mdi-alert menu-icon""></i></span>
                            <span class=""menu-title"">Alerts</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/updates"">
                            <span class=""icon-bg""><i class=""mdi mdi-update menu-icon""></i></span>
                            <span class=""menu-title"">Updates</span>
                        </a>
                    </li>
                </ul>
            </nav>
            <!-- partial -->
            <div class=""main-panel"">
                <div class=""content-wrapper"">
                    ");
#nullable restore
#line 168 "C:\Users\billkoul\Downloads\trackpi\MVC\Views\_Layout.cshtml"
               Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>    
                <!-- content-wrapper ends -->
                <!-- partial:partials/_footer.html -->
                <footer class=""footer"">
                    <div class=""footer-inner-wraper"">
                        <div class=""d-sm-flex justify-content-center justify-content-sm-between"">
                            <span class=""text-muted d-block text-center text-sm-left d-sm-inline-block"">Copyright © Track-Pi 2022</span>
                            <span class=""float-none float-sm-right d-block mt-1 mt-sm-0 text-center""><a href=""/terms""> Terms of Use </a></span>
                        </div>
                    </div>
                </footer>
                <!-- partial -->
            </div>
            <!-- main-panel ends -->
        </div>
        <!-- page-body-wrapper ends -->
    </div>
    <!-- container-scroller -->
    <!-- plugins:js -->
    <script src=""assets/vendors/js/vendor.bundle.base.js""></script>
    <!-- endinject -->
    <!-- Plugi");
                WriteLiteral(@"n js for this page -->
    <script src=""assets/vendors/bootstrap-datepicker/bootstrap-datepicker.min.js""></script>
    <script src=""assets/vendors/jquery-circle-progress/js/circle-progress.min.js""></script>
    <!-- End plugin js for this page -->
    <!-- inject:js -->
    <script src=""assets/js/off-canvas.js""></script>
    <script src=""assets/js/hoverable-collapse.js""></script>
    <script src=""assets/js/misc.js""></script>
    <!-- endinject -->
    <!-- Custom js for this page -->
    <script src=""assets/js/dashboard.js""></script>
    <!-- End custom js for this page -->
    <script src=""https://unpkg.com/leaflet@1.7.1/dist/leaflet.js""
            integrity=""sha512-XQoYMqMTK8LvdxXYG3nZ448hOEQiglfqkJs1NOQV44cWnUrBc8PkAOcXy20w0vlaXaVUearIOBhiXZ5V3ynxwA==""");
                BeginWriteAttribute("crossorigin", "\r\n            crossorigin=\"", 11512, "\"", 11539, 0);
                EndWriteAttribute();
                WriteLiteral("></script>\r\n    ");
#nullable restore
#line 205 "C:\Users\billkoul\Downloads\trackpi\MVC\Views\_Layout.cshtml"
Write(RenderSection("ScriptsFooter", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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