#pragma checksum "E:\3.Asp.Net.Core\ProniaTask\ProniaTask\Views\Home\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39d7d8440af3c7170627a92294fdf4f17a6510e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Detail), @"mvc.1.0.view", @"/Views/Home/Detail.cshtml")]
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
#line 1 "E:\3.Asp.Net.Core\ProniaTask\ProniaTask\Views\_ViewImports.cshtml"
using ProniaTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\3.Asp.Net.Core\ProniaTask\ProniaTask\Views\_ViewImports.cshtml"
using ProniaTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\3.Asp.Net.Core\ProniaTask\ProniaTask\Views\_ViewImports.cshtml"
using ProniaTask.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39d7d8440af3c7170627a92294fdf4f17a6510e4", @"/Views/Home/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"132bf44ee45a065f33734866f548dff689a40cfd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Plant>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("widgets-searchbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("feedback-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral(@"

<!-- Begin Main Content Area -->
<main class=""main-content"">
    <div class=""breadcrumb-area breadcrumb-height""
         data-bg-image=""assets/images/breadcrumb/bg/1-1-1919x388.jpg"">
        <div class=""container h-100"">
            <div class=""row h-100"">
                <div class=""col-lg-12"">
                    <div class=""breadcrumb-item"">
                        <h2 class=""breadcrumb-heading"">Blog</h2>
                        <ul>
                            <li>
                                <a href=""index.html"">Home</a>
                            </li>
                            <li>Blog Detail</li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""blog-area section-space-y-axis-100"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-3 col-lg-4 order-2 pt-5 pt-lg-0"">
                    <div class=""sidebar-area"">
                    ");
            WriteLiteral("    <div class=\"widgets-searchbox\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39d7d8440af3c7170627a92294fdf4f17a6510e45581", async() => {
                WriteLiteral(@"
                                <input class=""input-field""
                                       type=""text""
                                       placeholder=""Search"" />
                                <button class=""widgets-searchbox-btn"" type=""submit"">
                                    <i class=""fa fa-search""></i>
                                </button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>
                        <div class=""widgets-area"">
                            <div class=""widgets-item pt-0"">
                                <h2 class=""widgets-title mb-4"">Categories</h2>
                                <ul class=""widgets-category"">
                                    <li>
                                        <a href=""#"">
                                            <i class=""fa fa-chevron-right""></i>
                                            All <span>(65)</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fa fa-chevron-right""></i>
                                            Bansai <span>(12)</span>
                                        </a>
                                    </li>
                                    <li>
                       ");
            WriteLiteral(@"                 <a href=""#"">
                                            <i class=""fa fa-chevron-right""></i>
                                            House Plants <span>(22)</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fa fa-chevron-right""></i>
                                            Indoor Living <span>(19)</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fa fa-chevron-right""></i>
                                            Perennnials <span>(17)</span>
                                        </a>
                                    </li>
                                    <li>
                     ");
            WriteLiteral(@"                   <a href=""#"">
                                            <i class=""fa fa-chevron-right""></i>
                                            Plant For Gift <span>(01)</span>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fa fa-chevron-right""></i>
                                            Garden Tools <span>(12)</span>
                                        </a>
                                    </li>
                                </ul>
                            </div>
                            <div class=""widgets-item"">
                                <h2 class=""widgets-title mb-4"">Recent Post</h2>
                                <div class=""swiper-container widgets-list-slider"">
                                    <div class=""swiper-wrapper"">
                                       ");
            WriteLiteral(@" <div class=""swiper-slide"">
                                            <div class=""widgets-list-item"">
                                                <div class=""widgets-list-img"">
                                                    <a href=""#"">
                                                        <img class=""img-full""
                                                             src=""assets/images/website-images/blog/small-size/1-1-70x70.png""
                                                             alt=""Blog Images"" />
                                                    </a>
                                                </div>
                                                <div class=""widgets-list-content"">
                                                    <div class=""widgets-meta"">
                                                        <ul>
                                                            <li class=""date"">24 April 2021</li>
                                              ");
            WriteLiteral(@"          </ul>
                                                    </div>
                                                    <h2 class=""title mb-0"">
                                                        <a href=""#"">Lorem ipsum dolo conse tetur.</a>
                                                    </h2>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""swiper-slide"">
                                            <div class=""widgets-list-item"">
                                                <div class=""widgets-list-img"">
                                                    <a href=""#"">
                                                        <img class=""img-full""
                                                             src=""assets/images/website-images/blog/small-size/1-2-70x70.png""
                                                       ");
            WriteLiteral(@"      alt=""Blog Images"" />
                                                    </a>
                                                </div>
                                                <div class=""widgets-list-content"">
                                                    <div class=""widgets-meta"">
                                                        <ul>
                                                            <li class=""date"">24 April 2021</li>
                                                        </ul>
                                                    </div>
                                                    <h2 class=""title mb-0"">
                                                        <a href=""#"">Lorem ipsum dolo conse tetur.</a>
                                                    </h2>
                                                </div>
                                            </div>
                                        </div>
                                        <");
            WriteLiteral(@"div class=""swiper-slide"">
                                            <div class=""widgets-list-item"">
                                                <div class=""widgets-list-img"">
                                                    <a href=""#"">
                                                        <img class=""img-full""
                                                             src=""assets/images/website-images/blog/small-size/1-3-70x70.png""
                                                             alt=""Blog Images"" />
                                                    </a>
                                                </div>
                                                <div class=""widgets-list-content"">
                                                    <div class=""widgets-meta"">
                                                        <ul>
                                                            <li class=""date"">24 April 2021</li>
                                                ");
            WriteLiteral(@"        </ul>
                                                    </div>
                                                    <h2 class=""title mb-0"">
                                                        <a href=""#"">Lorem ipsum dolo conse tetur.</a>
                                                    </h2>
                                                </div>
                                            </div>
                                        </div>
                                        <div class=""swiper-slide without-border"">
                                            <div class=""widgets-list-item"">
                                                <div class=""widgets-list-img"">
                                                    <a href=""#"">
                                                        <img class=""img-full""
                                                             src=""assets/images/website-images/blog/small-size/1-1-70x70.png""
                                          ");
            WriteLiteral(@"                   alt=""Blog Images"" />
                                                    </a>
                                                </div>
                                                <div class=""widgets-list-content"">
                                                    <div class=""widgets-meta"">
                                                        <ul>
                                                            <li class=""date"">24 April 2021</li>
                                                        </ul>
                                                    </div>
                                                    <h2 class=""title mb-0"">
                                                        <a href=""#"">Lorem ipsum dolo conse tetur.</a>
                                                    </h2>
                                                </div>
                                            </div>
                                        </div>
                            ");
            WriteLiteral(@"        </div>
                                </div>
                            </div>
                            <div class=""widgets-item"">
                                <h2 class=""widgets-title mb-4"">Populer Tags</h2>
                                <ul class=""widgets-tag"">
                                    <li>
                                        <a href=""#"">Fashion</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Organic</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Old Fashion</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Men</a>
                                    </li>
                                    <li>
                                        <a href=""#"">Fashion</a>
                             ");
            WriteLiteral(@"       </li>
                                    <li>
                                        <a href=""#"">Dress</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                        <div class=""banner-item widgets-banner img-hover-effect"">
                            <div class=""banner-img"">
                                <img src=""assets/images/website-images/sidebar/banner/1-270x300.jpg""
                                     alt=""Banner Image"" />
                            </div>
                            <div class=""banner-content text-position-center"">
                                <span class=""collection"">New Collection</span>
                                <h3 class=""title"">Plant Port</h3>
                                <div class=""button-wrap"">
                                    <a class=""btn btn-custom-size sm-size btn-pronia-primary""
                                       h");
            WriteLiteral(@"ref=""shop.html"">Shop Now</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-9 col-lg-8 order-1"">
                    <div class=""blog-detail-item"">
                        <div class=""blog-content"">
                            <div class=""blog-meta"">
                                <ul>
                                    <li class=""author"">
                                        <a href=""#"">By: Admin</a>
                                    </li>
                                    <li class=""date"">24 April 2021</li>
                                </ul>
                            </div>
                            <h2 class=""title"">There Many Variations</h2>
                            <p class=""short-desc"">
                                Lorem ipsum dolor sit amet, consectetur adipisicing elit,
                                sed do eiusmod tem");
            WriteLiteral(@"por incididunt ut labore etl dolore
                                magna aliqua. Ut enim ad minim veniam, quis nostrud
                                exercitation ullamco laboris nisi ut aliquiex ea commodo
                                consequat. Duis aute irure dolor in reprehenderit in
                                voluptate velit esse cillum dolore eukip fugiat nulla
                                pariatur. Excepteur sint occaecat cupidatat non proident,
                                sunt in culpa qui officia deseruntk mollit anim id est
                                laborum. Sed ut perspiciatis unde omnis iste natus error
                                sit voluptatem accusantiumy doloremque laudantium, totam
                                rem aperiam,
                            </p>
                        </div>
                        <div class=""blog-img img-hover-effect"">
                            <img class=""img-full""
                                 src=""assets/images/");
            WriteLiteral(@"website-images/blog/large-size/1-1-768x546.jpg""
                                 alt=""Blog Image"" />
                        </div>
                        <p class=""short-desc"">
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit,
                            sed do eiusmod tempor incididunt ut labore etl dolore magna
                            aliqua. Ut enim ad minim veniam, quis nostrud exercitation
                            ullamco laboris nisi ut aliquiex ea commodo consequat. Duis
                            aute irure dolor in reprehenderit in voluptate velit esse
                            cillum dolore eukip fugiat nulla pariatur. Excepteur sint
                            occaecat.
                        </p>
                        <blockquote>
                            <p class=""mb-0"">
                                Lorem ipsum dolor sit amet, consectetur adipiscing elit,
                                sed do eiusmod tempor incididunt
     ");
            WriteLiteral(@"                       </p>
                        </blockquote>
                        <p class=""short-desc"">
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit,
                            sed do eiusmod tempor incididunt ut labore etl dolore magna
                            aliqua. Ut enim ad minim veniam, quis nostrud exercitation
                            ullamco laboris nisi ut aliquiex ea commodo consequat. Duis
                            aute irure dolor in reprehenderit in voluptate velit esse
                            cillum dolore eukip fugiat nulla pariatur. Excepteur sint
                            occaecat cupidatat non proident, sunt in culpa qui officia
                            deseruntk mollit anim id est laborum. Sed ut perspiciatis
                            unde omnis iste natus error sit voluptatem accusantiumy
                            doloremque laudantium, totam rem aperiam,
                        </p>
                    ");
            WriteLiteral(@"    <div class=""blog-banner row"">
                            <div class=""single-img img-hover-effect col-sm-6"">
                                <img class=""img-full""
                                     src=""assets/images/website-images/blog/medium-size/2-1-370x270.jpg""
                                     alt=""Blog Banner"" />
                            </div>
                            <div class=""single-img img-hover-effect col-sm-6 pt-5 pt-sm-0"">
                                <img class=""img-full""
                                     src=""assets/images/website-images/blog/medium-size/2-2-370x270.jpg""
                                     alt=""Blog Banner"" />
                            </div>
                        </div>
                        <p class=""short-desc mb-0"">
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit,
                            sed do eiusmod tempor incididunt ut labore etl dolore magna
                            aliqua. Ut enim");
            WriteLiteral(@" ad minim veniam, quis nostrud exercitation
                            ullamco laboris nisi ut aliquiex ea commodo consequat. Duis
                            aute irure dolor in reprehenderit in voluptate velit esse
                            cillum dolore eukip fugiat nulla pariatur. Excepteur sint
                            occaecat
                        </p>
                    </div>
                    <div class=""social-with-tags"">
                        <div class=""tags"">
                            <span class=""title"">Tags: </span>
                            <ul>
                                <li>
                                    <a href=""#"">Plant,</a>
                                </li>
                                <li>
                                    <a href=""#"">Tree Plant</a>
                                </li>
                            </ul>
                        </div>
                        <div class=""social-link"">
                            <ul");
            WriteLiteral(@">
                                <li>
                                    <a href=""#""
                                       data-tippy=""Facebook""
                                       data-tippy-inertia=""true""
                                       data-tippy-animation=""shift-away""
                                       data-tippy-delay=""50""
                                       data-tippy-arrow=""true""
                                       data-tippy-theme=""sharpborder"">
                                        <i class=""fa fa-facebook""></i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""#""
                                       data-tippy=""Dribbble""
                                       data-tippy-inertia=""true""
                                       data-tippy-animation=""shift-away""
                                       data-tippy-delay=""50""
                              ");
            WriteLiteral(@"         data-tippy-arrow=""true""
                                       data-tippy-theme=""sharpborder"">
                                        <i class=""fa fa-dribbble""></i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""#""
                                       data-tippy=""Pinterest""
                                       data-tippy-inertia=""true""
                                       data-tippy-animation=""shift-away""
                                       data-tippy-delay=""50""
                                       data-tippy-arrow=""true""
                                       data-tippy-theme=""sharpborder"">
                                        <i class=""fa fa-pinterest-p""></i>
                                    </a>
                                </li>
                                <li class=""comment"">
                                    <a href=""#"">
                 ");
            WriteLiteral(@"                       <span>2</span>
                                        <i class=""fa fa-comments""></i>
                                    </a>
                                </li>
                            </ul>
                        </div>
                    </div>
                    <div class=""blog-comment"">
                        <h4 class=""heading"">Comments (03)</h4>
                        <div class=""blog-comment-item"">
                            <div class=""blog-comment-img"">
                                <img src=""assets/images/website-images/blog/avatar/1-1-120x120.png""
                                     alt=""User Image"" />
                            </div>
                            <div class=""blog-comment-content"">
                                <div class=""user-meta"">
                                    <h2 class=""user-name"">Donald Chavez</h2>
                                    <span class=""date"">21 July 2021</span>
                                </div>");
            WriteLiteral(@"
                                <p class=""user-comment"">
                                    Lorem ipsum dolor sit amet, consectetur adipisi elit,
                                    sed do eiusmod tempor incidid ut labore etl dolore magna
                                    aliqua. Ut enim ad minim veniam, quis nostrud exercitati
                                    ullamco laboris nisi ut aliquiex ea commodo consequat.
                                </p>
                                <a class=""btn btn-custom-size comment-btn"" href=""#"">Reply</a>
                            </div>
                        </div>
                        <div class=""blog-comment-item relpy-item"">
                            <div class=""blog-comment-img"">
                                <img src=""assets/images/website-images/blog/avatar/1-2-120x120.png""
                                     alt=""User Image"" />
                            </div>
                            <div class=""blog-comment-content"">
     ");
            WriteLiteral(@"                           <div class=""user-meta"">
                                    <h2 class=""user-name"">Marissa Swan</h2>
                                    <span class=""date"">21 July 2021</span>
                                </div>
                                <p class=""user-comment"">
                                    Lorem ipsum dolor sit amet, consectetur adipisi elit,
                                    sed do eiusmod tempr incidid ut labore etl dolore magna
                                    aliqua. Ut enim ad minim veniam, quisnos exercitati
                                    ullamco laboris nisi ut aliquiex.
                                </p>
                                <a class=""btn btn-custom-size comment-btn style-2""
                                   href=""#"">Reply</a>
                            </div>
                        </div>
                        <div class=""blog-comment-item"">
                            <div class=""blog-comment-img"">
               ");
            WriteLiteral(@"                 <img src=""assets/images/website-images/blog/avatar/1-3-120x120.png""
                                     alt=""User Image"" />
                            </div>
                            <div class=""blog-comment-content"">
                                <div class=""user-meta"">
                                    <h2 class=""user-name"">Donald Chavez</h2>
                                    <span class=""date"">21 July 2021</span>
                                </div>
                                <p class=""user-comment"">
                                    Lorem ipsum dolor sit amet, consectetur adipisi elit,
                                    sed do eiusmod tempor incidid ut labore etl dolore magna
                                    aliqua. Ut enim ad minim veniam, quis nostrud exercitati
                                    ullamco laboris nisi ut aliquiex ea commodo consequat.
                                </p>
                                <a class=""btn btn-custom-size ");
            WriteLiteral(@"comment-btn"" href=""#"">Reply</a>
                            </div>
                        </div>
                    </div>
                    <div class=""feedback-area"">
                        <h2 class=""heading"">Leave a comment</h2>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "39d7d8440af3c7170627a92294fdf4f17a6510e432228", async() => {
                WriteLiteral(@"
                            <div class=""group-input"">
                                <div class=""form-field me-md-30 mb-30 mb-md-0"">
                                    <input type=""text""
                                           name=""name""
                                           placeholder=""Your Name*""
                                           class=""input-field"" />
                                </div>
                                <div class=""form-field"">
                                    <input type=""text""
                                           name=""email""
                                           placeholder=""Your Email*""
                                           class=""input-field"" />
                                </div>
                            </div>
                            <div class=""form-field mt-30"">
                                <input type=""text""
                                       name=""subject""
                                       placehol");
                WriteLiteral(@"der=""Subject (Optinal)""
                                       class=""input-field"" />
                            </div>
                            <div class=""form-field mt-30"">
                                <textarea name=""message""
                                          placeholder=""Message""
                                          class=""textarea-field""></textarea>
                            </div>
                            <div class=""button-wrap pt-5"">
                                <button type=""submit""
                                        value=""submit""
                                        class=""btn btn-custom-size xl-size btn-pronia-primary""
                                        name=""submit"">
                                    Post Comment
                                </button>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n<!-- Main Content Area End Here -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Plant> Html { get; private set; }
    }
}
#pragma warning restore 1591
