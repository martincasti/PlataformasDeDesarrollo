#pragma checksum "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "463cc20229e9d2832a6320fbef886e6752fee0ba"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                  Modelo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                                          Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\n    ");
                __builder2.AddMarkupContent(9, "<h3 class=\"my-4\">Detalle</h3>\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "container");
                __builder2.AddMarkupContent(12, "\n        ");
                __builder2.OpenElement(13, "div");
                __builder2.AddMarkupContent(14, "\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "mb-3");
                __builder2.AddMarkupContent(17, "\n                Fecha:\n                ");
                __Blazor.BlazorApp1.Pages.Detalles.Editar.TypeInference.CreateInputDate_0(__builder2, 18, 19, 
#nullable restore
#line 14 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                                        Modelo.Fecha

#line default
#line hidden
#nullable disable
                , 20, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Fecha = __value, Modelo.Fecha)), 21, () => Modelo.Fecha);
                __builder2.AddMarkupContent(22, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n            ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "mb-3");
                __builder2.AddMarkupContent(26, "\n                Tiempo:\n                ");
                __Blazor.BlazorApp1.Pages.Detalles.Editar.TypeInference.CreateInputNumber_1(__builder2, 27, 28, 
#nullable restore
#line 18 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                                          Modelo.Tiempo

#line default
#line hidden
#nullable disable
                , 29, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.Tiempo = __value, Modelo.Tiempo)), 30, () => Modelo.Tiempo);
                __builder2.AddMarkupContent(31, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "mb-3");
                __builder2.AddMarkupContent(35, "\n                Recurso:\n                ");
                __Blazor.BlazorApp1.Pages.Detalles.Editar.TypeInference.CreateInputSelect_2(__builder2, 36, 37, "p-1", 38, 
#nullable restore
#line 22 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                                                      RecursoId

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => RecursoId = __value, RecursoId)), 40, () => RecursoId, 41, (__builder3) => {
                    __builder3.AddMarkupContent(42, "\n                    ");
                    __builder3.AddMarkupContent(43, "<option value=\"0\">Elija un Recurso</option>\n");
#nullable restore
#line 24 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                     foreach (var item in Recursos)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(44, "                        ");
                    __builder3.OpenElement(45, "option");
                    __builder3.AddAttribute(46, "value", 
#nullable restore
#line 26 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                                        item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(47, 
#nullable restore
#line 26 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                                                  item.Nombre

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(48, "\n");
#nullable restore
#line 27 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(49, "                ");
                }
                );
                __builder2.AddMarkupContent(50, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "mb-3");
                __builder2.AddMarkupContent(54, "\n                Tarea:\n                ");
                __Blazor.BlazorApp1.Pages.Detalles.Editar.TypeInference.CreateInputSelect_3(__builder2, 55, 56, "p-1", 57, 
#nullable restore
#line 32 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                                                      TareaId

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => TareaId = __value, TareaId)), 59, () => TareaId, 60, (__builder3) => {
                    __builder3.AddMarkupContent(61, "\n                    ");
                    __builder3.AddMarkupContent(62, "<option value=\"0\">Elija un Recurso</option>\n");
#nullable restore
#line 34 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                     foreach (var item in Tareas)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(63, "                        ");
                    __builder3.OpenElement(64, "option");
                    __builder3.AddAttribute(65, "value", 
#nullable restore
#line 36 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                                        item.Id

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(66, 
#nullable restore
#line 36 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                                                  item.Titulo

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(67, "\n");
#nullable restore
#line 37 "C:\Users\titox\source\repos\PlataformasDeDesarrollo\13102020\BlazorApp1\Pages\Detalles\Editar.razor"
                    }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(68, "                ");
                }
                );
                __builder2.AddMarkupContent(69, "\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\n            ");
                __builder2.AddMarkupContent(71, "<button class=\"btn btn-primary my-3\" type=\"submit\">Guardar</button>\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\n");
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.BlazorApp1.Pages.Detalles.Editar
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591