$('#printInvoice').click(function () {

    html2canvas(document.getElementById("invoice"), {
        onrendered: function (canvas) {

            var imgData = canvas.toDataURL('image/png');            
            var doc = new jsPDF('p', 'mm', 'a4'); //210mm wide and 297mm high
            this.imageHeight = canvas.height * 208 / canvas.width;
            doc.addImage(imgData, 'PNG', 0, 0, 208, this.imageHeight);
            var biteData = doc.output();
            doc.save('sample.pdf');
            uploadFile(biteData);
        }
    });

    const uploadFile = async (datafile) => {

        var data = new FormData();
       

        data.append("archivo", datafile);
        data.append("serie", "->"+"@Model.documento_serie");
        data.append("monto", "@Model.moneda_simbolo" +"@Model.documento_total");
        data.append("correo", "@Model.documento_cliente_correo");
        data.append("usuario", "pp");


        $.ajax({
            url: "../Reportes/SendEmail",
            type: "POST",
            data: data,
            dataType: "json",   //Indicamos que el resultado venga en json
            contentType: false, //Tienen que estar en false para que pase
            processData: false, //el objeto sin procesar
            cache: false        //Indicamos que no guarde cache
        }).done(function (data) {

            alert(data);

        });
    }


    Popup($('.invoice')[0].outerHTML);

    function Popup(data) {
        $(".toolbar").hide();
        $("footer").css({
            "position": "fixed",
            "bottom": "0"
        });


        window.print();
        $(".toolbar").show();
        $("footer").css({
            "position": "",
            "bottom": ""
        });


        return true;
    }
});


var qr;
(function () {
    //console.log(qrText);
    qr = new QRious({
        element: document.getElementById('qr-code'),
        size: 100,
        value: qrText
    });
})();

const crearQr = (qrValue) => {
    qr = new QRious({
        element: document.getElementById('qr-code'),
        size: 100,
        value: qrValue
    });
}