
const map = L.map('map').setView([52.0914, 5.1115], 13);

const tiles = L.tileLayer('https://tile.openstreetmap.org/{z}/{x}/{y}.png', {
    maxZoom: 19,
    attribution: '&copy; <a href="http://www.openstreetmap.org/copyright">OpenStreetMap</a>'
}).addTo(map);


$(document).ready(function () {
    $.ajax({
        type: "GET",
        url: "https://localhost:7239/api/Camera",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {


            
            response.forEach(element => {
                var marker = L.marker([element.latitude, element.longitude]).addTo(map).bindPopup(element.name).openPopup();
            });
        }
        })
});


