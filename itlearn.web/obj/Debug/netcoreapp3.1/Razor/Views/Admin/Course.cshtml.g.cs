#pragma checksum "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e870e9b8dbd696faba009089843c273738808b65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Course), @"mvc.1.0.view", @"/Views/Admin/Course.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Language;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Chapter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Theme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Question;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Answer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Notification;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Comment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Search;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Story;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Achievement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.dal.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.ViewModels.Advice;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.model.Responses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.bll.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\_ViewImports.cshtml"
using itlearn.dal.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e870e9b8dbd696faba009089843c273738808b65", @"/Views/Admin/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
  
    ViewData["Title"] = "Course";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .course-link:hover {
        border-left: 3px solid #ffffff;
    }

    div.img-container {
        position: relative
    }

        div.img-container img {
            margin: 0;
            position: absolute;
            top: 50%;
            border-radius: 50%;
            left: 50%;
            margin-right: -50%;
            transform: translate(-50%, -50%)
        }

    .dot {
        height: 50px;
        width: 50px;
        background-color: rgba(0, 0, 0, 1);
        border-radius: 50%;
        border: 6px solid rgb(255, 255, 255);
        opacity: 0.7;
        display: inline-block;
        position: relative;
        top: 160px;
        left: 145px;
    }

        .dot span {
            margin: 0;
            position: absolute;
            font-size: 18px;
            top: 50%;
            left: 50%;
            margin-right: -50%;
            transform: translate(-50%, -50%)
        }

    .lable {
        font-size: 14px;
        ba");
            WriteLiteral(@"ckground: #ad87de;
        font-weight: 600;
        text-transform: uppercase;
        padding: 2px 10px;
        border-radius: 20px;
    }

    .lable-success {
        font-size: 14px;
        background: #28ff5a;
        font-weight: 600;
        text-transform: uppercase;
        padding: 2px 10px;
        border-radius: 20px;
    }

    .lable-warning {
        font-size: 14px;
        background: #ff6a00;
        font-weight: 600;
        text-transform: uppercase;
        padding: 2px 10px;
        border-radius: 20px;
    }
</style>

<div class=""content-wrapper"">
    <section class=""content"">
        <div class=""container-fluid"">
            <div>
                <h1>Новые курсы</h1>
                <br />
                <hr />
            </div>
            <section class=""content"">
                <div class=""container-fluid"">
                    <div class=""row m-5"">
");
#nullable restore
#line 89 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
                         if (Model.Count != 0)
                        {
                            foreach (Course course in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-md-12 card shadow\">\r\n                                    <div class=\"row no-gutters\">\r\n                                        <div class=\"col-md-3\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 2485, "\"", 2518, 1);
#nullable restore
#line 96 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
WriteAttributeValue("", 2491, Url.Content(course.Avatar), 2491, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""m-4"" style=""height: 200px; width: 250px;"" alt=""..."">
                                        </div>
                                        <div class=""col-md-9"">
                                            <div class=""card-body"">
                                                <div class=""row"">
                                                    <div class=""col-md-9"">
                                                        <p");
            BeginWriteAttribute("class", " class=\"", 2963, "\"", 2971, 0);
            EndWriteAttribute();
            WriteLiteral("><b>");
#nullable restore
#line 102 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
                                                                  Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                                                        <p><b>Создан: </b>");
#nullable restore
#line 103 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
                                                                     Write(course.CreatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        <p><b>Изменен: </b>");
#nullable restore
#line 104 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
                                                                      Write(course.UpdatedDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                                        <p");
            BeginWriteAttribute("class", " class=\"", 3296, "\"", 3304, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                            ");
#nullable restore
#line 106 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
                                                       Write(course.ShortDesciption);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </p>
                                                    </div>
                                                    <div class=""col-md-3"">
                                                        <span class=""lable"">+");
#nullable restore
#line 110 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
                                                                        Write(course.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral(" опыта</span>\r\n                                                        <br />\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 3823, "\"", 3875, 2);
            WriteAttributeValue("", 3830, "/Admin/CourseDetail?courseId=", 3830, 29, true);
#nullable restore
#line 112 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
WriteAttributeValue("", 3859, course.CourseId, 3859, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info mt-2\" style=\"width: 100%\">Детали</a>\r\n                                                        <br />\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 4057, "\"", 4110, 2);
            WriteAttributeValue("", 4064, "/Admin/CourseApprove?courseId=", 4064, 30, true);
#nullable restore
#line 114 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
WriteAttributeValue("", 4094, course.CourseId, 4094, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success mt-2"" style=""width: 100%"">Подтвердить</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 121 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Admin\Course.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </section>\r\n        </div>\r\n    </section>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591