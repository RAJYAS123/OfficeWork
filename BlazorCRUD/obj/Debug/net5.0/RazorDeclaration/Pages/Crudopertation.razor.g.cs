// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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