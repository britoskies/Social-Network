#pragma checksum "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4116ff57c2a2ffe81e7e7a3aba82924bf129d16a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\_ViewImports.cshtml"
using SocialNetwork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\_ViewImports.cshtml"
using SocialNetwork.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml"
using SocialNetwork.Core.Application.ViewModels.Publications;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4116ff57c2a2ffe81e7e7a3aba82924bf129d16a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f753f9608fdc9f7cfcaef4fd6b8f21361e1f0383", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PublicationViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-flex flex-column gap-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <section class=""col-8 mx-auto bg-primary rounded-3 text-white text-center p-3 my-5"">
		<h3 class=""display-8 fw-normal text-uppercase fw-bolder m-0"">
            Publicaciones
        </h3>
	</section>
    <div class=""col-md-6 mx-auto rounded-3 shadow p-4"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4116ff57c2a2ffe81e7e7a3aba82924bf129d16a6609", async() => {
                WriteLiteral(@"
            <div class=""form-group d-flex flex-column gap-2"">
                <label for=""File"" class=""form-label"">Selecciona una foto de perfil</label>
                <input type=""file"" name=""File"" class=""form-control mb-2""/>
            </div>
            <div class=""form-group d-flex flex-column gap-2"">
                <label for=""exampleTextarea"" class=""form-label"">Contenido</label>
                <textarea name=""Caption"" class=""form-control"" id=""exampleTextarea"" rows=""3""></textarea>
            </div>
            <button type=""submit"" class=""btn btn-primary"">Publicar</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 29 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml"
         if (Model.Count != 0)
        {  
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml"
             foreach (PublicationViewModel item in Model)
            {        

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-sm-3 mx-auto mb-5"">
                        <section class=""card bg-white shadow"">
                            <div class=""d-flex justify-content-lg-start"">
                                <section class=""d-flex gap-2 w-100"">
                                    <img");
            BeginWriteAttribute("src", " src=\"", 1651, "\"", 1682, 1);
#nullable restore
#line 37 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 1657, item.User.ProfilePicture, 1657, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-cover rounded-circle w-100\" alt=\"img\">\r\n                                    <h6>");
#nullable restore
#line 38 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml"
                                   Write(item.User.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                </section>
                                <section class=""d-flex gap-2 mt-2"">
                                    <div class=""btn-group"" role=""group"" aria-label=""Button group with nested dropdown"">
                                      <button type=""button"" class=""btn btn-danger"">Options</button>
                                      <div class=""btn-group"" role=""group"">
                                        <button id=""btnGroupDrop4"" type=""button"" class=""btn btn-danger dropdown-toggle"" data-bs-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false""></button>
                                        <div class=""dropdown-menu"" aria-labelledby=""btnGroupDrop4"">
                                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4116ff57c2a2ffe81e7e7a3aba82924bf129d16a11664", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                          ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4116ff57c2a2ffe81e7e7a3aba82924bf129d16a13151", async() => {
                WriteLiteral("Borrar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                        </div>
                                      </div>
                                    </div>
                                </section>
                            </div>
                            <div class=""card-body"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 3056, "\"", 3073, 1);
#nullable restore
#line 54 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml"
WriteAttributeValue("", 3062, item.Image, 3062, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-cover w-100\" alt=\"img\">\r\n                            </div>\r\n                            <div class=\"card-footer\">\r\n                                <div class=\"stats mt-2 text-center\">\r\n                                    ");
#nullable restore
#line 58 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml"
                               Write(item.Caption);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""d-flex justify-content-between total font-weight-bold p-3 mt-2"">
                                <div class=""accordion-item"">
                                    <h2 class=""accordion-header"" id=""headingThree"">
                                      <button class=""accordion-button collapsed"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
                                        Comentarios
                                      </button>
                                    </h2>
                                    <div id=""collapseThree"" class=""accordion-collapse collapse"" aria-labelledby=""headingThree"" data-bs-parent=""#accordionExample"">
                                      <div class=""accordion-body"">
                                        Hello, this is a comment
                                      </div");
            WriteLiteral(">\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </section>\r\n                    </div>\r\n");
#nullable restore
#line 77 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml"
             
        }

        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <section class=\"col-4 bg-danger rounded-3 text-white mx-auto text-center p-4 mt-5\">\r\n\t\t        <h3 class=\"display-8 fw-normal text-uppercase fw-bolder m-0\"> No hay publicaciones en el sistema </h3>\r\n\t        </section>\r\n");
#nullable restore
#line 85 "C:\Users\brito\Desktop\itla-2022-c2\programacion3\SocialNetwork\SocialNetwork\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PublicationViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
