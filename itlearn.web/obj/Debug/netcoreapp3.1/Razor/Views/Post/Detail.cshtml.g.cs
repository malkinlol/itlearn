#pragma checksum "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5230c854ef5b4fc72ce5dc3e7be09e69b419442"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_Detail), @"mvc.1.0.view", @"/Views/Post/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5230c854ef5b4fc72ce5dc3e7be09e69b419442", @"/Views/Post/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid rounded"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/backgrounds/post.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
  
    var user = await _userManager.FindByIdAsync(Model.UserId);
    var name = user.FirstName + " " + user.LastName;

    List<CommentVM> comments = await _commentService.GetByPost(Model.PostId);

    var countComment = comments.Count();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-8\">\r\n            <h1 class=\"mt-4\">");
#nullable restore
#line 21 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                        Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n            <p class=\"lead\">\r\n                <b>Автор:</b>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 615, "\"", 664, 2);
            WriteAttributeValue("", 622, "/Account/ShowUserProfile?email=", 622, 31, true);
#nullable restore
#line 25 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
WriteAttributeValue("", 653, user.Email, 653, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 25 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                                                Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </p>\r\n            <hr>\r\n            <p><b>Время публикации:</b> ");
#nullable restore
#line 28 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                   Write(Model.PostDate.ToString("dddd, dd MMMM yyyy").ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <hr>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f5230c854ef5b4fc72ce5dc3e7be09e69b41944210851", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n            <hr>\r\n            <div id=\"content\">\r\n\r\n            </div>\r\n            <hr>\r\n\r\n            <!-- Comments Form -->\r\n");
#nullable restore
#line 39 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
             if (User.Identity.IsAuthenticated)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                 if (!User.Identity.Name.Equals("admin@gmail.com"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card my-4\">\r\n                        <h5 class=\"card-header\">Оставить комментарий:</h5>\r\n                        <div class=\"card-body\">\r\n");
#nullable restore
#line 46 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                             using (Html.BeginForm("Create", "Comment", FormMethod.Post))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <input type=\"hidden\" name=\"PostId\"");
            BeginWriteAttribute("value", " value=\"", 1567, "\"", 1588, 1);
#nullable restore
#line 48 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
WriteAttributeValue("", 1575, Model.PostId, 1575, 13, false);

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
#line 53 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 56 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                 
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h3 class=\"text-warning\">\r\n                    Для того, чтобы оставить комментарий необходимо авторизироваться!\r\n                </h3>\r\n");
#nullable restore
#line 63 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <hr />\r\n\r\n");
#nullable restore
#line 66 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
             foreach (CommentVM comment in comments)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!-- Single Comment -->\r\n                <div class=\"media mb-4\">\r\n                    <img class=\"d-flex mr-3 rounded-circle\" style=\"width:50px; height: 50px;\"");
            BeginWriteAttribute("src", " src=\"", 2493, "\"", 2527, 1);
#nullable restore
#line 70 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
WriteAttributeValue("", 2499, Url.Content(comment.Avatar), 2499, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 2528, "\"", 2534, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <div class=\"media-body\">\r\n                        <h5 class=\"mt-0\">");
#nullable restore
#line 72 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                    Write(comment.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        ");
#nullable restore
#line 73 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                   Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <blockquote class=\"blockquote mb-0 mt-2\">\r\n                            <p>");
#nullable restore
#line 75 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                          Write(comment.CommentDate.ToString("dddd, dd MMMM yyyy").ToUpper());

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </blockquote>\r\n                    </div>\r\n\r\n                </div>\r\n");
#nullable restore
#line 80 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <!-- Comment with nested comments -->\r\n");
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"col-md-4\">\r\n            <div class=\"card my-4\">\r\n                <h5 class=\"card-header\">Поиск</h5>\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 114 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                     using (Html.BeginForm("Search", "Home", FormMethod.Get))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""form-row"">
                            <div class=""col-12 col-md-10"">
                                <input type=""text"" class=""form-control form-control-lg"" name=""SearchText"" placeholder=""Искать..."">
                            </div>
                            <div class=""col-12 col-md-2"">
                                <button type=""submit"" class=""btn btn-block btn-lg btn-primary""><span class=""iconify"" data-icon=""simple-line-icons:magnifier"" data-inline=""false""></span></button>
                            </div>
                        </div>
");
#nullable restore
#line 124 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            <div class=\"card my-4\">\r\n                <h5 class=\"card-header\">Категории</h5>\r\n                <div class=\"card-body\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 131 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                         if (Model.Tags.Count() > 3)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-6\">\r\n                                <ul class=\"list-unstyled mb-0\">\r\n");
#nullable restore
#line 135 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                     foreach (string tag in Model.Tags.Take(3))
                                    {
                                        if (!string.IsNullOrEmpty(tag))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a href=\"#\">");
#nullable restore
#line 140 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                                       Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 142 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </div>\r\n                            <div class=\"col-lg-6\">\r\n                                <ul class=\"list-unstyled mb-0\">\r\n");
#nullable restore
#line 148 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                     foreach (string tag in Model.Tags.Skip(3).Take(3))
                                    {
                                        if (!string.IsNullOrEmpty(tag))
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <a href=\"#\">");
#nullable restore
#line 153 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                                       Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                            </li>\r\n");
#nullable restore
#line 155 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                        }
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </ul>\r\n                            </div>\r\n");
#nullable restore
#line 159 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-12 text-center\">\r\n");
#nullable restore
#line 163 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                 foreach (string tag in Model.Tags)
                                {
                                    if (!string.IsNullOrEmpty(tag))
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <a href=\"#\" style=\"font-size: 20px;\" class=\"ml-1 mr-1\"><b>");
#nullable restore
#line 167 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                                                                             Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></a>\r\n");
#nullable restore
#line 168 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n");
#nullable restore
#line 171 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"card my-4\">\r\n                <h5 class=\"card-header\">Об авторе</h5>\r\n                <div class=\"card-body\">\r\n");
#nullable restore
#line 179 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                     if (string.IsNullOrEmpty(user.AboutMe))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>Данные отсутствуют...</p>\r\n");
#nullable restore
#line 182 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p>");
#nullable restore
#line 185 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                      Write(user.AboutMe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 186 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<input type=\"hidden\" id=\"description\"");
            BeginWriteAttribute("value", " value=\"", 8663, "\"", 8685, 1);
#nullable restore
#line 192 "E:\New folder\qwe\qwe\qwe\itlearn\itlearn.web\Views\Post\Detail.cshtml"
WriteAttributeValue("", 8671, Model.Message, 8671, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<script>\r\n    window.onload = function () {\r\n        document.getElementById(\'content\').innerHTML = document.getElementById(\'description\').value;\r\n    };\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> _userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICommentService _commentService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostVM> Html { get; private set; }
    }
}
#pragma warning restore 1591