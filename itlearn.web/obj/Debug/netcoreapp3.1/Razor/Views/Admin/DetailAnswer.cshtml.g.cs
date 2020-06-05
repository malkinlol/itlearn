#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailAnswer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47643b0788f33a4f03d64687fe867825be83202b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DetailAnswer), @"mvc.1.0.view", @"/Views/Admin/DetailAnswer.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47643b0788f33a4f03d64687fe867825be83202b", @"/Views/Admin/DetailAnswer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DetailAnswer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AnswerVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailAnswer.cshtml"
  
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailAnswer.cshtml"
  

    var questionName = questionService.GetById(Model.QuestionId)
        .GetAwaiter().GetResult()
        .SomeQuestion;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"content-wrapper\">\r\n    <section class=\"content\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"alert alert-light mt-2 mb-2\">\r\n                <h2>Вопрос: ");
#nullable restore
#line 18 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailAnswer.cshtml"
                       Write(questionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <hr />\r\n                <p>\r\n                    Ответ: ");
#nullable restore
#line 21 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailAnswer.cshtml"
                      Write(Model.SomeAnswer);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 22 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailAnswer.cshtml"
                     if (Model.IsRight)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"text-success ml-2\">Правильный</span>\r\n");
#nullable restore
#line 25 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailAnswer.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span class=\"text-danger ml-2\">Правильный</span>\r\n");
#nullable restore
#line 29 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailAnswer.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 899, "\"", 948, 2);
            WriteAttributeValue("", 906, "/Admin/EditAnswer?answerId=", 906, 27, true);
#nullable restore
#line 31 "E:\Projects\itlearn\itlearn.web\Views\Admin\DetailAnswer.cshtml"
WriteAttributeValue("", 933, Model.AnswerId, 933, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Изменить</a>\r\n            </div>\r\n        </div>\r\n    </section>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IQuestionService questionService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AnswerVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
