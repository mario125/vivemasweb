$('#printInvoice').click(function () {
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