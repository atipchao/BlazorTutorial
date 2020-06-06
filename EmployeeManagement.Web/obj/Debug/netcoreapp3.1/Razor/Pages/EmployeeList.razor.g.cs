#pragma checksum "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c41dfc416265b0f008f34f7f665c560b5275087a"
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
#line 1 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\projects\BlazorTutorial\EmployeeManagement.Web\_Imports.razor"
using EmployeeManagement.Web.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class EmployeeList : EmployeeListBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, "Selected Employee Count - ");
            __builder.AddContent(2, 
#nullable restore
#line 4 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                               SelectedEmployeeCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(3, "\r\n");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "checkbox");
            __builder.AddAttribute(6, "id", "showFooter");
            __builder.AddAttribute(7, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 5 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                              ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ShowFooter = __value, ShowFooter));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.AddMarkupContent(10, "<label for=\"showFooter\">Show Footer</label>\r\n");
#nullable restore
#line 7 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
 if (Employees == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "    <div class=\"spinner\"></div>\r\n");
#nullable restore
#line 10 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(12, "    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card-deck");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 14 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
         foreach (var employee in Employees)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "        ");
            __builder.OpenComponent<EmployeeManagement.Web.Pages.DisplayEmployee>(17);
            __builder.AddAttribute(18, "employee", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<EmployeeManagement.Models.Employee>(
#nullable restore
#line 16 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                   employee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "ShowFooter", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                                         ShowFooter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnEmployeeSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 17 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
                                              OnEmployeeSelectionChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(21, "                         \r\n");
#nullable restore
#line 18 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(22, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n");
#nullable restore
#line 20 "C:\projects\BlazorTutorial\EmployeeManagement.Web\Pages\EmployeeList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
