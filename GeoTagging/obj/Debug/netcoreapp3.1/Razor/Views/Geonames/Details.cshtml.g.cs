#pragma checksum "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdbff79a2fda2064a4bd2a4d134d672786662efa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Geonames_Details), @"mvc.1.0.view", @"/Views/Geonames/Details.cshtml")]
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
#line 1 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\_ViewImports.cshtml"
using GeoTagging;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\_ViewImports.cshtml"
using GeoTagging.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdbff79a2fda2064a4bd2a4d134d672786662efa", @"/Views/Geonames/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1916860005284b423512c6ad02dde7a1ce036e21", @"/Views/_ViewImports.cshtml")]
    public class Views_Geonames_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GeoTagging.Models.Geoname>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Geoname</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Asciiname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Asciiname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Alternatenames));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Alternatenames));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fclass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fclass));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Fcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Fcode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Admin1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Admin1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Admin2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Admin2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Admin3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Admin3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Admin4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Admin4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Population));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Population));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Admin1Geonameid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Admin1Geonameid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Admin2Geonameid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.Admin2Geonameid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CountryGeonameid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
       Write(Html.DisplayFor(model => model.CountryGeonameid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdbff79a2fda2064a4bd2a4d134d672786662efa15355", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 112 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Geonames\Details.cshtml"
                           WriteLiteral(Model.Geonameid);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdbff79a2fda2064a4bd2a4d134d672786662efa17533", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GeoTagging.Models.Geoname> Html { get; private set; }
    }
}
#pragma warning restore 1591
