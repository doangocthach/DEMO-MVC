#pragma checksum "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "756648ed1e10be03f74e47fe6b536447c9223baa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#line 2 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"756648ed1e10be03f74e47fe6b536447c9223baa", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Compose"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(0, 252, true);
            WriteLiteral("<header>\r\n  <div class=\"\">\r\n    <div class=\"container-fluid\">\r\n      <nav class=\"navbar navbar-expand-lg  navbar-light\" id=\"navbg\">\r\n        <div class=\"container-fluid text-center\">\r\n          <div class=\"\">\r\n            <h1 class=\"display-4\">Welcome ");
            EndContext();
            BeginContext(253, 21, false);
#line 7 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
                                     Write(ViewBag.user.Username);

#line default
#line hidden
            EndContext();
            BeginContext(274, 1255, true);
            WriteLiteral(@"</h1>
          </div>
          <a href=""/Home/Logout"">
            <button class=""btn-primary ml-auto"" id=""butt"">
              logout
            </button>
          </a>
        </div>
      </nav>
    </div>
</header>
</div>




<div class="""">
  <div class=""container"">
    <div class=""row"">
      <div class=""col-3"">
        <ul class=""nav nav-pills flex-column"">
          <li class=""nav-item"">
            <a class=""nav-link active"" data-toggle=""tab"" href=""#home"">Compose</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#menu1"">Sent</a>
          </li>
          <li class=""nav-item"">
            <a class=""nav-link"" data-toggle=""tab"" href=""#menu2"">Receive</a>
          </li>
        </ul>
      </div>


      <div class=""col-9"">
        <div class=""tab-content"">
          <div class=""content-inbox"">

            <div>
              <h3 id=""title-detail""></h3>
            </div>
            <div>
            ");
            WriteLiteral("  <p id=\"receiver-detail\"></p>\r\n            </div>\r\n            <div>\r\n              <p id=\"content-detail\"></p>\r\n            </div>\r\n\r\n          </div>\r\n          <div id=\"home\" class=\"container tab-pane active\"><br>\r\n            ");
            EndContext();
            BeginContext(1529, 1215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "756648ed1e10be03f74e47fe6b536447c9223baa5638", async() => {
                BeginContext(1558, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 59 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
               if (@ViewBag.Send == false)
              {

#line default
#line hidden
                BeginContext(1623, 42, true);
                WriteLiteral("              <p>Send message failed</p>\r\n");
                EndContext();
#line 62 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
              }

#line default
#line hidden
                BeginContext(1682, 1055, true);
                WriteLiteral(@"              <div class=""form-group wrap-compose d-flex flex-wrap align-items-center"">
                <textarea placeholder=""Tên người nhận"" id=""userName"" class=""form-control js-formatInputName""
                  name=""Receiver""></textarea>
                <!-- <input type=""text"" class=""form-control js-formatInputName"" id=""userName"" placeholder=""Enter Receiver"" name=""Receiver""> -->
              </div>
              <div class=""form-group"">
                <label>Title</label>
                <input type=""text"" class=""form-control"" id=""formGroupExampleInput"" placeholder=""Enter Something""
                  name=""Title"">
              </div>
              <div>
                <label>Content</label>
                <br>
                <textarea class=""form-control"" cols=""50"" id=""subject"" name=""Content"" placeholder=""Write something..""
                  style=""height:200px;"" name=""Content""></textarea>
              </div>
              <br>
              <button id=""sendEmail"" class=""btn-prima");
                WriteLiteral("ry\">Send</button>\r\n            ");
                EndContext();
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
            EndContext();
            BeginContext(2744, 84, true);
            WriteLiteral("\r\n          </div>\r\n          <div id=\"menu1\" class=\"container tab-pane fade\"><br>\r\n");
            EndContext();
            BeginContext(2844, 333, true);
            WriteLiteral(@"            <div class=""card-body bg-light"">
              <div class=""row"">
                <b class=""col-2"">Receiver</b>
                <b class=""col-6"">Title</b>
                <b class=""col-3"">Time</b>
                <b class=""col-1""></b>
              </div>
            </div>
            <ul class=""list-group"">

");
            EndContext();
#line 95 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
               foreach (var item in ViewBag.listmailsend)
              {
              

#line default
#line hidden
#line 97 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
               if(@item.checkInbox == 1)
              {

              }
              else
              {

#line default
#line hidden
            BeginContext(3368, 90, true);
            WriteLiteral("              <li class=\"list-group-item\">\r\n                <!-- <a onclick=\"renderPopUp(\'");
            EndContext();
            BeginContext(3459, 22, false);
#line 104 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
                                         Write(item.Receiver.Username);

#line default
#line hidden
            EndContext();
            BeginContext(3481, 3, true);
            WriteLiteral("\',\'");
            EndContext();
            BeginContext(3485, 26, false);
#line 104 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
                                                                   Write(item.conversations.content);

#line default
#line hidden
            EndContext();
            BeginContext(3511, 88, true);
            WriteLiteral("\')\" attachmentid=\'GS0089\'\r\n                  class=\'video\'> -->\r\n                     <a");
            EndContext();
            BeginWriteAttribute("onclick", "  onclick=\"", 3599, "\"", 3703, 9);
            WriteAttributeValue("", 3610, "detail(\'", 3610, 8, true);
#line 106 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
WriteAttributeValue("", 3618, item.Receiver.Username, 3618, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 3641, "\',", 3641, 2, true);
            WriteAttributeValue(" ", 3643, "\'", 3644, 2, true);
#line 106 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
WriteAttributeValue("", 3645, item.conversations.title, 3645, 25, false);

#line default
#line hidden
            WriteAttributeValue("", 3670, "\',", 3670, 2, true);
            WriteAttributeValue(" ", 3672, "\'", 3673, 2, true);
#line 106 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
WriteAttributeValue("", 3674, item.conversations.content, 3674, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 3701, "\')", 3701, 2, true);
            EndWriteAttribute();
            BeginContext(3704, 230, true);
            WriteLiteral(" attachmentid=\'GS0089\'\r\n                  class=\'video\'>\r\n                  <div class=\"container\">\r\n                    <div class=\"row\">\r\n\r\n                      <div class=\"col-2\">\r\n                        <b class=\"text-dark\">");
            EndContext();
            BeginContext(3935, 22, false);
#line 112 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
                                        Write(item.Receiver.Username);

#line default
#line hidden
            EndContext();
            BeginContext(3957, 121, true);
            WriteLiteral("</b>\r\n                      </div>\r\n                      <div class=\"col-6  text-truncate\">\r\n                        <b>");
            EndContext();
            BeginContext(4079, 24, false);
#line 115 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
                      Write(item.conversations.title);

#line default
#line hidden
            EndContext();
            BeginContext(4103, 137, true);
            WriteLiteral("</b>\r\n                      </div>\r\n                      <div class=\"col-3\">\r\n                        <span>\r\n                          ");
            EndContext();
            BeginContext(4241, 27, false);
#line 119 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
                     Write(item.conversations.mailDate);

#line default
#line hidden
            EndContext();
            BeginContext(4268, 141, true);
            WriteLiteral("\r\n                        </span>\r\n                      </div>\r\n                      <div class=\"col-1\">\r\n\r\n                        <button");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                          onclick=\"", 4409, "\"", 4524, 3);
            WriteAttributeValue("", 4446, "window.location.href=\'/Home/DeleteInbox?conversationId=", 4446, 55, true);
#line 125 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
WriteAttributeValue("", 4501, item.conversations.id, 4501, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 4523, "\'", 4523, 1, true);
            EndWriteAttribute();
            BeginContext(4525, 227, true);
            WriteLiteral(">\r\n                          <i class=\"fas fa-trash-alt\"></i>\r\n                        </button>\r\n\r\n                      </div>\r\n                    </div>\r\n                  </div>\r\n                </a>\r\n              </li>\r\n");
            EndContext();
#line 134 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
              }

#line default
#line hidden
#line 134 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
               
              }

#line default
#line hidden
            BeginContext(4786, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
            BeginContext(4820, 119, true);
            WriteLiteral("          </div>\r\n          <span id=\"popup\"> </span>\r\n          <div id=\"menu2\" class=\"container tab-pane fade\"><br>\r\n");
            EndContext();
            BeginContext(4955, 329, true);
            WriteLiteral(@"            <div class=""card-body bg-light"">
              <div class=""row"">
                <b class=""col-2"">Sender</b>
                <b class=""col-6"">Title</b>
                <b class=""col-3"">Time</b>
                <b class=""col-1""></b>
              </div>
            </div>
            <ul class=""list-group"">
");
            EndContext();
#line 151 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
               foreach (var item in ViewBag.ListReceiver)
              {
              

#line default
#line hidden
#line 153 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
               if(@item.checkReceiver == 1)
              {

              }
              else
              {

#line default
#line hidden
            BeginContext(5478, 62, true);
            WriteLiteral("              <li class=\"list-group-item\">\r\n                <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 5540, "\"", 5616, 5);
            WriteAttributeValue("", 5550, "renderPopUp(\'", 5550, 13, true);
#line 160 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
WriteAttributeValue("", 5563, item.Sender.Username, 5563, 21, false);

#line default
#line hidden
            WriteAttributeValue("", 5584, "\',\'", 5584, 3, true);
#line 160 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
WriteAttributeValue("", 5587, item.conversations.content, 5587, 27, false);

#line default
#line hidden
            WriteAttributeValue("", 5614, "\')", 5614, 2, true);
            EndWriteAttribute();
            BeginContext(5617, 228, true);
            WriteLiteral(" attachmentid=\'GS0089\'\r\n                  class=\'video\'>\r\n                  <div class=\"container\">\r\n                    <div class=\"row\">\r\n                      <div class=\"col-2\">\r\n                        <b class=\"text-dark\">");
            EndContext();
            BeginContext(5846, 20, false);
#line 165 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
                                        Write(item.Sender.Username);

#line default
#line hidden
            EndContext();
            BeginContext(5866, 121, true);
            WriteLiteral("</b>\r\n                      </div>\r\n                      <div class=\"col-6  text-truncate\">\r\n                        <b>");
            EndContext();
            BeginContext(5988, 24, false);
#line 168 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
                      Write(item.conversations.title);

#line default
#line hidden
            EndContext();
            BeginContext(6012, 137, true);
            WriteLiteral("</b>\r\n                      </div>\r\n                      <div class=\"col-3\">\r\n                        <span>\r\n                          ");
            EndContext();
            BeginContext(6150, 27, false);
#line 172 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
                     Write(item.conversations.mailDate);

#line default
#line hidden
            EndContext();
            BeginContext(6177, 139, true);
            WriteLiteral("\r\n                        </span>\r\n                      </div>\r\n                      <div class=\"col-1\">\r\n                        <button");
            EndContext();
            BeginWriteAttribute("onclick", "\r\n                          onclick=\"", 6316, "\"", 6433, 3);
            WriteAttributeValue("", 6353, "window.location.href=\'/Home/DeleteReceive?conversationId=", 6353, 57, true);
#line 177 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
WriteAttributeValue("", 6410, item.conversations.id, 6410, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 6432, "\'", 6432, 1, true);
            EndWriteAttribute();
            BeginContext(6434, 225, true);
            WriteLiteral(">\r\n                          <i class=\"fas fa-trash-alt\"></i>\r\n                        </button>\r\n                      </div>\r\n                    </div>\r\n                  </div>\r\n                </a>\r\n              </li>\r\n");
            EndContext();
#line 185 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
              }

#line default
#line hidden
#line 185 "C:\Users\goldk\OneDrive\Desktop\MVC-Copy\MVC-copy\Views\Home\Index.cshtml"
               
              }

#line default
#line hidden
            BeginContext(6693, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
            BeginContext(6727, 76, true);
            WriteLiteral("          </div>\r\n        </div>\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
