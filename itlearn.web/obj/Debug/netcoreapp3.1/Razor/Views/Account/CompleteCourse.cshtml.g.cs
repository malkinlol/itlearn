#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "938f517edb8b96198519e6d8d01ab7fe3ec09172"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CompleteCourse), @"mvc.1.0.view", @"/Views/Account/CompleteCourse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"938f517edb8b96198519e6d8d01ab7fe3ec09172", @"/Views/Account/CompleteCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_CompleteCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/default/default-person.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 130px; height: 130px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
  
    ViewData["Title"] = "Course";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
  
    var user = await _userManager.FindByEmailAsync(User.Identity.Name);
    var level = 1;

    if (user.Experience < 100)
        level = 1;
    else if (user.Experience >= 100 && user.Experience < 200)
        level = 2;
    else if (user.Experience >= 200 && user.Experience < 300)
        level = 3;
    else if (user.Experience >= 300 && user.Experience < 400)
        level = 4;
    else if (user.Experience >= 400 && user.Experience < 500)
        level = 5;

    var subscribeCourses = await _contex.SubscribeCourses
.Where(x => x.UserId == user.Id)
.ToListAsync();

    var courses = new List<Course>();

    for (int i = 0; i < subscribeCourses.Count; i++)
    {
        var course = await _contex.Courses
            .Include(x => x.User)
            .Include(x => x.CourseThemes)
            .FirstOrDefaultAsync(x => x.CourseId == subscribeCourses[i].CourseId);

        courses.Add(course);
    }

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
</style>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-3"" style=""height: 100vh; background-color: #000000; padding-left: 0px; padding-right: 0px;"">
            <div class=""list-group "" style=""background: none;"">
                <div class=""img-container list-group-item"" style=""background-image: linear-gradient(to bottom, rgba(255, 255, 255, 0), rgba(0, 0, 0, 1)), url(/images/default/editprofile.jpg);
        background-repeat: no-repeat;
        background-size: cover;
        height: 300px;
        width: 100%;
        position: relative;
        margin-top: -1px;
        border: none;
    "">
");
#nullable restore
#line 108 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
                     if (!string.IsNullOrEmpty(user.Avatar))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 3072, "\"", 3103, 1);
#nullable restore
#line 110 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
WriteAttributeValue("", 3078, Url.Content(user.Avatar), 3078, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 130px; height: 130px;\" />\r\n");
#nullable restore
#line 111 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "938f517edb8b96198519e6d8d01ab7fe3ec0917212217", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 115 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <span class=\"dot text-center\">\r\n                            <span style=\"color: rgb(255, 255, 255)\">");
#nullable restore
#line 118 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
                                                               Write(level);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </span>
                    </div>
                </div>
                <a href=""/Account/Course"" class="" course-link list-group-item text-white list-group-item-action text-uppercase "" style=""background: none; "">Курсы на изучении</a>
                <a href=""/Account/MyCourse"" class=""course-link  list-group-item text-white list-group-item-action text-uppercase"" style=""background: none; "">Мои курсы</a>
                <a href=""/Account/CompleteCourse"" class=""course-link  list-group-item text-white list-group-item-action text-uppercase active"" style=""background: none; border: 1px solid #ffffff"">Законченные курсы</a>
            </div>
        </div>
        <div class=""col-md-9"">
            <div class=""container-fluid"">
                <div class=""row mt-3"">
                    <div class=""col-md-6"">
                        <p class=""display-1"" style=""font-size: 35px"">Завершенные курсы</p>
                    </div>
                    <div class=""col-md-6"">

");
            WriteLiteral("                    </div>\r\n                </div>\r\n                <div class=\"row mt-3\">\r\n                    <div class=\"col-md-12\">\r\n");
#nullable restore
#line 139 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
                         if (courses.Count != 0)
                        {
                            foreach (Course course in courses)
                            {
                                var finishThemeCount = _contex.ResultCourses.Count(x => x.IsFinish && x.UserId == user.Id && x.CourseId == course.CourseId);
                                var themesCount = course?.CourseThemes.Count;

                                int? persent = 0;

                                if (themesCount != null)
                                    persent = finishThemeCount * 100 / themesCount;

                                if (persent != 100)
                                    continue;


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card shadow m-5\">\r\n                                    <div class=\"row no-gutters\">\r\n                                        <div class=\"col-md-3\">\r\n                                            <img");
            BeginWriteAttribute("src", " src=\"", 5623, "\"", 5656, 1);
#nullable restore
#line 157 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
WriteAttributeValue("", 5629, Url.Content(course.Avatar), 5629, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""m-4"" style=""height: 200px; width: 250px;"" alt=""..."">
                                        </div>
                                        <div class=""col-md-9"">
                                            <div class=""card-body ml-5"">
                                                <div class=""row"">
                                                    <div class=""col-md-9"">
                                                        <span class=""small"">
                                                            <svg class=""svg-icon"" viewBox=""0 0 20 20"" width=""1.5em"" height=""1.5em"">
                                                                <path d=""M10,10.9c2.373,0,4.303-1.932,4.303-4.306c0-2.372-1.93-4.302-4.303-4.302S5.696,4.223,5.696,6.594C5.696,8.969,7.627,10.9,10,10.9z M10,3.331c1.801,0,3.266,1.463,3.266,3.263c0,1.802-1.465,3.267-3.266,3.267c-1.8,0-3.265-1.465-3.265-3.267C6.735,4.794,8.2,3.331,10,3.331z""></path>
                                                                <path d=""M");
            WriteLiteral(@"10,12.503c-4.418,0-7.878,2.058-7.878,4.685c0,0.288,0.231,0.52,0.52,0.52c0.287,0,0.519-0.231,0.519-0.52c0-1.976,3.132-3.646,6.84-3.646c3.707,0,6.838,1.671,6.838,3.646c0,0.288,0.234,0.52,0.521,0.52s0.52-0.231,0.52-0.52C17.879,14.561,14.418,12.503,10,12.503z""></path>
                                                            </svg>
                                                            <a");
            BeginWriteAttribute("href", " href=\"", 7077, "\"", 7133, 2);
            WriteAttributeValue("", 7084, "/Account/ShowUserProfile?email=", 7084, 31, true);
#nullable restore
#line 168 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
WriteAttributeValue("", 7115, course.User.Email, 7115, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-secondary small\">");
#nullable restore
#line 168 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
                                                                                                                                                Write(course.User.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                                        </span>\r\n                                                        <br />\r\n                                                        <p class=\"mt-4\"><b>");
#nullable restore
#line 171 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
                                                                      Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></p>
                                                        <br />
                                                    </div>
                                                    <div class=""col-md-3"">
                                                        <span class=""lable"">+");
#nullable restore
#line 175 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
                                                                        Write(course.Experience);

#line default
#line hidden
#nullable disable
            WriteLiteral(" опыта</span>\r\n                                                        <a");
            BeginWriteAttribute("href", " href=\"", 7783, "\"", 7833, 2);
            WriteAttributeValue("", 7790, "/Home/CourseTheme?courseId=", 7790, 27, true);
#nullable restore
#line 176 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
WriteAttributeValue("", 7817, course.CourseId, 7817, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-success"" style=""margin-top: 130px;"">Читать</a>
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
");
#nullable restore
#line 183 "E:\Projects\itlearn\itlearn.web\Views\Account\CompleteCourse.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationContext _contex { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> _userManager { get; private set; }
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
