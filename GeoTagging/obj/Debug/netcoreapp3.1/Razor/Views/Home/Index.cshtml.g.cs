#pragma checksum "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40250042112210be0ae16538e368e6e7b8bc8751"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"40250042112210be0ae16538e368e6e7b8bc8751", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1916860005284b423512c6ad02dde7a1ce036e21", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetGeonameId", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("myForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

    /// List of empty string instantiate
    List<string> nlls = new List<string>();


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome To The GeoTagging Project!</h1>\r\n</div>\r\n\r\n");
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40250042112210be0ae16538e368e6e7b8bc87515476", async() => {
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Selct a Country:</label>\r\n                <select id=\"countrySelect\" class=\"form-control\" name=\"countryName\" required>\r\n");
#nullable restore
#line 20 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml"
                     foreach (var item in nlls)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40250042112210be0ae16538e368e6e7b8bc87516266", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 22 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml"
                                                  //works faster cause its empty initially
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Select a State/Provience:</label>
                <select id=""stateSelect"" class=""form-control"" name=""stateName"" disabled>
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40250042112210be0ae16538e368e6e7b8bc87518023", async() => {
                    WriteLiteral("--Select a State/Provience--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml"
                     foreach (var item in nlls)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40250042112210be0ae16538e368e6e7b8bc87519581", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 32 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml"
                                                  //works faster cause its empty initially
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                </select>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Select a County:</label>
                <select id=""countySelect"" class=""form-control"" disabled name=""countyName"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40250042112210be0ae16538e368e6e7b8bc875111331", async() => {
                    WriteLiteral("--Select a County--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml"
                     foreach (var item in nlls)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40250042112210be0ae16538e368e6e7b8bc875112881", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 43 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml"
                        //works faster cause its empty initially
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </select>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <label class=\"control-label\">Enter in a Location:</label>\r\n                <input class=\"form-control\" type=\"text\" id=\"locationInput\" name=\"locationName\"");
                BeginWriteAttribute("value", " value=\"", 2167, "\"", 2175, 0);
                EndWriteAttribute();
                WriteLiteral(" autocomplete=\"on\" required />\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Get Geonameid\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n        $(document).ready(function () {\r\n\r\n");
                WriteLiteral("\r\n            $(\"#countrySelect\").change(function () {\r\n                $(\"countrySelect\").empty();\r\n                $(\"stateSelect\").prop(\'disabled\', false);\r\n                $.ajax({\r\n                type: \'POST\',\r\n                url: \'");
#nullable restore
#line 70 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml"
                 Write(Url.Action("GetCountryList"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    dataType: 'json',
                success: function (countrySelects) {
                    $(""#countrySelect"").append('<option value=""' + """" + '"">' + ""--Select a Country--"" + '</option>');
                    $.each(countrySelects, function (i, countrySelect) {
                        $(""#countrySelect"").append('<option value=""' + countrySelect.isoCode + '"">' + countrySelect.name + '</option>');
                    });
                },
                error: function (ex) {
                    alert('Failed to retrieve Countries' + ex);
                }
            });
            return false;
            })

            $(""#countrySelect"").trigger(""change"");

");
                WriteLiteral("\r\n            $(\"#countrySelect\").change(function () {\r\n              $(\"#stateSelect\").empty();\r\n              $(\"#stateSelect\").prop(\'disabled\', false);\r\n              $.ajax({\r\n                  type: \'POST\',\r\n                  url: \'");
#nullable restore
#line 94 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml"
                   Write(Url.Action("GetStatesList"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                  dataType: 'json',
                  data: { id: $(""#countrySelect"").val() },
                  success: function (stateSelects) {
                      $(""#stateSelect"").append('<option value=""' + """" + '"">' + ""--Select a State/Provience--"" + '</option>');
                      $.each(stateSelects, function (i, stateSelect) {
                          $(""#stateSelect"").append('<option value=""' + stateSelect.admin1 + '"">' + stateSelect.name + '</option>');
                      });
                  },
                  error: function (ex) {
                      alert('Failed to retrieve States' + ex);
                  }
              });
              return false;
          })

");
                WriteLiteral("\r\n          $(\"#stateSelect\").change(function () {\r\n              $(\"#countySelect\").empty();\r\n              $(\"#countySelect\").prop(\'disabled\', false);\r\n              $.ajax({\r\n                  type: \'POST\',\r\n                  url: \'");
#nullable restore
#line 117 "C:\Users\Meetp\OneDrive\ETSU\Senior Project\GeoProject\GeoTagging\GeoTagging\Views\Home\Index.cshtml"
                   Write(Url.Action("GetCountyList"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                  dataType: 'json',
                  data: { id: $(""#stateSelect"").val() },
                  success: function (countySelects) {
                      $(""#countySelect"").append('<option value=""' + """" + '"">' + ""--Select a County--"" + '</option>');
                      $.each(countySelects, function (i, countySelect) {
                          $(""#countySelect"").append('<option value=""' + countySelect.admin2 + '"">' + countySelect.admin2name + '</option>');

                      });
                  },
                  error: function (ex) {
                      alert('Failed to retrieve Counties.' + ex);
                  }
              });
              return false;
          })

      });

    </script>
");
            }
            );
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