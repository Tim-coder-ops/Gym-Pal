#pragma checksum "C:\Users\Timwe\OneDrive\Documents\MSSA\Gym Pal\GymPal\GymPal\Views\Shared\AboutUs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecdf9ed430e70bc74d30b6eef8f2e52cc88ee762"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_AboutUs), @"mvc.1.0.view", @"/Views/Shared/AboutUs.cshtml")]
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
#line 1 "C:\Users\Timwe\OneDrive\Documents\MSSA\Gym Pal\GymPal\GymPal\Views\_ViewImports.cshtml"
using GymPal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Timwe\OneDrive\Documents\MSSA\Gym Pal\GymPal\GymPal\Views\_ViewImports.cshtml"
using GymPal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecdf9ed430e70bc74d30b6eef8f2e52cc88ee762", @"/Views/Shared/AboutUs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"926641a90c93abbfc2e30df9ef20a0f41a534dff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_AboutUs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecdf9ed430e70bc74d30b6eef8f2e52cc88ee7623279", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>About US</title>

     <!-- Google Font -->
    <link href=""https://fonts.googleapis.com/css?family=Nunito+Sans:400,600,700,800,900&display=swap"" rel=""stylesheet"">
    <link href=""https://fonts.googleapis.com/css?family=Oswald:300,400,500,600,700&display=swap"" rel=""stylesheet"">


    <!-- Css Styles -->
    <link rel=""stylesheet"" href=""css/bootstrap.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""css/font-awesome.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""css/elegant-icons.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""css/nice-select.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""css/magnific-popup.css"" type=""text/css"">
    <link rel=""stylesheet"" href=""css/slicknav.min.css"" type=""text/css"">
    <link");
                WriteLiteral(" rel=\"stylesheet\" href=\"css/style1.css\" type=\"text/css\">\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ecdf9ed430e70bc74d30b6eef8f2e52cc88ee7625427", async() => {
                WriteLiteral("\r\n\r\n        <header class=\"header-section\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"logo\">\r\n                <a href=\"home\">\r\n                    <img src=\"img/Logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1330, "\"", 1336, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                </a>
            </div>
            <div class=""container"">
                <div class=""nav-menu"">
                    <nav class=""mainmenu mobile-menu"">
                        <ul>
                            <li class=""active""><a href=""home"">Home</a></li>
                            <li><a href=""login"">Login</a></li>
                            <li><a href=""register"">Create Account</a></li>
                        </ul>
                    </nav>
                </div>
            </div>
            <div id=""mobile-menu-wrap""></div>
        </div>
    </header>
        <section class=""home-about spad"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""about-text"">
                        <h2>About Us</h2>
                        <p class=""long-details"">My name is Tim, and I am the creator of Gym Pal.
                             I started going to the gym about six years ago. When I ");
                WriteLiteral(@"first walked into the gym,
                             I was not very knowledgeable and just thought you had to lift weights, and you would 
                            end up looking like the people on fitness magazines. I quickly realized this was not the
                            case. I enlisted in the Marine Corps in 2016, and the gym became my passion. I loved the challenge,
                            the physical and mental benefits, and the dedication it takes. With this new passion, I started
                            researching what it takes to succeed in the gym. I read about macros, progressive overload, recovery,
                            and exercise form. I started taking a notebook to the gym to track my workouts and also started tracking
                            my macros. After applying this knowledge and these tools, I went from 170lbs to 220lbs and could not be
                            happier. But in life, we should always seek to continue to progress and improve. T");
                WriteLiteral(@"his is one reason why
                            I decided to create this app. I wanted a platform that would allow me to track workouts how I wanted, 
                            along with providing other useful features that I could use to improve myself. Gym Pal is an app created 
                            by a lifter for lifters. With that being said, I want to continually improve this app and provide features
                            that other lifts would like to have. If you have any feedback or recommendations, please send an email to
                            Gym.Pal@outlook.com, and I will look at implementing any suggestions that could help users.  Thank you for
                            looking at Gym Pal and stay driven to achieve your goals!
                        </p>

                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""about-img"">
                        <img src=""img\AboutMe.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 4388, "\"", 4394, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </section>

        <!-- Js Plugins -->
    <script src=""js/jquery-3.3.1.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <script src=""js/jquery.magnific-popup.min.js""></script>
    <script src=""js/mixitup.min.js""></script>
    <script src=""js/jquery.nice-select.min.js""></script>
    <script src=""js/jquery.slicknav.js""></script>
    <script src=""js/owl.carousel.min.js""></script>
    <script src=""js/masonry.pkgd.min.js""></script>
    <script src=""js/main.js""></script>
    
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
