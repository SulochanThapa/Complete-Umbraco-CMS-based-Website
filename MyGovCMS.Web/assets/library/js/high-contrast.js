var manual_or_random = "manual" //"manual" or "random"
var randomsetting = "3 days" //"eachtime", "sessiononly", or "x days (replace x with desired integer)". Only applicable if mode is random.

//////No need to edit beyond here//////////////

function getCookie(Name) {
    var re = new RegExp(Name + "=[^;]+", "i"); //construct RE to search for target name/value pair
    if (document.cookie.match(re)) //if cookie found
        return document.cookie.match(re)[0].split("=")[1] //return its value
    return null
}

function setCookie(name, value, days) {
    var expireDate = new Date()
    //set "expstring" to either future or past date, to set or delete cookie, respectively
    var expstring = (typeof days != "undefined") ? expireDate.setDate(expireDate.getDate() + parseInt(days)) : expireDate.setDate(expireDate.getDate() - 5)
    document.cookie = name + "=" + value + "; expires=" + expireDate.toGMTString() + "; path=/";
}

function deleteCookie(name) {
    setCookie(name, "moot")
}

jQuery(document).ready(function () {

    jQuery('#menu-item-278 > a, #menu-item-194 > a, #menu-item-192 >  a').click(function () { return false; });

    jQuery('.dark').click(function () {

        var thirtyDays = 1000 * 60 * 60 * 24 * 30;
        var expireDate = new Date((new Date()).valueOf() + thirtyDays);

        document.cookie = 'contrast' + "=" + 1 + "; expires=" + expireDate.toGMTString() + "; path=/";
        document.cookie = "username=sk sbm";
        //var site_temp_uri = document.getElementById("site_url_js").value;
        $(".light").show();
        $(".dark").hide();
        jQuery('head').append('<link rel="stylesheet" type="text/css" media="screen" href="/assets/library/css/change.css">');
    });


    jQuery('.light').click(function () {
        var thirtyDays = 1000 * 60 * 60 * 24 * 30;
        var expireDate = new Date((new Date()).valueOf() + thirtyDays);

        document.cookie = 'contrast' + "=" + 0 + "; expires=" + expireDate.toGMTString() + "; path=/";

        $(".light").hide();
        $(".dark").show();

        jQuery("[href*='change.css']").remove();
    });

    if (getCookie('contrast') == "1") {
        //var site_temp_uri = document.getElementById("site_url_js").value;
        jQuery('head').append('<link rel="stylesheet" type="text/css" media="screen" href="/assets/library/css/change.css">');
    }

    if (getCookie('contrast') == "0") {
        jQuery("[href*='change.css']").remove();
    }

    if (getCookie('contrast') == 0 || getCookie('contrast') == null) {
        $(".light").hide();
        $(".dark").show();
    }
    else {
        $(".light").show();
        $(".dark").hide();
    }
});
