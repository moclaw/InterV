// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TodoApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\_Imports.razor"
using TodoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\_Imports.razor"
using TodoApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\Pages\Todoapp.razor"
using TodoApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\Pages\Todoapp.razor"
using TodoApp.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todoapp")]
    public partial class Todoapp : OwningComponentBase<TodoService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 61 "C:\Users\mocdu\source\repos\TodoApp\TodoApp\Pages\Todoapp.razor"
       
    List<TodoItem> todoItems;
    TodoItem todos = new TodoItem();
    bool popup = false;
    string noteNull = "";
    protected override void OnInitialized()
    {
        todoItems = Service.GetAllTodo();
    }
    void Showpop()
    {
        popup = true;
    }
    void CloseUp()
    {
        popup = false;
    }
    void Add(TodoItem todoUpdate)
    {
        if (todos.note == null)
        {
            todos.note = noteNull;
        }
        if (todos.title == null)
        {
            todos.note = noteNull;
        }
        if (todos.id > 0)
        {
            var updateTodo = Service.UpdateTodo(todoUpdate);
            updateTodo = Service.UpdateTodo(todos);

        }
        else
        {
            todos.id = 0;
            Service.InserTodo(todos);
            todoItems = Service.GetAllTodo();
            popup = false;

        }
        todoItems = Service.GetAllTodo();
    }
    void DeleteItem(TodoItem todoDel)
    {
        var del = Service.DeleteTodo(todoDel);
        todoItems.Remove(todoDel);
    }
    void DeleteTodo(TodoItem delTodo)
    {
        var dels = Service.DeleteTodo(delTodo);
        todoItems.Clear();
    }
    void EditTodo(TodoItem todoEdit)
    {
        todos = todoEdit;
        popup = true;
    }
    void UpdateTodo(TodoItem todoUpdate)
    {
        var updateTodo = Service.UpdateTodo(todoUpdate);
        todoItems = Service.GetAllTodo();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
