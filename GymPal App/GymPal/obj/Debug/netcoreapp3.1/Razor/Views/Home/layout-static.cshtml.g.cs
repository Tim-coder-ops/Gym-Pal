#pragma checksum "C:\Users\Timwe\OneDrive\Documents\MSSA\Gym Pal\GymPal App\GymPal\Views\Home\layout-static.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdb67b64eca374f94350b957050e075fda94a2f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_layout_static), @"mvc.1.0.view", @"/Views/Home/layout-static.cshtml")]
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
#line 1 "C:\Users\Timwe\OneDrive\Documents\MSSA\Gym Pal\GymPal App\GymPal\Views\_ViewImports.cshtml"
using GymPal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Timwe\OneDrive\Documents\MSSA\Gym Pal\GymPal App\GymPal\Views\_ViewImports.cshtml"
using GymPal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdb67b64eca374f94350b957050e075fda94a2f1", @"/Views/Home/layout-static.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"926641a90c93abbfc2e30df9ef20a0f41a534dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_layout_static : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-none d-md-inline-block form-inline ml-auto mr-0 mr-md-3 my-2 my-md-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdb67b64eca374f94350b957050e075fda94a2f14003", async() => {
                WriteLiteral("\n        <meta charset=\"utf-8\" />\n        <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\n        <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 270, "\"", 280, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n        <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 312, "\"", 322, 0);
                EndWriteAttribute();
                WriteLiteral(" />\n        <title>Static Navigation - SB Admin</title>\n        <link href=\"css/styles.css\" rel=\"stylesheet\" />\n        <script src=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.0/js/all.min.js\" crossorigin=\"anonymous\"></script>\n    ");
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
            WriteLiteral("\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdb67b64eca374f94350b957050e075fda94a2f15813", async() => {
                WriteLiteral(@"
        <nav class=""sb-topnav navbar navbar-expand navbar-dark bg-dark"">
            <a class=""navbar-brand"" href=""index.html"">Start Bootstrap</a>
            <button class=""btn btn-link btn-sm order-1 order-lg-0"" id=""sidebarToggle"" href=""#""><i class=""fas fa-bars""></i></button>
            <!-- Navbar Search-->
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdb67b64eca374f94350b957050e075fda94a2f16408", async() => {
                    WriteLiteral(@"
                <div class=""input-group"">
                    <input class=""form-control"" type=""text"" placeholder=""Search for..."" aria-label=""Search"" aria-describedby=""basic-addon2"" />
                    <div class=""input-group-append"">
                        <button class=""btn btn-primary"" type=""button""><i class=""fas fa-search""></i></button>
                    </div>
                </div>
            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <!-- Navbar-->
            <ul class=""navbar-nav ml-auto ml-md-0"">
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" id=""userDropdown"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""><i class=""fas fa-user fa-fw""></i></a>
                    <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                        <a class=""dropdown-item"" href=""#"">Settings</a>
                        <a class=""dropdown-item"" href=""#"">Activity Log</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""login.html"">Logout</a>
                    </div>
                </li>
            </ul>
        </nav>
        <div id=""layoutSidenav"">
            <div id=""layoutSidenav_nav"">
                <nav class=""sb-sidenav accordion sb-sidenav-dark"" id=""sidenavAccordion"">
                    <div class=""sb-sidenav-menu"">
                 ");
                WriteLiteral(@"       <div class=""nav"">
                            <div class=""sb-sidenav-menu-heading"">Core</div>
                            <a class=""nav-link"" href=""index.html"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-tachometer-alt""></i></div>
                                Dashboard
                            </a>
                            <div class=""sb-sidenav-menu-heading"">Interface</div>
                            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapseLayouts"" aria-expanded=""false"" aria-controls=""collapseLayouts"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-columns""></i></div>
                                Layouts
                                <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                            </a>
                            <div class=""collapse"" id=""collapseLayouts"" aria-labelledby=""headingOne"" data-parent=""#sidenavAccordion"">
  ");
                WriteLiteral(@"                              <nav class=""sb-sidenav-menu-nested nav"">
                                    <a class=""nav-link"" href=""layout-static.html"">Static Navigation</a>
                                    <a class=""nav-link"" href=""layout-sidenav-light.html"">Light Sidenav</a>
                                </nav>
                            </div>
                            <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#collapsePages"" aria-expanded=""false"" aria-controls=""collapsePages"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-book-open""></i></div>
                                Pages
                                <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                            </a>
                            <div class=""collapse"" id=""collapsePages"" aria-labelledby=""headingTwo"" data-parent=""#sidenavAccordion"">
                                <nav class=""sb-sidenav-menu-nested nav accordion"" ");
                WriteLiteral(@"id=""sidenavAccordionPages"">
                                    <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#pagesCollapseAuth"" aria-expanded=""false"" aria-controls=""pagesCollapseAuth"">
                                        Authentication
                                        <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                                    </a>
                                    <div class=""collapse"" id=""pagesCollapseAuth"" aria-labelledby=""headingOne"" data-parent=""#sidenavAccordionPages"">
                                        <nav class=""sb-sidenav-menu-nested nav"">
                                            <a class=""nav-link"" href=""login.html"">Login</a>
                                            <a class=""nav-link"" href=""register.html"">Register</a>
                                            <a class=""nav-link"" href=""password.html"">Forgot Password</a>
                                        </nav>
                      ");
                WriteLiteral(@"              </div>
                                    <a class=""nav-link collapsed"" href=""#"" data-toggle=""collapse"" data-target=""#pagesCollapseError"" aria-expanded=""false"" aria-controls=""pagesCollapseError"">
                                        Error
                                        <div class=""sb-sidenav-collapse-arrow""><i class=""fas fa-angle-down""></i></div>
                                    </a>
                                    <div class=""collapse"" id=""pagesCollapseError"" aria-labelledby=""headingOne"" data-parent=""#sidenavAccordionPages"">
                                        <nav class=""sb-sidenav-menu-nested nav"">
                                            <a class=""nav-link"" href=""401.html"">401 Page</a>
                                            <a class=""nav-link"" href=""404.html"">404 Page</a>
                                            <a class=""nav-link"" href=""500.html"">500 Page</a>
                                        </nav>
                                    </div>
        ");
                WriteLiteral(@"                        </nav>
                            </div>
                            <div class=""sb-sidenav-menu-heading"">Addons</div>
                            <a class=""nav-link"" href=""charts.html"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-chart-area""></i></div>
                                Charts
                            </a>
                            <a class=""nav-link"" href=""tables.html"">
                                <div class=""sb-nav-link-icon""><i class=""fas fa-table""></i></div>
                                Tables
                            </a>
                        </div>
                    </div>
                    <div class=""sb-sidenav-footer"">
                        <div class=""small"">Logged in as:</div>
                        Start Bootstrap
                    </div>
                </nav>
            </div>
            <div id=""layoutSidenav_content"">
                <main>
                    <div class=""container-fluid"">
 ");
                WriteLiteral(@"                       <h1 class=""mt-4"">Static Navigation</h1>
                        <ol class=""breadcrumb mb-4"">
                            <li class=""breadcrumb-item""><a href=""index.html"">Dashboard</a></li>
                            <li class=""breadcrumb-item active"">Static Navigation</li>
                        </ol>
                        <div class=""card mb-4"">
                            <div class=""card-body"">
                                <p class=""mb-0"">
                                    This page is an example of using static navigation. By removing the
                                    <code>.sb-nav-fixed</code>
                                    class from the
                                    <code>body</code>
                                    , the top navigation and side navigation will become static on scroll. Scroll down this page to see an example.
                                </p>
                            </div>
                        </div>
                        ");
                WriteLiteral(@"<div style=""height: 100vh;""></div>
                        <div class=""card mb-4""><div class=""card-body"">When scrolling, the navigation stays at the top of the page. This is the end of the static navigation demo.</div></div>
                    </div>
                </main>
                <footer class=""py-4 bg-light mt-auto"">
                    <div class=""container-fluid"">
                        <div class=""d-flex align-items-center justify-content-between small"">
                            <div class=""text-muted"">Copyright &copy; Your Website 2020</div>
                            <div>
                                <a href=""#"">Privacy Policy</a>
                                &middot;
                                <a href=""#"">Terms &amp; Conditions</a>
                            </div>
                        </div>
                    </div>
                </footer>
            </div>
        </div>
        <script src=""https://code.jquery.com/jquery-3.5.1.min.js"" crossorigin=""anonymous""></sc");
                WriteLiteral("ript>\n        <script src=\"https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.bundle.min.js\" crossorigin=\"anonymous\"></script>\n        <script src=\"js/scripts.js\"></script>\n    ");
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
            WriteLiteral("\n</html>\n");
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
