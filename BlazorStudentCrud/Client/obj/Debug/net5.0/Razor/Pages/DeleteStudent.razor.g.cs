#pragma checksum "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\DeleteStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ec3f93fe6225696d817c3c7b34314d16cb3b4f6"
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
#line 2 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\DeleteStudent.razor"
using BlazorStudentCrud.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/deletestudent/{id}")]
    public partial class DeleteStudent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>DeleteStudent</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Are you sure you want to delete this student:");
            __builder.OpenElement(3, "b");
            __builder.AddContent(4, 
#nullable restore
#line 8 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\DeleteStudent.razor"
                                                     std.studentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n<br>\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-4");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.OpenElement(10, "tr");
            __builder.AddMarkupContent(11, "<td>Name</td>\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 14 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\DeleteStudent.razor"
                 std.studentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "<td>Course</td>\r\n            ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 18 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\DeleteStudent.razor"
                 std.course

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "tr");
            __builder.AddMarkupContent(21, "<td>Year</td>\r\n            ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 22 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\DeleteStudent.razor"
                 std.year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-primary");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\DeleteStudent.razor"
                                                                Delete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "value", "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "button");
            __builder.AddAttribute(35, "class", "btn");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\DeleteStudent.razor"
                                                    Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\Debojit Paul\source\repos\BlazorStudentCrud\BlazorStudentCrud\Client\Pages\DeleteStudent.razor"
       

    [Parameter]
    //INT datatype will not directing to another page..if you want o direct another page for update or delete..must specify STRING datatype whaterver it is (int,bool,etc)
    public String id { get; set; }

    studentInfo std = new studentInfo();

    //to get the id from a particular student from database
    protected override async Task OnInitializedAsync()
    {
        std = await Http.GetJsonAsync<studentInfo>("http://localhost:55366/api/studentinfoes/" + id);
    }


    protected async Task Delete()
    {
        //delete from database
        await Http.DeleteAsync("http://localhost:55366/api/studentinfoes/" + id);
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