#pragma checksum "/media/franzedel/Archivos y Tutoriales/Zoom/Programacion II/Codigos/Turnos/Views/Turno/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca187f662e1ba678e6a6ce2071ea183409a04c87"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Turno_Index), @"mvc.1.0.view", @"/Views/Turno/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/media/franzedel/Archivos y Tutoriales/Zoom/Programacion II/Codigos/Turnos/Views/_ViewImports.cshtml"
using Turnos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/media/franzedel/Archivos y Tutoriales/Zoom/Programacion II/Codigos/Turnos/Views/_ViewImports.cshtml"
using Turnos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca187f662e1ba678e6a6ce2071ea183409a04c87", @"/Views/Turno/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5b9c7a7584d54ef9e045a44f17b50f6dc5da374", @"/Views/_ViewImports.cshtml")]
    public class Views_Turno_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Turnos.Models.Turno>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col s12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fullcalendar/fullcalendar.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fullcalendar/fullcalendar.print.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("media", new global::Microsoft.AspNetCore.Html.HtmlString("print"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/fullcalendar/fullcalendar.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/fullcalendar/locale/es.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/media/franzedel/Archivos y Tutoriales/Zoom/Programacion II/Codigos/Turnos/Views/Turno/Index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 3 "/media/franzedel/Archivos y Tutoriales/Zoom/Programacion II/Codigos/Turnos/Views/Turno/Index.cshtml"
  
    ViewBag.Title = "Asignación de Turnos";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"row\">\n    <div class=\"col s6\">\n        <label for=\"IdMedico\">Médico</label>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca187f662e1ba678e6a6ce2071ea183409a04c876587", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 10 "/media/franzedel/Archivos y Tutoriales/Zoom/Programacion II/Codigos/Turnos/Views/Turno/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdMedico);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 10 "/media/franzedel/Archivos y Tutoriales/Zoom/Programacion II/Codigos/Turnos/Views/Turno/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.IdMedico;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n\n    <div class=\"col s6\">\n        <label for=\"IdPaciente\">Paciente</label>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca187f662e1ba678e6a6ce2071ea183409a04c878605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 15 "/media/franzedel/Archivos y Tutoriales/Zoom/Programacion II/Codigos/Turnos/Views/Turno/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdPaciente);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 15 "/media/franzedel/Archivos y Tutoriales/Zoom/Programacion II/Codigos/Turnos/Views/Turno/Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.IdPaciente;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    </div>\n</div>\n<br>\n\n<div id=\"ModalTurno\" class=\"modal\">\n    <div class=\"modal-content\">\n        <h4 class=\"brown lighten-4\">Turno</h4>\n\n        <div class=\"row\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca187f662e1ba678e6a6ce2071ea183409a04c8710722", async() => {
                WriteLiteral("\n                ");
#nullable restore
#line 26 "/media/franzedel/Archivos y Tutoriales/Zoom/Programacion II/Codigos/Turnos/Views/Turno/Index.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col s6"">
                        <label><i class=""tiny material-icons prefix"">assignment_ind</i> Paciente</label>
                        <input type=""text"" id=""txtPaciente"" readonly=""readonly"">
                    </div>
                    <div class=""col s6"">
                        <label><i class=""tiny material-icons prefix"">medication</i> Médico</label>
                        <input type=""text"" id=""txtMedico"" readonly=""readonly"">
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col s6"">
                        <label><i class=""tiny material-icons prefix"">event_note</i> Hora inicio</label>
                        <input type=""text"" id=""txtFechaHoraInicio"" readonly=""readonly"">
                    </div>
                    <div class=""col s6"">
                        <label><i class=""tiny material-icons prefix"">event_note</i> Hora fin</label>
                        <input");
                WriteLiteral(" type=\"text\" id=\"txtFechaHoraFin\" readonly=\"readonly\">\n                    </div>\n                </div>\n\n\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
    </div>

    <div class=""modal-footer blue-grey darken-2"">
        <a href=""#"" id=""btnEliminar"" class=""modal-close waves-effect red btn"">Eliminar</a>
        <a href=""#"" id=""btnGuardar"" class=""modal-close btn waves-effect waves-light"">Guardar</a>
        <a href=""#"" id=""btnCerrar"" class=""modal-close waves-effect grey btn"">Cerrar</a>
    </div>
</div>

<div id=""CalendarioTurnos""></div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca187f662e1ba678e6a6ce2071ea183409a04c8713940", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ca187f662e1ba678e6a6ce2071ea183409a04c8715039", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n<script src=\"https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.22.2/moment.min.js\"></script>\n\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca187f662e1ba678e6a6ce2071ea183409a04c8716411", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca187f662e1ba678e6a6ce2071ea183409a04c8717491", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('.modal').modal();
        var horarioDesde = """";
        var horarioHasta = """";
        var turnos = [];
        var turnoSeleccionado = [];

        ObtenerTurnosYActualizar($('#IdMedico').val(), $('#IdPaciente').val());

        $('#IdMedico').change(function () {
            var idMedico = this.value;
            var idPaciente = $('#IdPaciente').val();
            ObtenerTurnosYActualizar(idMedico, idPaciente);
        });

        $('#IdPaciente').change(function () {
            var idPaciente = this.value;
            var idMedico = $('#IdMedico').val();
            ObtenerTurnosYActualizar(idMedico, idPaciente);
        });

        function ObtenerTurnosYActualizar(idMedico, idPaciente) {
            turnos = [];
            $.ajax({
                type: ""GET"",
                url: ""Turno/ObtenerTurnos"",
                data: { 'IdMedico': idMedico, 'IdPaciente': idPaciente },
                success: function (datos) {
                    $.e");
                WriteLiteral(@"ach(datos, function (i, v) {
                        //Poner las iniciales en minusculas
                        turnos.push({
                            idTurno: v.idTurno,
                            idPaciente: v.idPaciente,
                            idMedico: v.idMedico,
                            start: moment(v.fechaHoraInicio),
                            end: v.fechaHoraFin != null ? moment(v.fechaHoraFin) : null,
                            paciente: v.paciente,
                            medico: v.medico
                        });
                    });
                    GenerarCalendario(turnos);
                },
                error: function () {
                    alert('Error al obtener turnos.');
                }
            });
        }

        function GenerarCalendario(turnos) {

            $.ajax({
                type: ""GET"",
                url: ""Medico/TraerHorarioAtencionDesde"",
                data: { ""idMedico"": $('#IdMedico').val() },
                async: false,
 ");
                WriteLiteral(@"               success: function (resultado) {
                    horarioDesde = resultado;
                },
                error: function () {
                    alert(""Error al traer el horario de atención del médico"")
                }
            });

            $.ajax({
                type: ""GET"",
                url: ""Medico/TraerHorarioAtencionHasta"",
                data: { ""idMedico"": $('#IdMedico').val() },
                async: false,
                success: function (resultado) {
                    horarioHasta = resultado;
                },
                error: function () {
                    alert(""Error al traer el horario de atención hasta del médico"")
                }
            });

            $('#CalendarioTurnos').fullCalendar('destroy');

            $('#CalendarioTurnos').fullCalendar({
                contentHeight: 'auto',
                defaultDate: new Date(),
                slotLabelFormat: ""HH:mm"",
                defaultView: 'agendaWeek',
                head");
                WriteLiteral(@"er: {
                    left: 'prev,next today',
                    right: 'month,agendaWeek,agendaDay',
                },
                slotDuration: '00:30',
                nowIndicator: true,
                allDaySlot: false,
                selectable: true,
                eventLimit: true,
                minTime: horarioDesde,
                maxTime: horarioHasta,
                events: turnos,
                select: function (fechaHoraInicio, fechaHoraFin) {
                    turnoSeleccionado = {
                        idTurno: 0,
                        start: fechaHoraInicio,
                        end: fechaHoraFin
                    };
                    AbrirPopup();
                },
                eventClick: function (turnoClickeado) {
                    turnoSeleccionado = turnoClickeado,
                        AbrirPopup();
                }

            })
        }

        function AbrirPopup() {
            $('#txtFechaHoraInicio').val(turnoSeleccionado.start.format");
                WriteLiteral(@"('DD/MM/YYYY HH:mm'));
            $('#txtFechaHoraFin').val(turnoSeleccionado.end.format('DD/MM/YYYY HH:mm'));
            $('#txtPaciente').val($('#IdPaciente option:selected').text());
            $('#txtMedico').val($('#IdMedico option:selected').text());

            if (turnoSeleccionado.idTurno == 0) {
                $('#btnGuardar').show()
                $('#btnEliminar').hide()
            } else {
                $('#btnGuardar').hide()
                $('#btnEliminar').show()
            }

            $('#ModalTurno').modal('open');
        }


        $('#btnGuardar').click(function () {
            var datosDelTurno = {
                IdPaciente: $('#IdPaciente').val(),
                IdMedico: $('#IdMedico').val(),
                FechaHoraInicio: $('#txtFechaHoraInicio').val(),
                FechaHoraFin: $('#txtFechaHoraFin').val()
            };

            GrabarTurno(datosDelTurno);
        });

        function GrabarTurno(turno) {
            $.ajax({
                type: ""POST"",");
                WriteLiteral(@"
                url: ""Turno/GrabarTurno"",
                data: { ""turno"": turno },
                headers: { 'RequestVerificationToken': $('input[name=""__RequestVerificationToken""]').val() },
                success: function (respuesta) {
                    if (respuesta.ok) {
                        Swal.fire({
                            position: 'center',
                            title: 'Correcto!!!',
                            text: 'Turno guardado correctamente',
                            icon: 'success',
                            showConfirmButton: false,
                            timer: 3000
                        }).then((result) => {
                            ObtenerTurnosYActualizar($('#IdMedico').val(), $('#IdPaciente').val());
                        });
                    }
                },
                error: function () {
                    Swal.fire({
                        position: 'center',
                        title: 'Error!',
                        text: 'No");
                WriteLiteral(@" se pudo guardar el Turno',
                        icon: 'error',
                        showConfirmButton: false,
                        timer: 3000
                    })
                }

            });
        }

        $('#btnEliminar').click(function () {
            Swal.fire({
                title: '¿Esta seguro?',
                text: ""El Turno se eliminar definitivamente!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Si, Eliminar!',
                cancelButtonText: 'Cancelar'
            }).then((result) => {
                if (result.isConfirmed) {

                    $.ajax({
                        type: ""POST"",
                        url: ""Turno/EliminarTurno"",
                        data: { 'IdTurno': turnoSeleccionado.idTurno },
                        headers: { 'RequestVerificationToken': $('input[name=""__RequestVerificationTo");
                WriteLiteral(@"ken""]').val() },
                        success: function (resultado) {
                            if (resultado.ok) {
                                Swal.fire({
                                    position: 'center',
                                    title: 'Eliminado!',
                                    text: 'Turno eliminado correctamente',
                                    icon: 'success',
                                    showConfirmButton: false,
                                    timer: 3000
                                }).then((result) => {
                                    ObtenerTurnosYActualizar($('#IdMedico').val(), $('#IdPaciente').val());
                                });
                            }
                        },
                        error: function () {
                            Swal.fire({
                                position: 'center',
                                title: 'Error!',
                                text: 'No se pudo eliminar el Turno");
                WriteLiteral(@"',
                                icon: 'error',
                                showConfirmButton: false,
                                timer: 3000
                            })
                        }
                    });

                }
            })
        });

    })
</script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Turnos.Models.Turno> Html { get; private set; }
    }
}
#pragma warning restore 1591
