#pragma checksum "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a8397c12e6f0a3964c1243496de96f91452241f"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManagement.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails/{id}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetails")]
    public partial class EmployeeDetails : EmployeeDetailsBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
 if(Employee == null || Employee.Department == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "    <div class=\"spinner\"></div> \r\n");
#nullable restore
#line 8 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
}
else { 


#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center m-3");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-8");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-header");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "h1");
            __builder.AddContent(14, 
#nullable restore
#line 15 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                     Employee.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 15 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                         Employee.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\r\n            ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-body text-center");
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "img");
            __builder.AddAttribute(23, "class", "card-img-top");
            __builder.AddAttribute(24, "src", 
#nullable restore
#line 19 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                                Employee.PhotoPath

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\r\n                ");
            __builder.OpenElement(26, "h4");
            __builder.AddContent(27, "Employee ID : ");
            __builder.AddContent(28, 
#nullable restore
#line 21 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                   Employee.EmployeeId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "h4");
            __builder.AddContent(31, "Email : ");
            __builder.AddContent(32, 
#nullable restore
#line 22 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                             Employee.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "h4");
            __builder.AddContent(35, "Department : ");
            __builder.AddContent(36, 
#nullable restore
#line 23 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
                                   Employee.Department.DepartmentName == null ? "N/A" : Employee.Department.DepartmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.AddMarkupContent(39, "<div class=\"card-footer text-center\">\r\n                <a href=\"/\" class=\"btn btn-primary\">Back</a>\r\n                <a href=\"#\" class=\"btn btn-primary\">Edit</a>\r\n                <a href=\"#\" class=\"btn btn-danger\">Delete</a>\r\n            </div>\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 33 "C:\Users\HPz400\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
