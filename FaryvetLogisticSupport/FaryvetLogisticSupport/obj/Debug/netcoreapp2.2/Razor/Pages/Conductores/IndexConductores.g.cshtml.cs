#pragma checksum "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b39566a00c73ee7bb247625542406afaddd78952"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FaryvetLogisticSupport.Pages.Conductores.Pages_Conductores_IndexConductores), @"mvc.1.0.razor-page", @"/Pages/Conductores/IndexConductores.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Conductores/IndexConductores.cshtml", typeof(FaryvetLogisticSupport.Pages.Conductores.Pages_Conductores_IndexConductores), null)]
namespace FaryvetLogisticSupport.Pages.Conductores
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\_ViewImports.cshtml"
using FaryvetLogisticSupport;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b39566a00c73ee7bb247625542406afaddd78952", @"/Pages/Conductores/IndexConductores.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2520226a5328886ad2036c50c5645c446a94d7d5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Conductores_IndexConductores : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateConductores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "EditConductores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
  
    ViewData["Title"] = "IndexConductores";

#line default
#line hidden
            BeginContext(130, 24, true);
            WriteLiteral("\r\n<h1>Conductores</h1>\r\n");
            EndContext();
            BeginContext(154, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39566a00c73ee7bb247625542406afaddd789526387", async() => {
                BeginContext(217, 15, true);
                WriteLiteral("\r\n    Agregar\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(236, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(240, 3289, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39566a00c73ee7bb247625542406afaddd789527857", async() => {
                BeginContext(260, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
     if (Model.FARYVET_FLS_Conductores.Count() > 0)
    {

#line default
#line hidden
                BeginContext(322, 196, true);
                WriteLiteral("        <br />\r\n        <table id=\"tabla\" class=\"table table-striped border\">\r\n            <thead>\r\n                <tr class=\"table-secondary\">\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(519, 89, false);
#line 20 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                   Write(Html.DisplayNameFor(m => m.FARYVET_FLS_Conductores.FirstOrDefault().NumeroIdentificacion));

#line default
#line hidden
                EndContext();
                BeginContext(608, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(688, 75, false);
#line 23 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                   Write(Html.DisplayNameFor(m => m.FARYVET_FLS_Conductores.FirstOrDefault().Nombre));

#line default
#line hidden
                EndContext();
                BeginContext(763, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(843, 83, false);
#line 26 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                   Write(Html.DisplayNameFor(m => m.FARYVET_FLS_Conductores.FirstOrDefault().PrimerApellido));

#line default
#line hidden
                EndContext();
                BeginContext(926, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1006, 84, false);
#line 29 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                   Write(Html.DisplayNameFor(m => m.FARYVET_FLS_Conductores.FirstOrDefault().SegundoApellido));

#line default
#line hidden
                EndContext();
                BeginContext(1090, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1170, 86, false);
#line 32 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                   Write(Html.DisplayNameFor(m => m.FARYVET_FLS_Conductores.FirstOrDefault().FechaContratacion));

#line default
#line hidden
                EndContext();
                BeginContext(1256, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1336, 75, false);
#line 35 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                   Write(Html.DisplayNameFor(m => m.FARYVET_FLS_Conductores.FirstOrDefault().Estado));

#line default
#line hidden
                EndContext();
                BeginContext(1411, 79, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
                EndContext();
                BeginContext(1491, 78, false);
#line 38 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                   Write(Html.DisplayNameFor(m => m.FARYVET_FLS_Conductores.FirstOrDefault().IsEntrega));

#line default
#line hidden
                EndContext();
                BeginContext(1569, 182, true);
                WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Acciones\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
                EndContext();
#line 46 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                 foreach (var item in Model.FARYVET_FLS_Conductores)
                {

#line default
#line hidden
                BeginContext(1840, 84, true);
                WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(1925, 47, false);
#line 50 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                       Write(Html.DisplayFor(m => item.NumeroIdentificacion));

#line default
#line hidden
                EndContext();
                BeginContext(1972, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2064, 33, false);
#line 53 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                       Write(Html.DisplayFor(m => item.Nombre));

#line default
#line hidden
                EndContext();
                BeginContext(2097, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2189, 41, false);
#line 56 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                       Write(Html.DisplayFor(m => item.PrimerApellido));

#line default
#line hidden
                EndContext();
                BeginContext(2230, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2322, 42, false);
#line 59 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                       Write(Html.DisplayFor(m => item.SegundoApellido));

#line default
#line hidden
                EndContext();
                BeginContext(2364, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2456, 44, false);
#line 62 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                       Write(Html.DisplayFor(m => item.FechaContratacion));

#line default
#line hidden
                EndContext();
                BeginContext(2500, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2592, 33, false);
#line 65 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                       Write(Html.DisplayFor(m => item.Estado));

#line default
#line hidden
                EndContext();
                BeginContext(2625, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2717, 36, false);
#line 68 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                       Write(Html.DisplayFor(m => item.IsEntrega));

#line default
#line hidden
                EndContext();
                BeginContext(2753, 91, true);
                WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
                EndContext();
                BeginContext(2844, 195, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39566a00c73ee7bb247625542406afaddd7895217497", async() => {
                    BeginContext(2965, 70, true);
                    WriteLiteral("\r\n                                Editar\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-NumeroIdentificacion", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 71 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                                                   WriteLiteral(item.NumeroIdentificacion);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["NumeroIdentificacion"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-NumeroIdentificacion", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["NumeroIdentificacion"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3039, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3069, 242, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b39566a00c73ee7bb247625542406afaddd7895220311", async() => {
                    BeginContext(3230, 72, true);
                    WriteLiteral("\r\n                                Eliminar\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-NumeroIdentificacion", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 74 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                                                                                  WriteLiteral(item.NumeroIdentificacion);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["NumeroIdentificacion"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-NumeroIdentificacion", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["NumeroIdentificacion"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3311, 60, true);
                WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
                EndContext();
#line 80 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
                }

#line default
#line hidden
                BeginContext(3390, 50, true);
                WriteLiteral("            </tbody>          \r\n        </table>\r\n");
                EndContext();
#line 83 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
    }
    else
    {

#line default
#line hidden
                BeginContext(3464, 51, true);
                WriteLiteral("        <p>No se encuentran datos disponibles</p>\r\n");
                EndContext();
#line 87 "E:\Documentos\GitHub\Faryvet-Logistic-Support\Faryvet-Logistic-Support\FaryvetLogisticSupport\FaryvetLogisticSupport\Pages\Conductores\IndexConductores.cshtml"
    }

#line default
#line hidden
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3529, 97, true);
            WriteLiteral("\r\n\r\n<link href=\"//cdn.datatables.net/1.10.20/css/jquery.dataTables.min.css\" rel=\"stylesheet\" />\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3643, 875, true);
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.20/js/jquery.dataTables.min.js""></script>
    <script>
    $(document).ready(function () {
        $(""#tabla"").datatable().fnDestroy();
        $(""#tabla"").dataTable({
            ""responsive"":true,
            ""ajax"": {
                ""url"": ""/Pages/VehiculosTransporte/IndexConductores/GetList"",
                ""type"": ""GET"",
                ""datatype"": ""json""
            },
            ""columns"": [
                { ""data"": ""NumeroIdentificacion"" },
                { ""data"": ""Nombre"" },
                { ""data"": ""Modelo"" },
                { ""data"": ""PrimerApellido"" },
                { ""data"": ""SegundoApellido"" },
                { ""data"": ""FechaContratacion"" },
                { ""data"": ""IsEntrega"" },
                { ""data"": ""Acciones"" }
            ],

        });
    });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FaryvetLogisticSupport.Pages.Conductores.IndexConductoresModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FaryvetLogisticSupport.Pages.Conductores.IndexConductoresModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FaryvetLogisticSupport.Pages.Conductores.IndexConductoresModel>)PageContext?.ViewData;
        public FaryvetLogisticSupport.Pages.Conductores.IndexConductoresModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591