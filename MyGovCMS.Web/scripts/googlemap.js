function loadScript() {
    var script = document.createElement("script");
    script.src = "http://maps.googleapis.com/maps/api/js?key=&callback=initialize";
    document.body.appendChild(script);
}
window.onload = loadScript;
//Google Map
function initialize() {
    var mapProp = {
        center: new google.maps.LatLng(27.3179921, 88.6049938),
        zoom: 15,
        scrollwheel: false,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var mapDiv = document.getElementById('map_canvas');
    var map = new google.maps.Map(mapDiv, mapProp);

    var contentString = '<div id="content">' +
        '</div>' + '<div id="bodyContent">' + 'NetSpeq Solutions'
    '</div>' +
        '</div>';

    var infowindow = new google.maps.InfoWindow({
        content: contentString
    });

    var myLatLng = { lat: 27.3179921, lng: 88.6049938 };
    var marker = new google.maps.Marker({
        position: myLatLng,
        map: map,
        title: 'NetSpeq Solutions'
    });
    marker.addListener();

    map.set('styles', [
        {
            "featureType": "all",
            "elementType": "all",
            "stylers": [
                {
                    "invert_lightness": true
                },
                {
                    "saturation": 10
                },
                {
                    "lightness": 30
                },
                {
                    "gamma": 0.5
                },
                {
                    "hue": "#435158"
                }
            ]
        }


    ]);

}
    //Google Map end
