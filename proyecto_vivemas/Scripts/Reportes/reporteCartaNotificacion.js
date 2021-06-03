$(document).ready(function () {

    var table = $('#maintable').DataTable({

        "ajax": {
            "url": "getCuotasVencidas",
            "type": "POST"
        },
        "columns": [
            { "data": "contrato_numeracion" },
            { "data": "proyecto_nombre" },
            { "data": "lote_nombre" },
            { "data": "proformauif_cliente_razonsocial" },
            { "data": "proformauif_cliente_nrodocumento" },
            { "data": "montopendiente" },
            { "data": "montocancelado" },
            { "data": "cuotas_vencidas" },
            {
                "data": function (data, type, row) {
                    if (data.cuotas_vencidas >= 3) {
                        return '<button type="button" class="btn btn-success"  onclick="abrirModalEdicionTransaccion(' + data.cuota_anexocontratocotizacion_id + ') ">Notificar</button>'
                    } else {
                        return ''
                    }

                }
            }

        ],
        "dom": 'Bfrtip',
        "buttons": [
            'copy', 'csv', 'excel', 'pdf', 'print'
        ]

    });

    $('#maintable tfoot th').each(function () {
        var title = $('#maintable tfoot th').eq($(this).index()).text();
        $(this).html('<input type="text" placeholder="Search ' + title + '" />');
    });

    table.columns().eq(0).each(function (colIdx) {
        $('input', table.column(colIdx).footer()).on('keyup change', function () {
            table
                .column(colIdx)
                .search(this.value)
                .draw();
        });
    });
});

const abrirModalEdicionTransaccion = (transaccionId) => {
    var valor = prompt("Porcenta de penalidad ", "");
    if (valor != '') {
        window.open('../Reportes/EmitirCartaNotificacion?penalidad=' + valor + '&id=' + transaccionId, '_blank');
        setTimeout(() => { location.reload(); }, 3000);
    } else {
        toastr["error"]("Se requiere el porcenta de penalidad");
    }
    
}