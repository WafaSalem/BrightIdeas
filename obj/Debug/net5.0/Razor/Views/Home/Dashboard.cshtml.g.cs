#pragma checksum "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c379aa7e18687c3bee47a1c67e079cd5dae7d949"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dashboard), @"mvc.1.0.view", @"/Views/Home/Dashboard.cshtml")]
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
#line 1 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/_ViewImports.cshtml"
using BrightIdeas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c379aa7e18687c3bee47a1c67e079cd5dae7d949", @"/Views/Home/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3089d01e8107546353dc71acbeb0ef609963fe45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Idea>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PostIdea", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
  
    ViewData["Title"] = "Bright Ideas";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Hi ");
#nullable restore
#line 5 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
  Write(ViewBag.CurrentUser.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<a href=\"logout\">Logout</a>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c379aa7e18687c3bee47a1c67e079cd5dae7d9495983", async() => {
                WriteLiteral("\n        <div>\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c379aa7e18687c3bee47a1c67e079cd5dae7d9496260", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 9 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewIdea);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c379aa7e18687c3bee47a1c67e079cd5dae7d9497822", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#nullable restore
#line 10 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewIdea);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("required", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("span", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c379aa7e18687c3bee47a1c67e079cd5dae7d9499700", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationMessageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper);
#nullable restore
#line 11 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.NewIdea);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-for", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationMessageTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n        </div>\n        <button type=\"submit\" class=\"btn btn-primary\"> submit</button><br />\n        \n ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 16 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
  
    foreach (var idea in ViewBag.AllIdeas)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label for=\"Idea\" class=\"form-label\"><h3><a");
            BeginWriteAttribute("href", " href=\"", 612, "\"", 638, 2);
            WriteAttributeValue("", 619, "/users/", 619, 7, true);
#nullable restore
#line 19 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 626, idea.UserId, 626, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
                                                                          Write(idea.PostedBy.Alias);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> says:</h3></label>\n");
            WriteLiteral("        <textarea type=\"text\" name=\"Idea\"");
            BeginWriteAttribute("value", " value=\"", 742, "\"", 763, 1);
#nullable restore
#line 22 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 750, idea.NewIdea, 750, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"form-control\">");
#nullable restore
#line 22 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
                                                                                Write(idea.NewIdea);

#line default
#line hidden
#nullable disable
            WriteLiteral("</textarea>\n");
#nullable restore
#line 23 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
         if(idea.UserId == ViewBag.CurrentUser.UserId)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 898, "\"", 929, 2);
            WriteAttributeValue("", 905, "/deleteidea/", 905, 12, true);
#nullable restore
#line 25 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 917, idea.IdeaId, 917, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\n");
#nullable restore
#line 26 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\n");
#nullable restore
#line 28 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
          
            bool liked = true;
            foreach (var like in idea.Likedby)
            {
                if (like.UserId == ViewBag.CurrentUser.UserId)
                    {
                        liked = false; 
                    }
            }
            if(liked)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a");
            BeginWriteAttribute("href", " href=\"", 1309, "\"", 1334, 2);
            WriteAttributeValue("", 1316, "/like/", 1316, 6, true);
#nullable restore
#line 39 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1322, idea.IdeaId, 1322, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Like</a>\n");
#nullable restore
#line 40 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span>Liked </span>\n");
#nullable restore
#line 44 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("          <a");
            BeginWriteAttribute("href", " href=\"", 1462, "\"", 1495, 2);
            WriteAttributeValue("", 1469, "/bright_ideas/", 1469, 14, true);
#nullable restore
#line 46 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
WriteAttributeValue("", 1483, idea.IdeaId, 1483, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 46 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
                                          Write(idea.Likedby.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(" People</a> Like this.</p>\n");
#nullable restore
#line 47 "/Users/wfaalkhaldy/Documents/CodingDojo/BrightIdeas/Views/Home/Dashboard.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Idea> Html { get; private set; }
    }
}
#pragma warning restore 1591
