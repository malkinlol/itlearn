#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32f05e69778557917505be1dc2545d1d2309bc87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CourseDetail), @"mvc.1.0.view", @"/Views/Admin/CourseDetail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32f05e69778557917505be1dc2545d1d2309bc87", @"/Views/Admin/CourseDetail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CourseDetail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
  
    ViewData["Title"] = "CourseDetail";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
  
    var user = await _userManager.FindByNameAsync(User.Identity.Name);

    var courseLearns = _context.CourseLearn
        .Where(x => x.CourseId == Model.CourseId)
        .ToList();
    var requirments = _context.Requirements
        .Where(x => x.CourseId == Model.CourseId)
        .ToList();
    var courseThemes = _context.CourseThemes
        .Where(x => x.CourseId == Model.CourseId)
        .ToList();
    var adminComments = _context.CourseComments
        .Where(x => x.isAdmin && x.CourseId == Model.CourseId)
        .OrderByDescending(x => x.CommentDate)
        .ToList();


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
        back");
            WriteLiteral(@"ground: #ad87de;
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
                <h1>Детали курса</h1>
                <br />
                <hr />
            </div>
            <section class=""content"">
                <div class=""container-fluid"">
                    <div class=""row m-5"">
                        <div class=""col-md-12"">
                            <div class=""car");
            WriteLiteral("d shadow mt-4\" style=\"background: none; border:none;\">\r\n                                <div class=\"card-header\">\r\n                                    <h2");
            BeginWriteAttribute("class", " class=\"", 3007, "\"", 3015, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 112 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                            Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                    <br />\r\n                                    <p class=\"text-secondary\"><b>Автор: </b>");
#nullable restore
#line 114 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                                       Write(user.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 114 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                                                       Write(user.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                </div>
                                <div class=""card-body"">
                                    <div class=""mt-2"">
                                        <div>
                                            <h3>Что вы изучите</h3>
                                        </div>
                                        <div>
                                            <ul>
");
#nullable restore
#line 123 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                 foreach (CourseLearn learn in courseLearns)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li>");
#nullable restore
#line 125 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                   Write(learn.Learn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 126 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class=""mt-2"">
                                        <div>
                                            <h3>Требования</h3>
                                        </div>
                                        <div>

                                            <ul>
");
#nullable restore
#line 138 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                 foreach (Requirement requirement in requirments)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li>");
#nullable restore
#line 140 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                   Write(requirement.RequireName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 141 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class=""mt-2"">
                                        <div>
                                            <h3>Темы</h3>
                                        </div>
                                        <div>
                                            <ul>
");
#nullable restore
#line 152 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                 foreach (CourseTheme theme in courseThemes)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <li>\r\n                                                        ");
#nullable restore
#line 155 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                   Write(theme.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" -\r\n                                                        <a class=\"text-danger\"");
            BeginWriteAttribute("href", " href=\"", 5514, "\"", 5574, 2);
            WriteAttributeValue("", 5521, "/Admin/CourseThemeDetail?themeId=", 5521, 33, true);
#nullable restore
#line 156 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
WriteAttributeValue("", 5554, theme.CourseThemeId, 5554, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Детали</a>\r\n                                                    </li>\r\n");
#nullable restore
#line 158 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </ul>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class=""mt-2"">
                                        <div>
                                            <h3>Добавить комментарий</h3>
                                        </div>
                                        <div>
                                            <div class=""card-body"">
");
#nullable restore
#line 169 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                 using (Html.BeginForm("CourseCommentCreate", "Admin", FormMethod.Post))
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <input type=\"hidden\" name=\"CourseId\"");
            BeginWriteAttribute("value", " value=\"", 6488, "\"", 6511, 1);
#nullable restore
#line 171 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
WriteAttributeValue("", 6496, Model.CourseId, 6496, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                                    <input type=\"hidden\" name=\"UserId\"");
            BeginWriteAttribute("value", " value=\"", 6603, "\"", 6619, 1);
#nullable restore
#line 172 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
WriteAttributeValue("", 6611, user.Id, 6611, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                                    <div class=""form-group"">
                                                        <textarea class=""form-control"" name=""Message"" rows=""3""></textarea>
                                                    </div>
                                                    <input type=""submit"" class=""btn btn-primary mt-3"" value=""Отправить"" />
");
#nullable restore
#line 177 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                    <hr />
                                    <div class=""mt-2"">
                                        <div>
                                            <h3>Комментарии</h3>
                                        </div>
                                        <div>
");
#nullable restore
#line 187 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                             foreach (CourseComment comment in adminComments)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <div class=\"card shadow m-5\">\r\n                                                    <div class=\"card-body\">\r\n                                                        ");
#nullable restore
#line 191 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                                   Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </div>\r\n                                                    <div class=\"card-footer\">\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 8083, "\"", 8145, 2);
            WriteAttributeValue("", 8090, "/Admin/CourseCommentDelete?commentId=", 8090, 37, true);
#nullable restore
#line 194 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
WriteAttributeValue("", 8127, comment.CommentId, 8127, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Удалить</a>\r\n                                                    </div>\r\n                                                </div>\r\n");
#nullable restore
#line 197 "E:\Projects\itlearn\itlearn.web\Views\Admin\CourseDetail.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </div>
                                    </div>

                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>
        </div>
    </section>
</div>



");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationContext _context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Course> Html { get; private set; }
    }
}
#pragma warning restore 1591
