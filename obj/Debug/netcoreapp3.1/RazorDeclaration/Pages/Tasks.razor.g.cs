#pragma checksum "C:\Users\User\source\repos\Athena\Pages\Tasks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bf3ffd9b275a2d13c66377f5ac24bd08b088e9b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Athena.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\source\repos\Athena\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Athena;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Athena.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Athena.Database.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User\source\repos\Athena\_Imports.razor"
using Athena.Database.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User\source\repos\Athena\_Imports.razor"
using BlazorContextMenu;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tasks")]
    public partial class Tasks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 123 "C:\Users\User\source\repos\Athena\Pages\Tasks.razor"
      
    private bool ShowFinished = true;
    private string TarefaAtual { get; set; }


    protected override void OnInitialized()
    {
        if (toDoController == null) toDoController = new ToDoController(config);
        Tarefas = toDoController.GetAll(true);
    }

    async Task HandleKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter") Adicionar();
    }

    void Delete(ItemClickEventArgs e)
    {
        Delete(e.Data as ToDo);
    }

    void HandleImportant(ItemClickEventArgs e)
    {
        HandleImportant((e.Data as ToDo).Id);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
