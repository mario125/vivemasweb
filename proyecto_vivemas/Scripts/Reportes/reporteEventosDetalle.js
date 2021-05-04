document.getElementById('formReporteEventosDetalle').addEventListener('submit', (event) => {
    event.preventDefault();
    obtenerReporte();

    
});

$("#inputDocumentoCliente").autocomplete({
    source: function (request, response) {
        $.getJSON("../Clientes/buscarClientesContrato",
            {
                term: request.term,
                param1: $('#selectProyecto').select2('data')[0].id
            },
            response
        );
    },
    delay: 300,
    select: (event, ui) => {
        document.querySelector("#inputNroContrato").value = ui.item.numeracion;
        document.querySelector("#inputIdContrato").value = ui.item.id;
        document.querySelector("#inputLote").value = ui.item.lote;
    }
});




const obtenerReporte = async () => {

    alert(document.querySelector("#inpucode").value);


    if (document.querySelector("#inpucode").value == "") {
        toastr["warning"]("Debe buscar un cliente primero");
    } else {
        const response = await axios.post('obtenerReporteEventosDetalle?codigo=' + document.querySelector("#inpucode").value);
        console.log("--------------------------");
        console.log(response);
        console.log("--------------------------");

        if (response.data.flag == 1) {
            document.getElementById('buttonEmitirReportePDF').disabled = false;
            document.getElementById('buttonEmitirReporteXLS').disabled = false;
            var reporteCabecera = '';
            var reporteCuerpo = '';
            reporteCabecera += '<tr>' +
                '<th data-fill-color="3399ff" data-f-color="ebedef" class="bg-info">PROYECTO</th>' +
                '<th data-fill-color="3399ff" data-f-color="ebedef" class="bg-info">LOTE</th>' +
                '<th data-fill-color="3399ff" data-f-color="ebedef" class="bg-info">N° DOCUMENTO</th>' +
                '<th data-fill-color="3399ff" data-f-color="ebedef" class="bg-info">CLIENTE</th>' +
                '<th data-fill-color="3399ff" data-f-color="ebedef" class="bg-info">F. CREACION</th>' +
                '<th data-fill-color="3399ff" data-f-color="ebedef" class="bg-info">F. PROPUESTA</th>' +
                '<th data-fill-color="3399ff" data-f-color="ebedef" class="bg-info">MONTO PROPUESTO</th>' +
                '<th data-fill-color="3399ff" data-f-color="ebedef" class="bg-info">DESCRIPCION</th>' +
                '<th data-fill-color="3399ff" data-f-color="ebedef" class="bg-info">ESTADO</th>' +
                '<th data-fill-color="3399ff" data-f-color="ebedef" class="bg-info">TIPO CONTACTO</th>' +
                '</tr>';
            $("#theadReporte").html('').append(reporteCabecera);
            response.data.dataReporte.forEach((item) => {
                reporteCuerpo += '<tr>' +
                    '<td>' + item.proyecto_nombrecorto + '</td>' +
                    '<td>' + item.cotizacion_lote_nombre + '</td>' +
                    '<td>' + item.proformauif_cliente_nrodocumento + '</td>' +
                    '<td>' + item.proformauif_cliente_razonsocial + '</td>' +
                    '<td>' + item.evento_fechacreacion + '</td>' +
                    '<td>' + item.evento_fechapropuesta + '</td>' +
                    '<td>' + item.evento_montopropuesto + '</td>' +
                    '<td>' + item.evento_descripcion + '</td>' +
                    '<td>' + item.estadoevento_descripcion + '</td>' +
                    '<td>' + item.tipocontacto_descripcion + '</td>' +
                    '</tr>'
            });
            $("#tbodyReporte").html('').append(reporteCuerpo);
        } else {
            toastr["error"]("ocurrio un error en el sistema, comuniquese con el area de sistemas");
        }

        
    }
}


document.getElementById('buttonEmitirReportePDF').addEventListener("click", (e) => {
    const doc = new jsPDF({
        orientation: "landscape",
        unit: "in",
        format: [1000, 792]
    });
    doc.autoTable({
        html: '#tableReporte',
        showHead: 'firstPage',
        showFoot: 'lastPage'
    });
    doc.save('reporteEventos.pdf');
});

document.getElementById('buttonEmitirReporteXLS').addEventListener("click", (e) => {
    TableToExcel.convert(document.getElementById("tableReporte"), {
        name: "reporteEventos.xlsx",
        sheet: {
            name: "Reporte"
        }
    });
});