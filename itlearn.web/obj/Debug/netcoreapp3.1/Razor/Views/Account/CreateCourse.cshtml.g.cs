#pragma checksum "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4180ade0b242285ce65a7c13c47d42ee6a570ae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CreateCourse), @"mvc.1.0.view", @"/Views/Account/CreateCourse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4180ade0b242285ce65a7c13c47d42ee6a570ae3", @"/Views/Account/CreateCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_CreateCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/default/default-person.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 130px; height: 130px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Низкий", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Средний", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Высокий", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
  
    ViewData["Title"] = "Course";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 10 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
  
    var user = await _userManager.FindByEmailAsync(User.Identity.Name);
    var level = 1;

    if (user.Experience < 1000)
        level = 1;
    else if (user.Experience >= 1000 && user.Experience < 2000)
        level = 2;
    else if (user.Experience >= 2000 && user.Experience < 3000)
        level = 3;
    else if (user.Experience >= 3000 && user.Experience < 4000)
        level = 4;
    else if (user.Experience >= 4000 && user.Experience < 5000)
        level = 5;

    var categories = await _context.SubcategoryCourses.ToListAsync();

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
#line 93 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                     if (!string.IsNullOrEmpty(user.Avatar))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 2688, "\"", 2719, 1);
#nullable restore
#line 95 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
WriteAttributeValue("", 2694, Url.Content(user.Avatar), 2694, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 130px; height: 130px;\" />\r\n");
#nullable restore
#line 96 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4180ade0b242285ce65a7c13c47d42ee6a570ae313279", async() => {
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
#line 100 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <span class=\"dot text-center\">\r\n                            <span style=\"color: rgb(255, 255, 255)\">");
#nullable restore
#line 103 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                                                               Write(level);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                        </span>
                    </div>
                </div>
                <a href=""/Account/Course"" class="" course-link list-group-item text-white list-group-item-action text-uppercase "" style=""background: none;"">Курсы на изучении</a>
                <a href=""/Account/MyCourse"" class=""course-link  list-group-item text-white list-group-item-action text-uppercase active"" style=""background: none; border: 1px solid #ffffff "">Мои курсы</a>
                <a href=""/Account/CompleteCourse"" class=""course-link  list-group-item text-white list-group-item-action text-uppercase "" style=""background: none; "">Законченные курсы</a>
            </div>
        </div>
        <div class=""col-md-9"">
            <div class=""container-fluid"">
                <div class=""row mt-3"">
                    <div class=""col-md-6"">
                        <p class=""display-1"" style=""font-size: 35px"">Создание курса</p>
                    </div>
                </div>
                <div cla");
            WriteLiteral("ss=\"row mt-3\">\r\n                    <div class=\"col-md-6\">\r\n");
#nullable restore
#line 121 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                         using (Html.BeginForm("CreateCourse", "Account", FormMethod.Post, new { enctype = "multipart/form-data" }))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 123 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 124 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\" id=\"description\" name=\"LongDescription\" />\r\n");
            WriteLiteral(@"                            <div class=""form-group row"" style=""margin-left: 15px; margin-right: 15px;"">
                                <label for=""title"" class=""col-sm-3 col-form-label"">Заголовок</label>
                                <div class=""col-sm-9"">
                                    <input type=""text"" class=""form-control"" id=""title"" name=""Title"">
                                    ");
#nullable restore
#line 132 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"" style=""margin-left: 15px; margin-right: 15px;"">
                                <label for=""theme"" class=""col-sm-3 col-form-label"">Тема курса</label>
                                <div class=""col-sm-9"">
                                    <select class=""form-control"" id=""theme"" name=""SubcategoryCourseId"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4180ade0b242285ce65a7c13c47d42ee6a570ae318427", async() => {
                WriteLiteral("Выберите тему курса");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 140 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                                         foreach (SubcategoryCourse subcategory in categories)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4180ade0b242285ce65a7c13c47d42ee6a570ae320397", async() => {
#nullable restore
#line 142 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                                                                                        Write(subcategory.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 142 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                                               WriteLiteral(subcategory.SubcategoryCourseId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 143 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </select>\r\n                                    ");
#nullable restore
#line 145 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                               Write(Html.ValidationMessageFor(model => model.SubcategoryCourseId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"" style=""margin-left: 15px; margin-right: 15px;"">
                                <label for=""avatar"" class=""col-sm-3 col-form-label"">Аватар</label>
                                <div class=""col-sm-9"">
                                    <input type=""file"" class=""form-control"" id=""avatar"" name=""uploadedFile"">
                                    ");
#nullable restore
#line 152 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Avatar, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"" style=""margin-left: 15px; margin-right: 15px;"">
                                <label for=""level"" class=""col-sm-3 col-form-label"">Уровень сложности</label>
                                <div class=""col-sm-9"">
                                    <select class=""form-control"" id=""level"" name=""Level"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4180ade0b242285ce65a7c13c47d42ee6a570ae324261", async() => {
                WriteLiteral("Низкий");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4180ade0b242285ce65a7c13c47d42ee6a570ae325461", async() => {
                WriteLiteral("Средний");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4180ade0b242285ce65a7c13c47d42ee6a570ae326662", async() => {
                WriteLiteral("Высокий");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </select>\r\n                                    ");
#nullable restore
#line 163 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Level, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"" style=""margin-left: 15px; margin-right: 15px;"">
                                <label for=""experience"" class=""col-sm-3 col-form-label"">Опыт</label>
                                <div class=""col-sm-9"">
                                    <input type=""number"" class=""form-control"" min=""1"" max=""100"" id=""experience"" name=""Experience"">
                                    ");
#nullable restore
#line 170 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Experience, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"" style=""margin-left: 15px; margin-right: 15px;"">
                                <label for=""shortDesciption"" class=""col-sm-3 col-form-label"">Короткое описание</label>
                                <div class=""col-sm-9"">
                                    <input type=""text"" class=""form-control"" id=""shortDesciption"" name=""ShortDesciption"">
                                    ");
#nullable restore
#line 177 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                               Write(Html.ValidationMessageFor(model => model.ShortDesciption, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"" style=""margin-left: 15px; margin-right: 15px;"">
                                <label class=""col-sm-3 col-form-label"">Длинное описание</label>
                                <div class=""col-sm-9"">
                                    ");
#nullable restore
#line 183 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                               Write(Html.ValidationMessageFor(model => model.LongDescription, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    <div id=""editor"" class=""editor"">

                                    </div>
                                </div>
                            </div>
                            <div class=""form-group row float-right"" style=""margin-left: 15px; margin-right: 15px;"">
                                <div class=""text-right"">
                                    <input type=""submit"" class=""button_c"" value=""Сохранить"" onclick=""GetDescription()"" />
                                </div>
                            </div>
");
#nullable restore
#line 194 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Account\CreateCourse.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

<script>
    let editor;

    ClassicEditor
        .create(document.querySelector('#editor'), {
            toolbar: ['heading', '|', 'undo', 'redo', 'bold', 'italic', 'bulletedList', 'numberedList']
        })
        .then(newEditor => {
            editor = newEditor;
        })
        .catch(error => {
            console.error(error);
        });

    function GetDescription() {
        const editorData = editor.getData();

        document.getElementById('description').setAttribute('value', editorData);
    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ApplicationContext _context { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
