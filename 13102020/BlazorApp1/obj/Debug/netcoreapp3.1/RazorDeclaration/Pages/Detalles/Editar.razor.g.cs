#pragma checksum "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "463cc20229e9d2832a6320fbef886e6752fee0ba"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages.Detalles
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Detalles/Editar/{id:int}")]
    public partial class Editar : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
       
    [Parameter]
    public int Id { get; set; }

    public Detalle Modelo { get; set; } = new Detalle();

    public string RecursoId { get; set; }

    private List<Recurso> Recursos;

    public string TareaId { get; set; }

    private List<Tarea> Tareas;

    protected override async Task OnInitializedAsync()
    {
        if (Id > 0)
        {
            Modelo = await DetalleService.SelectDetail(Id);
            RecursoId = Modelo.RecursoId.ToString();
            TareaId = Modelo.TareaId.ToString();
        }
        else
        {
            Modelo = new Detalle();
        }
        Recursos = await DetalleService.GetResource();
        Tareas = await DetalleService.GetTask();
    }


    private async void Guardar()
    {
        Modelo.RecursoId = int.Parse(RecursoId);
        Modelo.TareaId = int.Parse(TareaId);
        await DetalleService.SaveDetail(Modelo);
        navigation.NavigateTo("Detalles/ListadoDetalles");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DetalleService DetalleService { get; set; }
    }
}
#pragma warning restore 1591