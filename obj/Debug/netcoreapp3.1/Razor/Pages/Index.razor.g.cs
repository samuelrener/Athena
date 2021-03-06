#pragma checksum "C:\Users\User\source\repos\Athena\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb414fc26c7cff5c7a4bfa1d79553575f50b9484"
// <auto-generated/>
#pragma warning disable 1591
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
#line 3 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "athena-dia-background");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h3 class=\"athena-title\">Meu Dia</h3>\r\n    ");
            __builder.OpenElement(4, "h6");
            __builder.AddAttribute(5, "class", "athena-subtitle");
            __builder.AddContent(6, 
#nullable restore
#line 10 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                 DataAtual()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "athena-list");
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 12 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
         if (Tarefas != null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "ul");
            __builder.AddAttribute(13, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(14, "\r\n");
#nullable restore
#line 15 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                 foreach (var tarefa in Tarefas.Where(x => !x.Finished).OrderByDescending(x => x.Important))
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(15, "                    ");
            __builder.OpenElement(16, "li");
            __builder.AddAttribute(17, "class", "athena-dia-list-group list-group-item list-group-item-action");
            __builder.AddAttribute(18, "style", "border-radius: 4px;");
            __builder.AddMarkupContent(19, "\r\n\r\n                        ");
            __builder.OpenComponent<BlazorContextMenu.ContextMenuTrigger>(20);
            __builder.AddAttribute(21, "MenuId", "menuToDo");
            __builder.AddAttribute(22, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                    tarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(24, "\r\n\r\n                            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "custom-control custom-checkbox");
                __builder2.AddMarkupContent(27, "\r\n                                ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "type", "checkbox");
                __builder2.AddAttribute(30, "id", "ToDoItem_" + (
#nullable restore
#line 22 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                     tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                            e => HandleFinished(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "name", "ToDoItem_" + (
#nullable restore
#line 22 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                                                                             tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "class", "custom-control-input");
                __builder2.AddAttribute(34, "checked", 
#nullable restore
#line 22 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                                                                                                                               tarefa.Finished

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n                                ");
                __builder2.OpenElement(36, "label");
                __builder2.AddAttribute(37, "class", "custom-control-label");
                __builder2.AddAttribute(38, "for", "ToDoItem_" + (
#nullable restore
#line 23 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                   tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(39, 
#nullable restore
#line 23 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                               tarefa.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n");
#nullable restore
#line 24 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                     if (tarefa.DeadLine.HasValue) {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(41, "                                        ");
                __builder2.OpenElement(42, "label");
                __builder2.AddMarkupContent(43, "\r\n                                            &bull;\r\n                                            <i class=\"far fa-calendar\"></i> ");
                __builder2.AddContent(44, 
#nullable restore
#line 27 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                             tarefa.ExtenseDeadLine(tarefa.DeadLine.Value)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(45, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n");
#nullable restore
#line 29 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(47, "                            \r\n");
#nullable restore
#line 31 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                 if (tarefa.Important)
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(48, "                                    ");
                __builder2.OpenElement(49, "i");
                __builder2.AddAttribute(50, "class", "fas fa-star");
                __builder2.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                       e => HandleImportant(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n");
#nullable restore
#line 34 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(53, "                                    ");
                __builder2.OpenElement(54, "i");
                __builder2.AddAttribute(55, "class", "far fa-star");
                __builder2.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                       e => HandleImportant(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n");
#nullable restore
#line 38 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(58, "                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n                        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n");
#nullable restore
#line 42 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(62, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n");
#nullable restore
#line 44 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
            if (Tarefas.Any(x => x.Finished))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(64, "                ");
            __builder.OpenElement(65, "a");
            __builder.AddAttribute(66, "class", "btn athena-dia-finished-button btn-sm");
            __builder.AddAttribute(67, "href", "javascript:;");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                                 e => ShowFinished = !ShowFinished

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(69, "\r\n");
#nullable restore
#line 47 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                     if (ShowFinished)
                    {


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(70, "                        <i class=\"fas fa-chevron-down\"></i>\r\n");
#nullable restore
#line 51 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "                        <i class=\"fas fa-chevron-right\"></i>\r\n");
#nullable restore
#line 55 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(72, "                    Concluída\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
#nullable restore
#line 58 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                 if (ShowFinished)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(74, "                    ");
            __builder.OpenElement(75, "ul");
            __builder.AddAttribute(76, "class", "list-group list-group-flush");
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 61 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                         foreach (var tarefa in Tarefas.Where(x => x.Finished).OrderByDescending(x => x.Important))
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(78, "                        ");
            __builder.OpenElement(79, "li");
            __builder.AddAttribute(80, "class", "athena-dia-list-group list-group-item list-group-item-action");
            __builder.AddAttribute(81, "style", "border-radius: 4px;");
            __builder.AddMarkupContent(82, "\r\n                            ");
            __builder.OpenComponent<BlazorContextMenu.ContextMenuTrigger>(83);
            __builder.AddAttribute(84, "MenuId", "menuToDo");
            __builder.AddAttribute(85, "Data", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 64 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                        tarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(87, "\r\n                                ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "custom-control custom-checkbox");
                __builder2.AddMarkupContent(90, "\r\n                                    ");
                __builder2.OpenElement(91, "input");
                __builder2.AddAttribute(92, "type", "checkbox");
                __builder2.AddAttribute(93, "id", "ToDoItem_" + (
#nullable restore
#line 66 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                         tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(94, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                                e => HandleFinished(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(95, "name", "ToDoItem_" + (
#nullable restore
#line 66 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                                                                                 tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(96, "class", "custom-control-input");
                __builder2.AddAttribute(97, "checked", 
#nullable restore
#line 66 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                                                                                                                                   tarefa.Finished

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n                                    ");
                __builder2.OpenElement(99, "label");
                __builder2.AddAttribute(100, "class", "custom-control-label");
                __builder2.AddAttribute(101, "for", "ToDoItem_" + (
#nullable restore
#line 67 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                       tarefa.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(102, 
#nullable restore
#line 67 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                                   tarefa.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n");
#nullable restore
#line 68 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                     if (tarefa.DeadLine.HasValue)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(104, "                                        ");
                __builder2.OpenElement(105, "label");
                __builder2.AddMarkupContent(106, "\r\n                                            &bull;\r\n                                            <i class=\"far fa-calendar\"></i> ");
                __builder2.AddContent(107, 
#nullable restore
#line 72 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                             tarefa.ExtenseDeadLine(tarefa.DeadLine.Value)

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(108, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n");
#nullable restore
#line 74 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(110, "\r\n");
#nullable restore
#line 76 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                     if (tarefa.Important)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(111, "                                        ");
                __builder2.OpenElement(112, "i");
                __builder2.AddAttribute(113, "class", "fas fa-star");
                __builder2.AddAttribute(114, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                           e => HandleImportant(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n");
#nullable restore
#line 79 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(116, "                                        ");
                __builder2.OpenElement(117, "i");
                __builder2.AddAttribute(118, "class", "far fa-star");
                __builder2.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                           e => HandleImportant(tarefa.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n");
#nullable restore
#line 83 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                    }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(121, "                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(123, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n");
#nullable restore
#line 87 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(125, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n");
#nullable restore
#line 89 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                 
            }
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n    ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "container athena-workspace");
            __builder.AddMarkupContent(131, "\r\n        ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "input-group");
            __builder.AddMarkupContent(134, "\r\n            ");
            __builder.AddMarkupContent(135, "<div class=\"input-group-prepend\">\r\n                <span class=\"athena-add-input input-group-text\">\r\n                    <i class=\"fas fa-plus\"></i>\r\n                </span>\r\n            </div>\r\n            ");
            __builder.OpenElement(136, "input");
            __builder.AddAttribute(137, "class", "form-control athena-add-input");
            __builder.AddAttribute(138, "placeholder", "Adicionar uma Tarefa");
            __builder.AddAttribute(139, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                                                                                   HandleKeyPress

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(140, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 100 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                                                                                                   TarefaAtual

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(141, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => TarefaAtual = __value, TarefaAtual));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n\r\n");
            __builder.OpenComponent<BlazorContextMenu.ContextMenu>(146);
            __builder.AddAttribute(147, "Id", "menuToDo");
            __builder.AddAttribute(148, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<BlazorContextMenu.MenuRenderingContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(149, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(150);
                __builder2.AddAttribute(151, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(152, "<i class=\"fas fa-unlink\"></i>Remover de Meu Dia");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(153, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(154);
                __builder2.AddAttribute(155, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#nullable restore
#line 108 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                     e => HandleImportant((e.Data as ToDo).Id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(156, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(157, "\r\n        <i class=\"far fa-star\"></i> Marcar como Importante\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(158, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(159);
                __builder2.AddAttribute(160, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#nullable restore
#line 111 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                     e => HandleFinished((e.Data as ToDo).Id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(161, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(162, "<i class=\"far fa-check-circle\"></i> Marcar como Concluída");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(163, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Seperator>(164);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(165, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(166);
                __builder2.AddAttribute(167, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#nullable restore
#line 113 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                     e => HandleDeadLine((e.Data as ToDo).Id, DateTime.Now)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(168, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(169, "<i class=\"far fa-calendar-check\"></i> Concluir hoje");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(170, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(171);
                __builder2.AddAttribute(172, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#nullable restore
#line 114 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                     e => HandleDeadLine((e.Data as ToDo).Id, DateTime.Now.AddDays(1))

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(173, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(174, "<i class=\"far fa-calendar-minus\"></i> Concluir Amanhã");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(175, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(176);
                __builder2.AddAttribute(177, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(178, "<i class=\"far fa-calendar-alt\"></i> Escolher uma data");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(179, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Seperator>(180);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(181, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(182);
                __builder2.AddAttribute(183, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(184, "<i class=\"fas fa-tasks\"></i> Mover Tarefa Para...");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(185, "\r\n    ");
                __builder2.OpenComponent<BlazorContextMenu.Item>(186);
                __builder2.AddAttribute(187, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorContextMenu.ItemClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorContextMenu.ItemClickEventArgs>(this, 
#nullable restore
#line 118 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
                     e => Delete(e.Data as ToDo)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(188, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(189, "<div style=\"color: red\"><i class=\"far fa-trash-alt\"></i> Excluir Tarefa</div>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(190, "\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(191, "\r\n\r\n");
            __builder.OpenComponent<BlazorContextMenu.ContextMenu>(192);
            __builder.AddAttribute(193, "Id", "menuData");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 125 "C:\Users\User\source\repos\Athena\Pages\Index.razor"
      
    private bool ShowFinished = true;
    private string TarefaAtual { get; set; }


    protected override void OnInitialized()
    {
        if (toDoController == null) toDoController = new ToDoController(config);
        Tarefas = toDoController.GetAll();
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.AspNetCore.Hosting.IWebHostEnvironment _env { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Microsoft.Extensions.Configuration.IConfiguration config { get; set; }
    }
}
#pragma warning restore 1591
