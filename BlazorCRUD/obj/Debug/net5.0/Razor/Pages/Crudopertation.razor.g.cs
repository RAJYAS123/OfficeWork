#pragma checksum "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3503932ddc7051786b39a743d4c7e66f8a0d140c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorCRUD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorCRUD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\_Imports.razor"
using BlazorCRUD.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
using BlazorCRUD.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
using BlazorCRUD.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/crud")]
    public partial class Crudopertation : OwningComponentBase<EmpServices>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CRUD Opertation</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                                          Showpopup

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Add New Employee");
            __builder.CloseElement();
#nullable restore
#line 7 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
 if (popup)
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal");
            __builder.AddAttribute(7, "tabindex", "-1");
            __builder.AddAttribute(8, "style", "display:block;");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "modal-dialog");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "modal-content");
            __builder.AddMarkupContent(13, "<div class=\"modal-header\"><h5 class=\"modal-title\">Insert New Employee</h5></div>\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(14);
            __builder.AddAttribute(15, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                                 objinsert

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                                                           Insertrec

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "modal-body");
                __builder2.OpenElement(20, "table");
                __builder2.OpenElement(21, "tr");
                __builder2.AddMarkupContent(22, "<th>Employee Name</th>\r\n                                ");
                __builder2.OpenElement(23, "td");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "text");
                __builder2.AddAttribute(26, "placeholder", "Enter Employee Name..");
                __builder2.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                                                                                                  objinsert.EmpName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objinsert.EmpName = __value, objinsert.EmpName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenElement(30, "tr");
                __builder2.AddMarkupContent(31, "<th>Department</th>\r\n                                ");
                __builder2.OpenElement(32, "td");
                __builder2.OpenElement(33, "input");
                __builder2.AddAttribute(34, "type", "text");
                __builder2.AddAttribute(35, "placeholder", "Enter Department");
                __builder2.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                                                                                             objinsert.Department

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objinsert.Department = __value, objinsert.Department));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                            ");
                __builder2.OpenElement(39, "tr");
                __builder2.AddMarkupContent(40, "<th>Salary</th>\r\n                                ");
                __builder2.OpenElement(41, "td");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "text");
                __builder2.AddAttribute(44, "placeholder", "Enter Salary");
                __builder2.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                                                                                         objinsert.Salary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => objinsert.Salary = __value, objinsert.Salary));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "modal-footer");
                __builder2.OpenElement(50, "button");
                __builder2.AddAttribute(51, "type", "button");
                __builder2.AddAttribute(52, "class", "btn btn-secondary");
                __builder2.AddAttribute(53, "data-bs-dismiss", "modal");
                __builder2.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                                                                                                          Closepopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(55, "Close");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                        ");
                __builder2.OpenElement(57, "button");
                __builder2.AddAttribute(58, "type", "submit");
                __builder2.AddAttribute(59, "class", "btn btn-primary");
                __builder2.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                                                                                Closepopup

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(61, "Save changes");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"

}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "table");
            __builder.AddAttribute(63, "class", "table");
            __builder.AddMarkupContent(64, "<tr><th>Employee ID</th>\r\n        <th>Employee Name</th>\r\n        <th>Department</th>\r\n        <th>Salary</th></tr>");
#nullable restore
#line 53 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
     foreach (var item in Displaydata)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "tr");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 56 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                 item.EmpId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n            ");
            __builder.OpenElement(69, "td");
            __builder.AddContent(70, 
#nullable restore
#line 57 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                 item.EmpName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 58 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                 item.Department

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 59 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                 item.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n            ");
            __builder.OpenElement(78, "td");
            __builder.OpenElement(79, "button");
            __builder.AddAttribute(80, "class", "btn-info");
            __builder.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                                                   (()=>Editrec(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(82, "Edit");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "td");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "class", "btn-danger");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
                                                     (()=>DeleteEmprec(item))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\ADMIN\source\Pankaj\BlazorCRUD\BlazorCRUD\Pages\Crudopertation.razor"
       
    List<EmpClass> Displaydata;
    EmpClass objinsert = new EmpClass();

    bool popup = false;
    void Showpopup()
    {
        popup = true;
    }

    void Closepopup()
    {
        popup = false;
    }

    protected override void OnInitialized()
    {
        Displaydata = Service.GetEmployeess();
    }

    void Insertrec()
    {
        var objupdate = false;
        if (objinsert.EmpId > 0)
        {
            objupdate = Service.UpdateEmployee(objinsert);
            popup = false;
        }
        else
        {

            objinsert.EmpId = 0;
            Service.AddEmployee(objinsert);
        }
        Displaydata = Service.GetEmployeess();
        
    }

    void Editrec(EmpClass ecobj)
    {
        objinsert = ecobj;
        popup = true;
    }

    void DeleteEmprec(EmpClass ecobj)
    {
        Service.DeleteEmployee(ecobj);
        Displaydata.Clear();
        Displaydata = Service.GetEmployeess();
    }

   

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591