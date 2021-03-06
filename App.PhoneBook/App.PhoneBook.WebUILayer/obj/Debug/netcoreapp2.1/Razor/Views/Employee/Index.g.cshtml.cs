#pragma checksum "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84c0f1074af350244bc349babefb3146fcb5e1a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84c0f1074af350244bc349babefb3146fcb5e1a7", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"078006421af38270683f83c842150f463e06b455", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<App.PhoneBook.WebUILayer.Models.EmployeeListViewModel>
    {
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
        private global::App.PhoneBook.WebUILayer.TagHelpers.PagingTagHelper __App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
            BeginContext(111, 80, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h4 class=\"text-center\">Phone Numbers List</h4>\r\n");
            EndContext();
#line 9 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
      
        if (Model.Employees.Count == 0)
        {

#line default
#line hidden
            BeginContext(251, 141, true);
            WriteLiteral("            <div class=\"alert alert-primary\" role=\"alert\">\r\n                Phone Numbers list don\'t have any employees\r\n            </div>\r\n");
            EndContext();
#line 15 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(428, 37, true);
            WriteLiteral("            <ul class=\"list-group\">\r\n");
            EndContext();
#line 19 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
                 foreach (var employee in Model.Employees)
                {

#line default
#line hidden
            BeginContext(544, 48, true);
            WriteLiteral("                    <li class=\"list-group-item\">");
            EndContext();
            BeginContext(593, 18, false);
#line 21 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
                                           Write(employee.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(611, 6, true);
            WriteLiteral(" : <b>");
            EndContext();
            BeginContext(618, 20, false);
#line 21 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
                                                                    Write(employee.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(638, 23, true);
            WriteLiteral("</b> &nbsp; | &nbsp; <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 661, "\"", 728, 2);
            WriteAttributeValue("", 668, "/employee/GetEmployeeDetails?employeeId=", 668, 40, true);
#line 21 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
WriteAttributeValue("", 708, employee.EmployeeId, 708, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(729, 50, true);
            WriteLiteral(" class=\"btn btn-success btn-sm\">Details</a></li>\r\n");
            EndContext();
#line 22 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(798, 19, true);
            WriteLiteral("            </ul>\r\n");
            EndContext();
#line 24 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
        }
    

#line default
#line hidden
            BeginContext(835, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
            BeginContext(845, 179, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("product-list-pager", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "daeaefc49b73462aabfea331f54ff11d", async() => {
            }
            );
            __App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper = CreateTagHelper<global::App.PhoneBook.WebUILayer.TagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper);
#line 28 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
__App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper.CurrentDepartment = Model.CurrentDepartment;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-department", __App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper.CurrentDepartment, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
__App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper.CurrentPage = Model.CurrentPage;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("current-page", __App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper.CurrentPage, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
__App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper.PageCount = Model.PageCount;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-count", __App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper.PageCount, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 28 "C:\Users\hhhhx\source\repos\App.PhoneBook\App.PhoneBook.WebUILayer\Views\Employee\Index.cshtml"
__App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper.PageSize = Model.PageSize;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __App_PhoneBook_WebUILayer_TagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1024, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<App.PhoneBook.WebUILayer.Models.EmployeeListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
