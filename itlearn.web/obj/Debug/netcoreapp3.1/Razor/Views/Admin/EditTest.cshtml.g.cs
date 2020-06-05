#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc342856bfe9ab689a3c34158d727a22e618fb3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_EditTest), @"mvc.1.0.view", @"/Views/Admin/EditTest.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Language;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Chapter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Question;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Answer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Notification;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Comment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Story;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Achievement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.dal.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Advice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.bll.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\Projects\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.dal.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc342856bfe9ab689a3c34158d727a22e618fb3f", @"/Views/Admin/EditTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_EditTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TestVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
  
    var theme = await themeService.GetById(Model.ThemeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"content-wrapper\">\r\n    <section class=\"content\">\r\n        <div class=\"container-fluid\">\r\n            <h1>Изменение</h1>\r\n            <h3>Тема: ");
#nullable restore
#line 15 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
                 Write(theme.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <hr />\r\n");
#nullable restore
#line 17 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
             using (Html.BeginForm("EditTest", "Admin", FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <input type=\"hidden\" name=\"TestId\"");
            BeginWriteAttribute("value", " value=\"", 641, "\"", 662, 1);
#nullable restore
#line 22 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
WriteAttributeValue("", 649, Model.TestId, 649, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"ThemeId\"");
            BeginWriteAttribute("value", " value=\"", 719, "\"", 741, 1);
#nullable restore
#line 23 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
WriteAttributeValue("", 727, Model.ThemeId, 727, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
            WriteLiteral(@"                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label""><b>Уровень сложности</b></label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Level""");
            BeginWriteAttribute("value", " value=\"", 1009, "\"", 1029, 1);
#nullable restore
#line 28 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
WriteAttributeValue("", 1017, Model.Level, 1017, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
#nullable restore
#line 29 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Level, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>
                </div>
                <div class=""form-group row"">
                    <label class=""col-sm-2 col-form-label""><b>Описание</b></label>
                    <div class=""col-sm-10"">
                        <input type=""text"" class=""form-control"" name=""Description"">
                        ");
#nullable restore
#line 36 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("                <input type=\"submit\" class=\"btn btn-outline-success\" value=\"Изменить\" />\r\n");
#nullable restore
#line 41 "E:\Projects\itlearn\itlearn.web\Views\Admin\EditTest.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </section>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IThemeService themeService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TestVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
