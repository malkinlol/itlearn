#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cdc52299e6f63620224a6eca763a2f15748f5e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_EditCourseTheme), @"mvc.1.0.view", @"/Views/Account/EditCourseTheme.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cdc52299e6f63620224a6eca763a2f15748f5e4", @"/Views/Account/EditCourseTheme.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_EditCourseTheme : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseThemeVM>
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
#line 2 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
  
    ViewData["Title"] = "Course";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
  
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

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-3"" style=""height: 100vh; background-color: #000000; padding-left: 0px; padding-right: 0px;"">
            <div class=""list-group "" style=""background: none;"">
                <div class=""img-container list-group-item"" style=""        background-image: linear-gradient(to bottom, rgba(255, 255, 255, 0), rgba(0, 0, 0, 1)), url(/images/default/editprofile.jpg);
        b");
            WriteLiteral("ackground-repeat: no-repeat;\r\n        background-size: cover;\r\n        height: 300px;\r\n        width: 100%;\r\n        position: relative;\r\n        margin-top: -1px;\r\n        border: none;\r\n    \">\r\n");
#nullable restore
#line 108 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
                     if (!string.IsNullOrEmpty(user.Avatar))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img");
            BeginWriteAttribute("src", " src=\"", 2998, "\"", 3029, 1);
#nullable restore
#line 110 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
WriteAttributeValue("", 3004, Url.Content(user.Avatar), 3004, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 130px; height: 130px;\" />\r\n");
#nullable restore
#line 111 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8cdc52299e6f63620224a6eca763a2f15748f5e412235", async() => {
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
#line 115 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div>\r\n                        <span class=\"dot text-center\">\r\n                            <span style=\"color: rgb(255, 255, 255)\">");
#nullable restore
#line 118 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
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
                        <p class=""display-1"" style=""font-size: 35px"">Редактирование курса</p>
                        <br />
                        <a");
            BeginWriteAttribute("href", " href=\"", 4448, "\"", 4501, 2);
            WriteAttributeValue("", 4455, "/Account/DetailCourse?courseId=", 4455, 31, true);
#nullable restore
#line 133 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
WriteAttributeValue("", 4486, Model.CourseId, 4486, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary\">Назад</a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row mt-3\">\r\n                    <div class=\"col-md-9\">\r\n");
#nullable restore
#line 138 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
                         using (Html.BeginForm("EditCourseTheme", "Account", FormMethod.Post, new { enctype = "multipart/form-data" }))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 141 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
                       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 5045, "\"", 5073, 1);
#nullable restore
#line 143 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
WriteAttributeValue("", 5053, Model.CourseThemeId, 5053, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"CourseThemeId\" />\r\n                            <input type=\"hidden\" id=\"descriptionOld\"");
            BeginWriteAttribute("value", " value=\"", 5168, "\"", 5194, 1);
#nullable restore
#line 144 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
WriteAttributeValue("", 5176, Model.Description, 5176, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <input type=\"hidden\" id=\"descriptionNew\" name=\"Description\" />\r\n");
            WriteLiteral(@"                            <div class=""form-group row"" style=""margin-left: 15px; margin-right: 15px;"">
                                <label for=""title"" class=""col-sm-3 col-form-label"">Заголовок</label>
                                <div class=""col-sm-9"">
                                    <input type=""text"" class=""form-control"" id=""title""");
            BeginWriteAttribute("value", " value=\"", 5643, "\"", 5663, 1);
#nullable restore
#line 150 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
WriteAttributeValue("", 5651, Model.Title, 5651, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Title\">\r\n                                    ");
#nullable restore
#line 151 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"" style=""margin-left: 15px; margin-right: 15px;"">
                                <label for=""timeRead"" class=""col-sm-3 col-form-label"">Время чтения</label>
                                <div class=""col-sm-9"">
                                    <input type=""number"" class=""form-control"" min=""1"" max=""100""");
            BeginWriteAttribute("value", " value=\"", 6242, "\"", 6265, 1);
#nullable restore
#line 157 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
WriteAttributeValue("", 6250, Model.TimeRead, 6250, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" id=\"timeRead\" name=\"TimeRead\">\r\n                                    ");
#nullable restore
#line 158 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
                               Write(Html.ValidationMessageFor(model => model.TimeRead, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"" style=""margin-left: 15px; margin-right: 15px;"">
                                <label for=""editor"" class=""col-sm-3 col-form-label"">Длинное описание</label>
                                <div class=""col-sm-9"">
                                    ");
#nullable restore
#line 164 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

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
#line 175 "E:\Projects\itlearn\itlearn.web\Views\Account\EditCourseTheme.cshtml"
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
            toolbar: ['mediaEmbed']

        })
        //.create(document.querySelector('#editor'))
        .then(dataEditor => {
            dataEditor.setData(document.getElementById('descriptionOld').value);
            editor = dataEditor;
        })
        .catch(error => {
            console.error(error);
        });

    function GetDescription() {
        const dataEditor = editor.getData();

        let substing = '';
        let substing1 = '';
        let substing2 = '';
        console.log(dataEditor);
        if (dataEditor.includes('iframe')) {
            substing = dataEditor.replace(new RegExp('<iframe src', 'g'), '<oembed url')
            substing1 = substing.replace(new RegExp(""embed/"", 'g'), 'watch?v=')
            substing2 = substing1.replace(new RegExp('");
            WriteLiteral(@" width=""960"" height=""540"" frameBorder=""0"" allow=""autoplay; encrypted-media"" allowFullScreen title=""video""></iframe', 'g'), '></oembed');
        } else {
            substing2 = dataEditor;
        }

        document.getElementById('descriptionNew').setAttribute('value', substing2);
    }
</script>");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseThemeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
