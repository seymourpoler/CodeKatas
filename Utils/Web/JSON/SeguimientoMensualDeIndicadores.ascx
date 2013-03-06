
<script type="text/javascript" src="/js/funciones.js"></script>
<script type="text/javascript" src="/js/jquery.dataTables.js"></script>
<script type="text/javascript" src="/js/gestorHTMLControles.js"></script>

<script type="text/javascript">
    function buscarDatos() {
        var anio = conseguirValorSeleccionadoEnCombo('anio');
        if(anio == ''){return;}
        var mes = conseguirValorSeleccionadoEnCombo('mes');
        if(mes == ''){return;}
        var nombrePagina = conseguirNombreDeLaPagina();
        var nocache = new Date().getTime();
        var param = {
            "accion": "Buscar",
            "nocache": nocache,
            "mes": mes,
            "anio": anio
        };

        $.getJSON(nombrePagina, param, function (returnData) {
            cargarDatosEnTabla(returnData, mes, anio);
        });
    }

    function cargarDatosEnTabla(datos, mes, anio) {
        $('#tablaDatos').dataTable({
            "bDestroy": true,
            "bProcessing": true,
            "bPaginate": true,
            "bSortable": true,
            "aaSorting": [[ 1, "asc" ]],
            "bSearchable": true,
            "bFilter": true,
            "bInfo": true,
            "bJQueryUI": false,
            "bAutoWidth": false,
            "sDom": 'Rlfrtip',
            "sPaginationType": "full_numbers",
            "oLanguage": { "sProcessing": '<asp:Literal ID="oLanguage_sProcessing" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sProcessing%>' />',
                "sLengthMenu": '<asp:Literal ID="oLanguage_sLengthMenu" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sLengthMenu%>' />',
                "sZeroRecords": '<asp:Literal ID="oLanguage_sZeroRecords" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sZeroRecords%>' />',
                "sEmptyTable": '<asp:Literal ID="oLanguage_sEmptyTable" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sEmptyTable%>' />',
                "sInfo": '<asp:Literal ID="oLanguage_sInfo" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sInfo%>' />',
                "sInfoEmpty": '<asp:Literal ID="oLanguage_sInfoEmpty" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sInfoEmpty%>' />',
                "sInfoFiltered": '<asp:Literal ID="oLanguage_sInfoFiltered" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sInfoFiltered%>' />',
                "sInfoPostFix": '<asp:Literal ID="oLanguage_sInfoPostFix" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sInfoPostFix%>' />',
                "sSearch": '<asp:Literal ID="oLanguage_sSearch" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sSearch%>' />',
                "sUrl": '<asp:Literal ID="oLanguage_sUrl" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sUrl%>' />',
                "sInfoThousands": '<asp:Literal ID="oLanguage_sInfoThousands" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sInfoThousands%>' />',
                "sLoadingRecords": '<asp:Literal ID="oLanguage_sLoadingRecords" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_sLoadingRecords%>' />',
                "oPaginate": {
                    "sFirst":  '<asp:Literal ID="oLanguage_oPaginate_sFirst" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_oPaginate_sFirst%>' />',
                    "sPrevious": '<asp:Literal ID="oLanguage_oPaginate_sPrevious" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_oPaginate_sPrevious%>' />',
                    "sNext": '<asp:Literal ID="oLanguage_oPaginate_sNext" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_oPaginate_sNext%>' />',
                    "sLast": '<asp:Literal ID="oLanguage_oPaginate_sLast" runat="server" Text='<%$ Resources:JQueryDataTable, oLanguage_oPaginate_sLast%>' />'
                },
                "fnInfoCallback": null,
                "oAria": {
                    "sSortAscending": '<asp:Literal ID="oAria_sSortAscending" runat="server" Text='<%$ Resources:JQueryDataTable, oAria_sSortAscending%>' />',
                    "sSortDescending": '<asp:Literal ID="oAria_sSortDescending" runat="server" Text='<%$ Resources:JQueryDataTable, oAria_sSortDescending%>' />'
                }
            },
            "aaData": datos,
            "aoColumns": [{ "sName": "GuidIndicador", "sTitle": "<asp:Literal ID="lblCabeceraGuidIndicador" runat="server" Text='<%$ Resources:SeguimientoMensualDeIndicadores, lblCabeceraGuidIndicador%>' />", "bSortable": true, "bVisible": false },
                          { "sName": "NombreServicioContratado", "sTitle": "<asp:Literal ID="lblCabeceraNombreServicioContratado" runat="server" Text='<%$ Resources:SeguimientoMensualDeIndicadores, lblCabeceraNombreServicioContratado%>' />", "bSortable": true, "bVisible": true, "sWidth" : "80px" },
                          { "sName": "Categoria", "sTitle": "<asp:Literal ID="lblCabeceraCategoria" runat="server" Text='<%$ Resources:SeguimientoMensualDeIndicadores, lblCabeceraCategoria%>' />", "bSortable": true, "bVisible": true, "sWidth" : "90px" },
                          { 
                            "sName": "NombreIndicador", 
                            "sTitle": "<asp:Literal ID="lblCabeceraIndicador" runat="server" Text='<%$ Resources:SeguimientoMensualDeIndicadores, lblCabeceraIndicador%>' />", 
                            "bSortable": true, 
                            "bVisible": true,
                            "sWidth" : "220px",
                            "fnRender": function (evolucionMensual) {
                                  return "<a href='IndicadoresProyecto.aspx?GuidIndicador=" + evolucionMensual.aData[0] + "&GuidServicioContratado=" + evolucionMensual.aData[9] + "'>" + evolucionMensual.aData[3] + "</a>";
                              }
                         },
                          { "sName": "Umbral", "sTitle": "<asp:Literal ID="lblCabeceraUmbral" runat="server" Text='<%$ Resources:SeguimientoMensualDeIndicadores, lblCabeceraUmbral%>' />", "bSortable": true, "bVisible": true, "sWidth" : "80px" },
                          { "sName": "Mes", "sTitle": "<asp:Literal ID="lblCabeceraMes" runat="server" Text='<%$ Resources:SeguimientoMensualDeIndicadores, lblCabeceraMes%>' />", "bSortable": true, "bVisible": false },
                          { "sName": "Anio", "sTitle": "<asp:Literal ID="lblCabeceraAnio" runat="server" Text='<%$ Resources:SeguimientoMensualDeIndicadores, lblCabeceraAnio%>' />", "bSortable": true, "bVisible": false },
                          { "sName": "ValorObjetivo", "sTitle": "<asp:Literal ID="lblCabeceraValorObjetivo" runat="server" Text='<%$ Resources:SeguimientoMensualDeIndicadores, lblCabeceraValorObjetivo%>' />", "bSortable": true, "bVisible": true, "sWidth" : "100px" },
                          { "sName": "ValorObtenido", "sTitle": "<asp:Literal ID="lblCabeceraValorObtenido" runat="server" Text='<%$ Resources:SeguimientoMensualDeIndicadores, lblCabeceraValorObtenido%>' />", "bSortable": true, "bVisible": true, "sWidth" : "100px" },
                          {
                              "sName": "Evolucion",
                              "sTitle": "Evolución",
                              "bSortable": true,
                              "bVisible": true,
                              "sWidth" : "80px",
                              "fnRender": function (evolucionMensual) {
                                  return "<a href='Indicadores_Evolucion.aspx?guidIndicador=" + evolucionMensual.aData[0] + "&mes=" + mes + "&anio=" + anio + "'><img src='/images/ico_grafica.png' width='16' height='15' alt='Evolución' /></a>";
                              }
                          }
                        ]
        });
    }

    function cargarTodosLosDatos() {
        var nombrePagina = conseguirNombreDeLaPagina();
        var nocache = new Date().getTime();
        var param = {
            "accion": "CargarTodosLosDatos",
            "nocache": nocache
        };

        $.getJSON(nombrePagina, param, function (returnData) {
            cargarDatosEnTabla(returnData);
        });
    }

    function seleccionarUltimoMesEnElDesplegable() {
        var anioSeleccionado = conseguirValorSeleccionadoEnCombo('anio');
        if(anioSeleccionado == ''){return;}
        var nombrePagina = conseguirNombreDeLaPagina();
        var nocache = new Date().getTime();
        var param = {
            "accion": "CargarMes",
            "nocache": nocache,
            "anioSeleccionado": anioSeleccionado
        };

        $.getJSON(nombrePagina, param, function (mes) {
            SeleccionarValorEnCombo('mes', mes);
            buscarDatos();
        });
    }

    function SeleccionarValorEnCombo(idCombo, valor) {
        var gestorCombo = new GestorCombo(idCombo);
        gestorCombo.seleccionarOption(valor);
    }

    function conseguirValorSeleccionadoEnCombo(idCombo) {
        var gestorCombo = new GestorCombo(idCombo);
        return gestorCombo.conseguirValorSeleccionado();
    }

    function cargarAniosEnElDesplegable(datos) {
        var gestorCombo = new GestorCombo('anio');
        for (var contador = 0; contador < datos.length; contador++) {
            if(datos[contador] != ''){
                gestorCombo.aniadirOption(new ComboOption(datos[contador], datos[contador]));
            }
        }
    }

    function cargarPagina() {
        var nombrePagina = conseguirNombreDeLaPagina();
        var nocache = new Date().getTime();
        var param = {
            "accion": "CargarAnios",
            "nocache": nocache
        };

        $.getJSON(nombrePagina, param, function (returnData) {
            cargarAniosEnElDesplegable(returnData);
            seleccionarUltimoMesEnElDesplegable();
        });
    }

    $(document).ready(function () {
        cargarPagina();
    });

</script>


<div class="divForm1" id="divFiltroIndicadores">
    <label for="anio">Año:</label>
    <select name="anio" id="anio"></select>
    <label for="mes" class="padLeft16">Mes:</label>
    <select name="mes" id="mes">
        <option VALUE="Enero">Enero</option>
        <option VALUE="Febrero">Febrero</option>
        <option VALUE="Marzo">Marzo</option>
        <option VALUE="Abril">Abril</option>
        <option VALUE="Mayo">Mayo</option>
        <option VALUE="Junio">Junio</option>
        <option VALUE="Julio">Julio</option>
        <option VALUE="Agosto">Agosto</option>
        <option VALUE="Septiembre">Septiembre</option>
        <option VALUE="Octubre">Octubre</option>
        <option VALUE="Noviembre">Noviembre</option>
        <option VALUE="Diciembre">Diciembre</option>
    </select>
    <input type="button" name="buscar" id="buscar" value="Buscar" class="btn" onclick="buscarDatos();" />
</div>
<table  id="tablaDatos" class="tablaDatos1" width="100%" border="0"></table>    
 

<asp:Label ID="lblInfo"  ForeColor="Red"  Visible="true" Text=""  runat="server"></asp:Label>
