#pragma checksum "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a6ff5e48228c82bbf28bb5705d9f66c62fe7122"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ToDoAppHD.Pages.ToDoList.Pages_ToDoList_index), @"mvc.1.0.razor-page", @"/Pages/ToDoList/index.cshtml")]
namespace ToDoAppHD.Pages.ToDoList
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
#line 1 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\_ViewImports.cshtml"
using ToDoAppHD;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a6ff5e48228c82bbf28bb5705d9f66c62fe7122", @"/Pages/ToDoList/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d470a943521867527701026ff69e876f82f4fe10", @"/Pages/_ViewImports.cshtml")]
    public class Pages_ToDoList_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Esta seguro de querer borrar el curso?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
  
    ViewData["Title"] = "ToDoList";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br />\r\n<div class=\"container row\">\r\n    <div class=\"col-6\">\r\n        <h2 class=\"text-info\">To Do List</h2>\r\n    </div>\r\n    <div class=\"col-6 text-right\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a6ff5e48228c82bbf28bb5705d9f66c62fe71226600", async() => {
                WriteLiteral("New task");
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
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
#nullable restore
#line 18 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
 if (Model.Mensaje != null)
{   

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <div class=\"alert alert-info alert-dismissible\" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"close\">\r\n            <span aria-hidden=\"true\">&times;</span>\r\n        </button>\r\n        ");
#nullable restore
#line 25 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
   Write(Model.Mensaje);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 27 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a6ff5e48228c82bbf28bb5705d9f66c62fe71228891", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
     if (Model.toDoModel.Count() > 0)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <br />
        <table class=""table table-striped border"">
            <tr class=""table-secondary"">
                <th>
                    Title
                </th>
                <th>
                    Description
                </th>
                <th>
                    Date
                </th>
                <th>
                    Priority
                </th>
                <th>
                    <svg class=""bi bi-list-check"" width=""1em"" height=""1em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                        <path fill-rule=""evenodd"" d=""M5 11.5a.5.5 0 01.5-.5h9a.5.5 0 010 1h-9a.5.5 0 01-.5-.5zm0-4a.5.5 0 01.5-.5h9a.5.5 0 010 1h-9a.5.5 0 01-.5-.5zm0-4a.5.5 0 01.5-.5h9a.5.5 0 010 1h-9a.5.5 0 01-.5-.5zM3.854 2.146a.5.5 0 010 .708l-1.5 1.5a.5.5 0 01-.708 0l-.5-.5a.5.5 0 11.708-.708L2 3.293l1.146-1.147a.5.5 0 01.708 0zm0 4a.5.5 0 010 .708l-1.5 1.5a.5.5 0 01-.708 0l-.5-.5a.5.5 0 11.708-.708L2 7.293l1.146-1.147a.5.5 0 01.708 0z");
                WriteLiteral(@"m0 4a.5.5 0 010 .708l-1.5 1.5a.5.5 0 01-.708 0l-.5-.5a.5.5 0 01.708-.708l.146.147 1.146-1.147a.5.5 0 01.708 0z"" clip-rule=""evenodd"" />
                    </svg>
                </th>
                <th>
                    Acciones
                </th>
            </tr>
");
#nullable restore
#line 57 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
             foreach (var item in Model.toDoModel)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 60 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
               Write(Html.DisplayFor(m => item.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 61 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
               Write(Html.DisplayFor(m => item.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 62 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
               Write(Convert.ToString(string.Format("{0:dd/MM/yyyy}", item.Date)));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 63 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
               Write(Html.DisplayFor(m => item.Priority));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 65 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
                    if (item.Status == true)
                    {


#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <svg class=""bi bi-check"" width=""1em"" height=""1em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                      <path fill-rule=""evenodd"" d=""M13.854 3.646a.5.5 0 010 .708l-7 7a.5.5 0 01-.708 0l-3.5-3.5a.5.5 0 11.708-.708L6.5 10.293l6.646-6.647a.5.5 0 01.708 0z"" clip-rule=""evenodd""/>
                    </svg>
");
#nullable restore
#line 71 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
                
                    }
                    else
                    {
                

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <svg class=""bi bi-x"" width=""1em"" height=""1em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                        <path fill-rule=""evenodd"" d=""M11.854 4.146a.5.5 0 010 .708l-7 7a.5.5 0 01-.708-.708l7-7a.5.5 0 01.708 0z"" clip-rule=""evenodd"" />
                        <path fill-rule=""evenodd"" d=""M4.146 4.146a.5.5 0 000 .708l7 7a.5.5 0 00.708-.708l-7-7a.5.5 0 00-.708 0z"" clip-rule=""evenodd"" />
                    </svg>
");
#nullable restore
#line 80 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
                
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </td>\r\n                <td>\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a6ff5e48228c82bbf28bb5705d9f66c62fe712214266", async() => {
                    WriteLiteral("Borrar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 84 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
                                                        WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a6ff5e48228c82bbf28bb5705d9f66c62fe712216795", async() => {
                    WriteLiteral("Editar");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
                         WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 88 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </table>\r\n");
#nullable restore
#line 90 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br />\r\n        <p>You do not have anything to do!</p>\r\n");
#nullable restore
#line 95 "C:\Users\Francis\Documents\Francis\Search4Solutions\Workspace\ToDoAppHD\ToDoAppHD\Pages\ToDoList\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoAppHD.Pages.ToDoList.ToDoListModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ToDoAppHD.Pages.ToDoList.ToDoListModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ToDoAppHD.Pages.ToDoList.ToDoListModel>)PageContext?.ViewData;
        public ToDoAppHD.Pages.ToDoList.ToDoListModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
