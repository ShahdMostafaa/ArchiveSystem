#pragma checksum "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45742af041295cc74f5fab55a5e95d7644fb8c99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_ShowAll), @"mvc.1.0.view", @"/Views/User/ShowAll.cshtml")]
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
#line 1 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\_ViewImports.cshtml"
using ArchiveSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\_ViewImports.cshtml"
using ArchiveSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45742af041295cc74f5fab55a5e95d7644fb8c99", @"/Views/User/ShowAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bf0f816de4d66f3369d536af6119ec924ae6ac1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_ShowAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary btn-sm rounded-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("tooltip"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-placement", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" color:white;background-color:#CD9775; border-color:#CD9775"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString(" color:white;background-color:#854442; border-color:#854442 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
  
    Layout = "_AdminLayout"; // Set the layout for this view

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Header -->
<div class=""container text-center mb-5 login-btn"">
    <div>
        <h1 style=""color:black""> All Users </h1> <!-- Heading for the page -->
        <hr class="" w/75"" /> <!-- Horizontal line -->
    </div>
</div>

<style>
    .input-group {
        width: 50%;
        display: flex;
        justify-content: center; /* Added to center search button */
        margin: 0 auto; /* Added to center input group */
    }

    select {
        width: 150px;
    }

        select:focus {
            min-width: 150px;
            width: auto;
        }
</style>

<style>
    body {
        background-image: url('../login/img/bench-accounting-nvzvopqw0gc-unsplash.jpg'); /* Set background image */
        background-repeat: no-repeat;
        background-attachment: fixed;
        background-size: 100% 100%;
    }
</style>

<!-- Search input and button -->
<div>
    <div class=""input-group"">
        <select id=""inputType"" class=""form-select"" aria-label=""Select input type"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45742af041295cc74f5fab55a5e95d7644fb8c997750", async() => {
                WriteLiteral("Text/Email");
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
            WriteLiteral(@"
        </select>
        <input id=""searchInput"" type=""text"" class=""form-control"" aria-label=""Sizing example input"" aria-describedby=""inputGroup-sizing-sm"">
        <button id=""searchButton"" type=""button"" style=""color:white; background-color:#CD9775; border-color:#CD9775"" class=""btn btn-outline-primary"">Search</button>
    </div>
</div>

<script>
    const inputTypeSelect = document.getElementById('inputType');
    const searchInput = document.getElementById('searchInput');

    inputTypeSelect.addEventListener('change', function () {
        const selectedType = this.value;
        searchInput.type = selectedType;
    });
</script>

<!-- User table -->
<div class=""container rounded mt-5 mb-5"">
    <div id=""datatable""></div> <!-- Placeholder for datatable -->
    <div dir=""ltr"">
        <table class=""table table-striped table-hover"">
            <thead class=""table-light"">
                <tr>
                    <th scope=""col"">ID</th>
                    <th scope=""col"">User Name</th>
                    ");
            WriteLiteral(@"<th scope=""col"">Email</th>
                    <th scope=""col"">Job Tutle</th>
                    <th scope=""col"">Mobile Number</th>
                    <th scope=""col"">Action</th>
                </tr>
            </thead>
            <tbody>
                <!-- Loop through all users in ViewBag.AllUsers and display their information -->
");
#nullable restore
#line 78 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
                 foreach (var user in ViewBag.AllUsers)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td>");
#nullable restore
#line 81 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
                       Write(user.UserAccID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 82 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
                       Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 83 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
                       Write(user.AcadMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 84 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
                       Write(user.JobTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 85 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
                       Write(user.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>\n                            <!-- Edit and delete buttons for each user -->\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45742af041295cc74f5fab55a5e95d7644fb8c9912167", async() => {
                WriteLiteral("<i class=\"fa fa-table\"></i>Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2951, "~/User/editUser/", 2951, 16, true);
#nullable restore
#line 88 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
AddHtmlAttributeValue("", 2967, user.UserAccID, 2967, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45742af041295cc74f5fab55a5e95d7644fb8c9914261", async() => {
                WriteLiteral("<i class=\"fa fa-table\"></i>Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3244, "~/User/Delete/", 3244, 14, true);
#nullable restore
#line 89 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
AddHtmlAttributeValue("", 3258, user.UserAccID, 3258, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                            <!-- Uncomment the line below to add a details button -->\n                            <!-- <a href=\"/User/Delete/");
#nullable restore
#line 91 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
                                                  Write(user.UserAccID);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""btn btn-outline-primary btn-sm rounded-0"" type=""button"" data-toggle=""tooltip"" data-placement=""top"" title=""Details"" style=""color:white;background-color:#0A0055""><i class=""fa fa-table""></i>Details</a> -->
                        </td>
                    </tr>
");
#nullable restore
#line 94 "F:\123life\programming\mvc\5.0\ArchiveSystem\ArchiveSystem\Views\User\ShowAll.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </tbody>
        </table>
    </div>
</div>

<script>
    document.getElementById('searchButton').addEventListener('click', function () {
        // Get the search query from the input
        var searchQuery = document.getElementById('searchInput').value;

        // Reload the page with the search query as a query parameter
        window.location.href = 'https://localhost:44339/Home/ShowAll?query=' + encodeURIComponent(searchQuery);
    });
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
