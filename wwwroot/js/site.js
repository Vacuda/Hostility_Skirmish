// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


const activeTextarea = document.activeElement;

console.log(activeTextarea);

let clicked = "";



$('.char-card1').click(function () {
    $('.char-card1').css({
        'border': '2px solid red'

    });
    clicked = "#card-char-1"
    console.log(clicked)
    return clicked
});
$('.char-card2').click(function () {
    $('.char-card2').css({
        'border': '2px solid red'

    });
    clicked = "#card-char-2"
    console.log(clicked)
    return clicked
});
$('.char-card2').click(function () {
    $('.char-card2').css({
        'border': '2px solid red'

    });
    clicked = "#card-char-2"
    console.log(clicked)
    return clicked
});



// $('.char-card1').click(function () {
//     $('.char-card1').css({
//         'border': '2px solid red'

//     });
// });



$('#char-3').click(function () {
    $(clicked).prop('src', "/images/3.png");
});






//    $('#char-3').on({
//     'click': function(){
//         $('#card-char-1').attr('src','~/images/3.png');
//     }
// });