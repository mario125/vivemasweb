$('#printInvoice').click(function () {

    Popup($('.invoice')[0].outerHTML);

    function Popup(data) {
        $(".toolbar").hide();
        $("footer").css({
            "position": "fixed",
            "bottom": "0"
        });

        const filename = 'form.pdf';

        this.printElement = document.getElementById('invoice');

        html2canvas(this.printElement).then(canvas => {
            this.pdfData = new jsPDF('p', 'mm', 'a4');
            this.imageHeight = canvas.height * 208 / canvas.width;
            this.pdfData.addImage(canvas.toDataURL('image/png'), 'PNG', 0, 0, 208, this.imageHeight);
            this.pdfData.save(filename);
            var out = this.pdfData.output();
            //data:application/pdf;base64,
            uploadFile(btoa(out));
        });

        window.print();
        $(".toolbar").show();
        $("footer").css({
            "position": "",
            "bottom": ""
        });

        const uploadFile = async (datafile) => {


            var data = new FormData();

            data.append("archivo", datafile);

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

        //function uploadFile(datafile)async {
        //    var response = await axios.post('../Proyectos/cargarProyectos');

        //    const response = axios.post('../Reportes/SendEmail?base64=' + datafile +"&fechaEmision="+"jmuspeed@gmail.com");

        //    console.log("-------------------------------------------------------------------------------->" + response);
        //    console.log(datafile);
        //    console.log("-------------------------------------------------------------------------------->");
        //}
        return true;
    }
});


$('#printInvoicePDF').click(function () {
    const filename = 'form.pdf';
    const thisData = this;
    this.printElement = $('.invoice')[0].outerHTML;

    html2canvas(this.printElement).then(canvas => {
        this.pdfData = new jsPDF('p', 'mm', 'a4');
        //this.imageHeight = canvas.height * 208 / canvas.width;
        //this.pdfData.addImage(canvas.toDataURL('image/png'), 'PNG', 0, 0, 208, this.imageHeight);
        //this.pdfData.save(filename);
        //this.uploadFile(this.pdfData.output('blob'));
    });

    function uploadFile(datafile) {
        this.uploadService.uploadFile(datafile)
            .subscribe(
                (data) => {
                    if (data.responseCode === 200) {
                        //succesfully uploaded to back end server
                    }
                },
                (error) => {
                    //error occured
                }
            )
    }


});



async function asyncCall() {




    var d = document.querySelectorAll('#invoice');
    console.log(d);
    console.log(d[0]);


    // expected output: "resolved"
}



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