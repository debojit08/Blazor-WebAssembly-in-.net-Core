#pragma checksum "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\AddStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8776796e481cdd0d779a3ec2566f9fd98d15c05"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorStudentCrud.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\_Imports.razor"
using BlazorStudentCrud.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\_Imports.razor"
using BlazorStudentCrud.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\AddStudent.razor"
using BlazorStudentCrud.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addstudent")]
    public partial class AddStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Add Student</h3>\r\n<hr>\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"studentName\" class=\"control-label\">Name</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "for", "studentName");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\AddStudent.razor"
                                                                      std.studentName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => std.studentName = __value, std.studentName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"course\" class=\"control-label\">Course</label>\r\n                ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "for", "course");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\AddStudent.razor"
                                                                 std.course

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => std.course = __value, std.course));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"year\" class=\"control-label\">Year</label>\r\n                ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "for", "year");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\AddStudent.razor"
                                                               std.year

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => std.year = __value, std.year));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "col-md-4");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "form-group");
            __builder.OpenElement(39, "input");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-primary");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\AddStudent.razor"
                                                                        CreateStudent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(43, "value", "save");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\AddStudent.razor"
                                                            Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(49, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 35 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\AddStudent.razor"
       

    studentInfo std = new studentInfo();
    protected async Task CreateStudent() //can not be same as enclosing type @page "/AddStudent"
    {
        await Http.PostJsonAsync("http://localhost:55366/api/studentinfoes", std);
        NavigationManager.NavigateTo("studentList");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("studentList");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591