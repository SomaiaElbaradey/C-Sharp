#pragma checksum "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35f5019ca5cbd7b0c65c61a9683e76cbcd1eddea"
// <auto-generated/>
#pragma warning disable 1591
namespace Lab01._01.Pages.Trainees
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Lab01._01;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\_Imports.razor"
using Lab01._01.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/trainee/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"card-title\">Create Trainee</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                  trainee

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 5 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                                           HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group row");
                __builder2.AddMarkupContent(11, "<label for=\"Id\" class=\"col-form-label\">Id: </label>\r\n        ");
                __Blazor.Lab01._01.Pages.Trainees.Create.TypeInference.CreateInputNumber_0(__builder2, 12, 13, "Id", 14, "form-control", 15, "Trainee Id", 16, 
#nullable restore
#line 13 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                                                                trainee.Id

#line default
#line hidden
#nullable disable
                , 17, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trainee.Id = __value, trainee.Id)), 18, () => trainee.Id);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group row");
                __builder2.AddMarkupContent(22, "<label for=\"Name\" class=\"col-form-label\">name: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "Name");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "placeholder", "Trainee Name");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                                                                trainee.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trainee.Name = __value, trainee.Name))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => trainee.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n\r\n\r\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group row");
                __builder2.AddMarkupContent(33, "<label for=\"birthdate\" class=\"col-form-label\">Birthdate: </label>\r\n        ");
                __Blazor.Lab01._01.Pages.Trainees.Create.TypeInference.CreateInputDate_1(__builder2, 34, 35, "birthdate", 36, "form-control", 37, "Trainee BirthDate", 38, 
#nullable restore
#line 24 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                                                                     trainee.BirthDate

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trainee.BirthDate = __value, trainee.BirthDate)), 40, () => trainee.BirthDate);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n    ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group row");
                __builder2.AddMarkupContent(44, "<label for=\"email\" class=\"col-form-label\">Email: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "id", "email");
                __builder2.AddAttribute(47, "class", "form-control");
                __builder2.AddAttribute(48, "placeholder", "Trainee Email");
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                                                                 trainee.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trainee.Email = __value, trainee.Email))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => trainee.Email));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group row");
                __builder2.AddMarkupContent(55, "<label for=\"MobileNo\" class=\"col-form-label\">Mobile No: </label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(56);
                __builder2.AddAttribute(57, "id", "MobileNo");
                __builder2.AddAttribute(58, "class", "form-control");
                __builder2.AddAttribute(59, "placeholder", "Trainee phone number");
                __builder2.AddAttribute(60, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                                                                    trainee.PhoneNumber

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(61, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trainee.PhoneNumber = __value, trainee.PhoneNumber))));
                __builder2.AddAttribute(62, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => trainee.PhoneNumber));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n\r\n    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group row");
                __builder2.AddMarkupContent(66, "<label for=\"gender\" class=\"col-form-label\">Trainee Gender: </label>\r\n        ");
                __Blazor.Lab01._01.Pages.Trainees.Create.TypeInference.CreateInputSelect_2(__builder2, 67, 68, "gender", 69, "form-control", 70, 
#nullable restore
#line 39 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                                                                   trainee.Gender

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trainee.Gender = __value, trainee.Gender)), 72, () => trainee.Gender, 73, (__builder3) => {
                    __builder3.OpenElement(74, "option");
                    __builder3.AddAttribute(75, "value", 
#nullable restore
#line 40 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                             sharedLibarary.Gender.Male

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(76, "Male");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n            ");
                    __builder3.OpenElement(78, "option");
                    __builder3.AddAttribute(79, "value", 
#nullable restore
#line 41 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                             sharedLibarary.Gender.Female

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(80, "Female");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n\r\n    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group row");
                __builder2.AddMarkupContent(84, "<label for=\"IsGraduated\" class=\"col-form-label\">IsGraduated: </label>\r\n        ");
                __Blazor.Lab01._01.Pages.Trainees.Create.TypeInference.CreateInputSelect_3(__builder2, 85, 86, "gender", 87, "form-control", 88, 
#nullable restore
#line 47 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                                                                   trainee.IsGraduated

#line default
#line hidden
#nullable disable
                , 89, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trainee.IsGraduated = __value, trainee.IsGraduated)), 90, () => trainee.IsGraduated, 91, (__builder3) => {
                    __builder3.OpenElement(92, "option");
                    __builder3.AddAttribute(93, "value", 
#nullable restore
#line 48 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                             true

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(94, "True");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(95, "\r\n            ");
                    __builder3.OpenElement(96, "option");
                    __builder3.AddAttribute(97, "value", 
#nullable restore
#line 49 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                             false

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(98, "False");
                    __builder3.CloseElement();
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n\r\n    ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group row");
                __builder2.AddMarkupContent(102, "<label for=\"trackId\" class=\"col-form-label\">track Id: </label>\r\n        ");
                __Blazor.Lab01._01.Pages.Trainees.Create.TypeInference.CreateInputNumber_4(__builder2, 103, 104, "trackId", 105, "form-control", 106, "Track", 107, 
#nullable restore
#line 55 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
                                                                     trainee.TrackId

#line default
#line hidden
#nullable disable
                , 108, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => trainee.TrackId = __value, trainee.TrackId)), 109, () => trainee.TrackId);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(110, "\r\n\r\n    ");
                __builder2.AddMarkupContent(111, "<button type=\"submit\" class=\"btn btn-primary\">Create</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "D:\ITI\courses\33- Blazor\Labs\Lab01\Lab01.01\Pages\Trainees\Create.razor"
       

    sharedLibarary.Trainee trainee = new sharedLibarary.Trainee();

    private void HandleValidSubmit()
    {
        sharedLibarary.ITIContext.trainees.Add(trainee);
    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Lab01._01.Pages.Trainees.Create
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
