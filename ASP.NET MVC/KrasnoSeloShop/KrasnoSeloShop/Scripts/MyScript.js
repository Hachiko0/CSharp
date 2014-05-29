
//(function ShowImageOnClick() {
//    var images = $("li img");
//    for (var i = 0; i < images.length; i++) {
//        images[i].addEventListener("mouseover", Proba, false);
//    }
//}());

//function Proba() {
//    var src = $(this).attr('src');
//    var preview = $("#full-content-img");
//    $(preview).attr('src', src);
//}

var counter = 1;
var numberOfImages = 12;
(function ChangeLogoImage() {
    setInterval(Krasi, 4000);
}());

function Krasi() {
    if (counter === numberOfImages + 1) {
        counter = 1;
    }
    $("#welcome img").attr('src', "/Images/Main-logo/" + counter + ".JPG");
    counter++;
}