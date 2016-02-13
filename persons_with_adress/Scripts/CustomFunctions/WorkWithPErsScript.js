function AddPerson() {
    $("#myModal").modal();
    $.ajax({
        method: "GET",
        url: '/User/ModalCreate',
        success: function (result) {
            $("#bodyModal").html(result);
        }
    })
};

function EditPersonResult(id) {
    $("#myModal").modal();

    $.ajax({
        method: "GET",
        url: '/User/EditPerson',
        data: { "id": id },
        success: function (result) {
            $("#bodyModal").html(result);
        }
    })
};

function ShowUserProf(id) {
    $("#myModal").modal();

    $.ajax({
        method: "GET",
        url: '/UserProfile/Index',
        data: { "id": id },
        success: function (result) {
            $("#bodyModal").html(result);
        }
    })
};


var map;
function initMap() {
    map = new google.maps.Map(document.getElementById('map'), {
        center: { lat: -34.397, lng: 150.644 },
        zoom: 8
    });

    $('input[name="add_address"]').on("click", function () {

        var address = $("#text").val();

        var geocoder = geocoder = new google.maps.Geocoder();
        geocoder.geocode({ 'address': address }, function (results, status) {
            if (status == google.maps.GeocoderStatus.OK) {
                map.setCenter(results[0].geometry.location);
                var marker = new google.maps.Marker({
                    map: map,
                    position: results[0].geometry.location
                });
                if (results[0]) {
                    alert("Location: " + results[0].formatted_address);
                }
            }

        })



    });

}