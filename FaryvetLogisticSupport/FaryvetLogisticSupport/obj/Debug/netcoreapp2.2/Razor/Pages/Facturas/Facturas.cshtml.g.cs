#pragma checksum "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6811182af6ed03cfbaddb51b9eb47606c59aca19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FaryvetLogisticSupport.Pages.Facturas.Pages_Facturas_Facturas), @"mvc.1.0.razor-page", @"/Pages/Facturas/Facturas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Facturas/Facturas.cshtml", typeof(FaryvetLogisticSupport.Pages.Facturas.Pages_Facturas_Facturas), null)]
namespace FaryvetLogisticSupport.Pages.Facturas
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\_ViewImports.cshtml"
using FaryvetLogisticSupport;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6811182af6ed03cfbaddb51b9eb47606c59aca19", @"/Pages/Facturas/Facturas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2520226a5328886ad2036c50c5645c446a94d7d5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Facturas_Facturas : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 3 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
  
    ViewData["Title"] = "Facturas";

#line default
#line hidden
            BeginContext(111, 23, true);
            WriteLiteral("\r\n<h1>Facturas</h1>\r\n\r\n");
            EndContext();
            BeginContext(134, 2574, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6811182af6ed03cfbaddb51b9eb47606c59aca193991", async() => {
                BeginContext(154, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 10 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
     if (Model.Facturas.Count() > 0)
    {

#line default
#line hidden
                BeginContext(201, 223, true);
                WriteLiteral("     <table id=\"tabla\" class=\"table table-striped display nowrap\" cellspacing=\"0\" width=\"100%\" style=\"margin-bottom: 0\">\r\n        <thead>\r\n            <tr class=\"table-secondary\">\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(425, 56, false);
#line 16 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
               Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().Id));

#line default
#line hidden
                EndContext();
                BeginContext(481, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(549, 67, false);
#line 19 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
               Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().FormaDespacho));

#line default
#line hidden
                EndContext();
                BeginContext(616, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(684, 58, false);
#line 22 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
               Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().Peso));

#line default
#line hidden
                EndContext();
                BeginContext(742, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(810, 64, false);
#line 25 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
               Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().FormaCobro));

#line default
#line hidden
                EndContext();
                BeginContext(874, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(942, 60, false);
#line 28 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
               Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().Moneda));

#line default
#line hidden
                EndContext();
                BeginContext(1002, 67, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1070, 61, false);
#line 31 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
               Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().Cliente));

#line default
#line hidden
                EndContext();
                BeginContext(1131, 143, true);
                WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Ubicación\r\n                </th>\r\n                <th>\r\n                    ");
                EndContext();
                BeginContext(1275, 65, false);
#line 37 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
               Write(Html.DisplayNameFor(m => m.Facturas.FirstOrDefault().Comentarios));

#line default
#line hidden
                EndContext();
                BeginContext(1340, 79, true);
                WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
                EndContext();
#line 42 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
             foreach (var item in Model.Facturas)
            {

#line default
#line hidden
                BeginContext(1485, 72, true);
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1558, 29, false);
#line 46 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayFor(m => item.Id));

#line default
#line hidden
                EndContext();
                BeginContext(1587, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1667, 40, false);
#line 49 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayFor(m => item.FormaDespacho));

#line default
#line hidden
                EndContext();
                BeginContext(1707, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1787, 31, false);
#line 52 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayFor(m => item.Peso));

#line default
#line hidden
                EndContext();
                BeginContext(1818, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(1898, 37, false);
#line 55 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayFor(m => item.FormaCobro));

#line default
#line hidden
                EndContext();
                BeginContext(1935, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2015, 33, false);
#line 58 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayFor(m => item.Moneda));

#line default
#line hidden
                EndContext();
                BeginContext(2048, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2128, 34, false);
#line 61 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayFor(m => item.Cliente));

#line default
#line hidden
                EndContext();
                BeginContext(2162, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2242, 36, false);
#line 64 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayFor(m => item.Provincia));

#line default
#line hidden
                EndContext();
                BeginContext(2278, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2305, 33, false);
#line 65 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayFor(m => item.Canton));

#line default
#line hidden
                EndContext();
                BeginContext(2338, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(2365, 35, false);
#line 66 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayFor(m => item.Distrito));

#line default
#line hidden
                EndContext();
                BeginContext(2400, 79, true);
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
                EndContext();
                BeginContext(2480, 38, false);
#line 69 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
                   Write(Html.DisplayFor(m => item.Comentarios));

#line default
#line hidden
                EndContext();
                BeginContext(2518, 52, true);
                WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
                EndContext();
#line 72 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
            }

#line default
#line hidden
                BeginContext(2585, 34, true);
                WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n");
                EndContext();
#line 76 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(2643, 51, true);
                WriteLiteral("        <p>No se encuentran datos disponibles</p>\r\n");
                EndContext();
#line 80 "C:\Users\mauri\OneDrive\Documentos\GitHub\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Facturas\Facturas.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2708, 97, true);
            WriteLiteral("\r\n\r\n<link href=\"//cdn.datatables.net/1.10.20/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2822, 1097, true);
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <script>
        $(document).ready(function () {
            $(""#tabla"").datatable().fnDestroy();
            $(""#tabla"").dataTable({
                ""scrollX"": true,
                ""scrollY"": 200,
                ""ajax"": {
                    ""url"": ""/Pages/Facturas/FacturasEspeciales/GetList"",
                    ""type"": ""GET"",
                    ""datatype"": ""json""
                },
                ""columns"": [
                    { ""data"": ""Id"" },
                    { ""data"": ""FormaDespacho"" },
                    { ""data"": ""Peso"" },
                    { ""data"": ""FormaCobro"" },
                    { ""data"": ""Moneda"" },
                    { ""data"": ""Cliente"" },
                    { ""data"": ""Provincia"" },
                    { ""data"": ""Canton"" },
                    { ""data"": ""Distrito"" },
                    { ""data"": ""Comentarios"" }
                ],

            }); 
            $('");
                WriteLiteral(".dataTables_length\').addClass(\'bs-select\');\r\n        });\r\n    </script>\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FaryvetLogisticSupport.Pages.Facturas.FacturasModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FaryvetLogisticSupport.Pages.Facturas.FacturasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FaryvetLogisticSupport.Pages.Facturas.FacturasModel>)PageContext?.ViewData;
        public FaryvetLogisticSupport.Pages.Facturas.FacturasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
