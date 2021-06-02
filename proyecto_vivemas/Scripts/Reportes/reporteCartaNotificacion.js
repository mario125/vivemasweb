$(document).ready(() => {

    obtenerReporte();  

});


const obtenerReporte = async () => {

    $('#maintable').DataTable({
        "processing": true,
        "serverSide": true,
        "ajax": {
            "url": "getCuotasVencidas",
            "type": "POST"
        },
        "columns": [
            { "data": "first_name" },
            { "data": "last_name" },
            { "data": "position" },
            { "data": "office" },
            { "data": "start_date" },
            { "data": "salary" }
        ]
    }

    //console.log("...................");
    //const response = await axios.post('getCuotasVencidas', null, {
    //    headers: {
    //        'Content-Type': 'application/json'
    //    }
    //});

    //console.log(response);

    //if (response.data.Data.flag == 1) {

    //    var reporteCuerpo = '';
        
    //    console.log(response.data);
      
    //    $('#maintable').DataTable({
    //        "ajax": response.data
    //        });
   



    //    //response.data.Data.dataReporte.forEach((item) => {
    //    //    reporteCuerpo +=
    //    //        '<tr>' +
    //    //        '<td> Nicole Medina</td>' +
    //    //        '<td> Cost Accountant</td>' +
    //    //        '<td> Obigarm</td>' +
    //    //        '<td> 48</td>' +
    //    //        '<td> 12/01/2016</td>' +
    //    //        '<td> $72480.01</td>' +
    //    //        '<td><button type="button" class="btn btn-default">Default</button></td>' +
    //    //        ' </tr>';
    //    //});
    //   //$("#tbodyReporte").html('').append(reporteCuerpo);

    //} else {
    //    toastr["error"]("ocurrio un error en el sistema, comuniquese con el area de sistemas");
    //}



}
