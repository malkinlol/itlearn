#pragma checksum "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15c2b68b6bd50d8a6725e20217ee83fc744e6b88"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SearchCourse), @"mvc.1.0.view", @"/Views/Home/SearchCourse.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15c2b68b6bd50d8a6725e20217ee83fc744e6b88", @"/Views/Home/SearchCourse.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae194dd9f86f50626075ee6a3194589cd4cfa122", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SearchCourse : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
  
    ViewData["Title"] = "SearchCourse";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
  
    var Blockchain = await _context.SubcategoryCourses.Where(x => x.CategoryCourseId == 1).ToListAsync();
    var Business = await _context.SubcategoryCourses.Where(x => x.CategoryCourseId == 2).ToListAsync();
    var Coding = await _context.SubcategoryCourses.Where(x => x.CategoryCourseId == 3).ToListAsync();
    var DateScience = await _context.SubcategoryCourses.Where(x => x.CategoryCourseId == 4).ToListAsync();
    var Design = await _context.SubcategoryCourses.Where(x => x.CategoryCourseId == 5).ToListAsync();
    var PersonalDev = await _context.SubcategoryCourses.Where(x => x.CategoryCourseId == 6).ToListAsync();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container mb-5\">\r\n    <div class=\"row mt-5 mb-3\">\r\n        <h2>Поиск курсов</h2>\r\n    </div>\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3 bg-light\" style=\"height: 200vh; \">\r\n");
