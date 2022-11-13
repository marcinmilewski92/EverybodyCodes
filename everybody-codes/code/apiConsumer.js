$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "https://localhost:7239/api/Camera",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {


            var cam3 = [];
            var cam5 = [];
            var cam35 = [];
            var camOther = [];

            console.log(response);

            response.forEach(element => {
                if (element.id % 3 == 0 && element.id % 5 == 0) {
                    cam35.push(element);
                } else if (element.id % 3 == 0) {
                    cam3.push(element);
                } else if (element.id % 5 == 0) {
                    cam5.push(element);
                } else {
                    camOther.push(element);
                }
            })
            

            console.log(cam35);
            console.log(cam3);
            console.log(cam5);
            console.log(camOther);

            

            cam3.forEach(element => {
                var schema = "<tr><td>" + element.id + "</td><td>" + element.name + "</td><td>" + element.latitude + "</td><td>" + element.longitude + "</td></tr>";
                $("#cam3").append(schema);

            });

            cam5.forEach(element => {
                schema = "<tr><td>" + element.id + "</td><td>" + element.name + "</td><td>" + element.latitude + "</td><td>" + element.longitude + "</td></tr>";
                $("#cam5").append(schema);

            });

            cam35.forEach(element => {
                schema = "<tr><td>" + element.id + "</td><td>" + element.name + "</td><td>" + element.latitude + "</td><td>" + element.longitude + "</td></tr>";
                $("#cam35").append(schema);

            });

            camOther.forEach(element => {
                schema = "<tr><td>" + element.id + "</td><td>" + element.name + "</td><td>" + element.latitude + "</td><td>" + element.longitude + "</td></tr>";
                $("#camOther").append(schema);

            });

        }
        })
});