#nullable restore
#line 25 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
             using (Html.BeginForm("SearchCourse", "Home", FormMethod.Get))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""mt-3"">
                    <p>
                        <svg class=""svg-icon"" viewBox=""0 0 20 20"" height=""30"" width=""30"">
                            <path d=""M6.176,7.241V6.78c0-0.221-0.181-0.402-0.402-0.402c-0.221,0-0.403,0.181-0.403,0.402v0.461C4.79,7.416,4.365,7.955,4.365,8.591c0,0.636,0.424,1.175,1.006,1.35v3.278c0,0.222,0.182,0.402,0.403,0.402c0.222,0,0.402-0.181,0.402-0.402V9.941c0.582-0.175,1.006-0.714,1.006-1.35C7.183,7.955,6.758,7.416,6.176,7.241 M5.774,9.195c-0.332,0-0.604-0.272-0.604-0.604c0-0.332,0.272-0.604,0.604-0.604c0.332,0,0.604,0.272,0.604,0.604C6.377,8.923,6.105,9.195,5.774,9.195 M10.402,10.058V6.78c0-0.221-0.181-0.402-0.402-0.402c-0.222,0-0.402,0.181-0.402,0.402v3.278c-0.582,0.175-1.006,0.714-1.006,1.35c0,0.637,0.424,1.175,1.006,1.351v0.461c0,0.222,0.181,0.402,0.402,0.402c0.221,0,0.402-0.181,0.402-0.402v-0.461c0.582-0.176,1.006-0.714,1.006-1.351C11.408,10.772,10.984,10.233,10.402,10.058M10,12.013c-0.333,0-0.604-0.272-0.604-0.604S9.667,10.805,10,10.805c0.332,0");
            WriteLiteral(@",0.604,0.271,0.604,0.604S10.332,12.013,10,12.013M14.629,8.448V6.78c0-0.221-0.182-0.402-0.403-0.402c-0.221,0-0.402,0.181-0.402,0.402v1.668c-0.581,0.175-1.006,0.714-1.006,1.35c0,0.636,0.425,1.176,1.006,1.351v2.07c0,0.222,0.182,0.402,0.402,0.402c0.222,0,0.403-0.181,0.403-0.402v-2.07c0.581-0.175,1.006-0.715,1.006-1.351C15.635,9.163,15.21,8.624,14.629,8.448 M14.226,10.402c-0.331,0-0.604-0.272-0.604-0.604c0-0.332,0.272-0.604,0.604-0.604c0.332,0,0.604,0.272,0.604,0.604C14.83,10.13,14.558,10.402,14.226,10.402 M17.647,3.962H2.353c-0.221,0-0.402,0.181-0.402,0.402v11.27c0,0.222,0.181,0.402,0.402,0.402h15.295c0.222,0,0.402-0.181,0.402-0.402V4.365C18.05,4.144,17.869,3.962,17.647,3.962 M17.245,15.232H2.755V4.768h14.49V15.232z""></path>
                        </svg> <b class=""mr-4"">Фильтр</b>
                        <input type=""submit"" class=""btn btn-warning ml-5"" value=""Поиск"" />
                    </p>

                    <hr />
                </div>
                <div class=""mt-3"">
                    <p>
");
            WriteLiteral("                        <b>Тема</b>\r\n                    </p>\r\n                    <div>\r\n                        <p><b>Блокчейн</b></p>\r\n");
#nullable restore
#line 43 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                         foreach (SubcategoryCourse course in Blockchain)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 3466, "\"", 3498, 1);
#nullable restore
#line 46 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 3471, course.SubcategoryCourseId, 3471, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"theme\"");
            BeginWriteAttribute("value", " value=\"", 3512, "\"", 3547, 1);
#nullable restore
#line 46 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 3520, course.SubcategoryCourseId, 3520, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 3591, "\"", 3624, 1);
#nullable restore
#line 47 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 3597, course.SubcategoryCourseId, 3597, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ml-2 mr-2\">");
#nullable restore
#line 47 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                      Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n");
#nullable restore
#line 49 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><b>Бизнес</b></p>\r\n");
#nullable restore
#line 51 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                         foreach (SubcategoryCourse course in Business)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 3964, "\"", 3996, 1);
#nullable restore
#line 54 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 3969, course.SubcategoryCourseId, 3969, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"theme\"");
            BeginWriteAttribute("value", " value=\"", 4010, "\"", 4045, 1);
#nullable restore
#line 54 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 4018, course.SubcategoryCourseId, 4018, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 4089, "\"", 4122, 1);
#nullable restore
#line 55 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 4095, course.SubcategoryCourseId, 4095, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ml-2 mr-2\">");
#nullable restore
#line 55 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                      Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n");
#nullable restore
#line 57 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><b>Кодирование</b></p>\r\n");
#nullable restore
#line 59 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                         foreach (SubcategoryCourse course in Coding)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 4465, "\"", 4497, 1);
#nullable restore
#line 62 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 4470, course.SubcategoryCourseId, 4470, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"theme\"");
            BeginWriteAttribute("value", " value=\"", 4511, "\"", 4546, 1);
#nullable restore
#line 62 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 4519, course.SubcategoryCourseId, 4519, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 4590, "\"", 4623, 1);
#nullable restore
#line 63 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 4596, course.SubcategoryCourseId, 4596, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ml-2 mr-2\">");
#nullable restore
#line 63 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                      Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n");
#nullable restore
#line 65 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><b>Наука о данных</b></p>\r\n");
#nullable restore
#line 67 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                         foreach (SubcategoryCourse course in DateScience)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 4974, "\"", 5006, 1);
#nullable restore
#line 70 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 4979, course.SubcategoryCourseId, 4979, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"theme\"");
            BeginWriteAttribute("value", " value=\"", 5020, "\"", 5055, 1);
#nullable restore
#line 70 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 5028, course.SubcategoryCourseId, 5028, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 5099, "\"", 5132, 1);
#nullable restore
#line 71 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 5105, course.SubcategoryCourseId, 5105, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ml-2 mr-2\">");
#nullable restore
#line 71 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                      Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n");
#nullable restore
#line 73 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><b>Дизайн</b></p>\r\n");
#nullable restore
#line 75 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                         foreach (SubcategoryCourse course in Design)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 5470, "\"", 5502, 1);
#nullable restore
#line 78 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 5475, course.SubcategoryCourseId, 5475, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"theme\"");
            BeginWriteAttribute("value", " value=\"", 5516, "\"", 5551, 1);
#nullable restore
#line 78 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 5524, course.SubcategoryCourseId, 5524, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 5595, "\"", 5628, 1);
#nullable restore
#line 79 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 5601, course.SubcategoryCourseId, 5601, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ml-2 mr-2\">");
#nullable restore
#line 79 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                      Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n");
#nullable restore
#line 81 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <p><b>Личное развитие</b></p>\r\n");
#nullable restore
#line 83 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                         foreach (SubcategoryCourse course in PersonalDev)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div>\r\n                                <input type=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 5980, "\"", 6012, 1);
#nullable restore
#line 86 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 5985, course.SubcategoryCourseId, 5985, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"theme\"");
            BeginWriteAttribute("value", " value=\"", 6026, "\"", 6061, 1);
#nullable restore
#line 86 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 6034, course.SubcategoryCourseId, 6034, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                                <label");
            BeginWriteAttribute("for", " for=\"", 6105, "\"", 6138, 1);
#nullable restore
#line 87 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 6111, course.SubcategoryCourseId, 6111, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"ml-2 mr-2\">");
#nullable restore
#line 87 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                      Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                            </div>\r\n");
#nullable restore
#line 89 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>

                </div>
                <div class=""mt-3"">
                    <p>
                        <b>Уровень мастерства</b>
                    </p>
                    <hr />
                    <div>
                        <input type=""checkbox"" id=""levelall"" name=""level"" value=""Все"" />
                        <label for=""levelall"" class=""ml-2 mr-2"">Все уровни</label>
                    </div>
                    <div>
                        <input type=""checkbox"" id=""level1"" name=""level"" value=""Низкий"" />
                        <label for=""level1"" class=""ml-2 mr-2"">Низкий</label>
                    </div>
                    <div>
                        <input type=""checkbox"" id=""level2"" name=""level"" value=""Средний"" />
                        <label for=""level2"" class=""ml-2 mr-2"">Средний</label>
                    </div>
                    <div>
                        <input type=""checkbox"" id=""level3"" name=""level"" value=""Высокий"" />
      ");
            WriteLiteral(@"                  <label for=""level3"" class=""ml-2 mr-2"">Высокий</label>
                    </div>
                </div>
                <div class=""mt-3"">
                    <p>
                        <b>Рейтинг</b>
                    </p>
                    <hr />
                    <div>
                        <input type=""radio"" id=""rating3"" name=""rating"" value=""3"" />
                        <label for=""rating3"" class=""ml-2 mr-2"">3 & выше</label>
                        <label for=""rating3"" class=""text-warning"">★</label>
                        <label for=""rating3"" class=""text-warning"">★</label>
                        <label for=""rating3"" class=""text-warning"">★</label>
                        <label for=""rating3"" class=""text-secondary"">★</label>
                        <label for=""rating3"" class=""text-secondary"">★</label>
                    </div>
                    <div>
                        <input type=""radio"" id=""rating4"" name=""rating"" value=""4"" />
                      ");
            WriteLiteral(@"  <label for=""rating4"" class=""ml-2 mr-2"">4 & выше</label>
                        <label for=""rating4"" class=""text-warning"">★</label>
                        <label for=""rating4"" class=""text-warning"">★</label>
                        <label for=""rating4"" class=""text-warning"">★</label>
                        <label for=""rating4"" class=""text-warning"">★</label>
                        <label for=""rating4"" class=""text-secondary"">★</label>
                    </div>
                    <div>
                        <input type=""radio"" id=""rating5"" name=""rating"" value=""5"" />
                        <label for=""rating5"" class=""ml-2 mr-2"">5</label>
                        <label for=""rating5"" class=""text-warning"" style=""margin-left: 63px;"">★</label>
                        <label for=""rating5"" class=""text-warning"">★</label>
                        <label for=""rating5"" class=""text-warning"">★</label>
                        <label for=""rating5"" class=""text-warning"">★</label>
                        <labe");
            WriteLiteral("l for=\"rating5\" class=\"text-warning\">★</label>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 148 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div class=\"col-md-9\">\r\n");
            WriteLiteral("            <div class=\"row row-cols-1 row-cols-md-2\" style=\"margin-top: 100px;\">\r\n");
#nullable restore
#line 163 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                 foreach (Course course in Model)
                {
                    var c = _context.CourseComments
                     .Where(x => x.CourseId == course.CourseId && !x.isAdmin)
                     .ToList();

                    var avgRating = 0;

                    if (c.Count != 0)
                    {
                        avgRating = (int)c.Average(x => x.Rating);
                    }

                    var entrolled = _context.CourseComments
                         .Where(x => x.CourseId == course.CourseId && !x.isAdmin)
                         .Count();


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col mb-4\">\r\n                        <div class=\"card\" style=\"height: 500px;\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 10824, "\"", 10876, 2);
            WriteAttributeValue("", 10831, "/Account/ShowCourse?courseId=", 10831, 29, true);
#nullable restore
#line 182 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 10860, course.CourseId, 10860, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                <img");
            BeginWriteAttribute("src", " src=\"", 10916, "\"", 10949, 1);
#nullable restore
#line 183 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
WriteAttributeValue("", 10922, Url.Content(course.Avatar), 10922, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"p-3 card-img-top\" alt=\"...\" style=\"height: 200px\">\r\n                            </a>\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
#nullable restore
#line 186 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                  Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                <p class=\"card-text\">");
#nullable restore
#line 187 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                Write(course.ShortDesciption);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n");
#nullable restore
#line 189 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                             if (avgRating == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""m-3"">
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <p class=""mt-1""><b>Рейтинг: ");
#nullable restore
#line 197 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                           Write(avgRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> | студентов проголосовало ");
#nullable restore
#line 197 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                                    Write(entrolled);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 200 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 201 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                             if (avgRating == 1)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""m-3"">
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <p class=""mt-1""><b>Рейтинг: ");
#nullable restore
#line 209 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                           Write(avgRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> | студентов проголосовало ");
#nullable restore
#line 209 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                                    Write(entrolled);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 212 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 213 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                             if (avgRating == 2)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""m-3"">
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <p class=""mt-1""><b>Рейтинг: ");
#nullable restore
#line 221 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                           Write(avgRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> | студентов проголосовало ");
#nullable restore
#line 221 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                                    Write(entrolled);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 224 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 225 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                             if (avgRating == 3)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""m-3"">
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <p class=""mt-1""><b>Рейтинг: ");
#nullable restore
#line 233 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                           Write(avgRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> | студентов проголосовало ");
#nullable restore
#line 233 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                                    Write(entrolled);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 236 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 237 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                             if (avgRating == 4)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""m-3"">
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-secondary"" style=""font-size: 25px"">★</span>
                                    <p class=""mt-1""><b>Рейтинг: ");
#nullable restore
#line 245 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                           Write(avgRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> | студентов проголосовало ");
#nullable restore
#line 245 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                                    Write(entrolled);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 248 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 249 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                             if (avgRating == 5)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""m-3"">
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <span class=""text-warning"" style=""font-size: 25px"">★</span>
                                    <p class=""mt-1""><b>Рейтинг: ");
#nullable restore
#line 257 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                           Write(avgRating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> | студентов проголосовало ");
#nullable restore
#line 257 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                                                                                                    Write(entrolled);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                                </div>\r\n");
#nullable restore
#line 260 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 263 "E:\Projects\itlearn\itlearn.web\Views\Home\SearchCourse.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
