// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

let clicked = "";
let clickedCard = "";


// SELECT CARD
//-----------------------------
$('.char-card1').click(function () {
    $('.char-card1').css({
        'border': '2px solid red'
    });
    $(clickedCard).css({
        'border': 'none'
    });
    clickedCard = ".char-card1"
    clicked = "#card-char-1"
    console.log(clicked)
    return clicked
});

$('.char-card2').click(function () {
    $('.char-card2').css({
        'border': '2px solid red'
    });
    $(clickedCard).css({
        'border': 'none'
    });
    clickedCard = ".char-card2"
    clicked = "#card-char-2"
    console.log(clicked)
    return clicked
});
$('.char-card3').click(function () {
    $('.char-card3').css({
        'border': '2px solid red'
    });
    $(clickedCard).css({
        'border': 'none'
    });
    clickedCard = ".char-card3"
    clicked = "#card-char-3"
    console.log(clicked)
    return clicked
});
$('.char-card4').click(function () {
    $('.char-card4').css({
        'border': '2px solid red'
    });
    $(clickedCard).css({
        'border': 'none'
    });
    clickedCard = ".char-card4"
    clicked = "#card-char-4"
    console.log(clicked)
    return clicked
});
$('.char-card6').click(function () {
    $('.char-card6').css({
        'border': '2px solid red'
    });
    $(clickedCard).css({
        'border': 'none'
    });
    clickedCard = ".char-card6"
    clicked = "#card-char-6"
    console.log(clicked)
    return clicked
});
$('.char-card7').click(function () {
    $('.char-card7').css({
        'border': '2px solid red'
    });
    $(clickedCard).css({
        'border': 'none'
    });
    clickedCard = ".char-card7"
    clicked = "#card-char-7"
    console.log(clicked)
    return clicked
});




// SELECT CHAR-IMG
//-----------------------------

$('#char-1').click(function () {
    $(clicked).prop('src', "/images/1.png");
});
$('#char-2').click(function () {
    $(clicked).prop('src', "/images/2.png");
});
$('#char-3').click(function () {
    $(clicked).prop('src', "/images/3.png");
});
$('#char-4').click(function () {
    $(clicked).prop('src', "/images/4.png");
});
$('#char-6').click(function () {
    $(clicked).prop('src', "/images/6.png");
});
$('#char-7').click(function () {
    $(clicked).prop('src', "/images/7.png");
});
$('#char-8').click(function () {
    $(clicked).prop('src', "/images/8.png");
});
$('#char-9').click(function () {
    $(clicked).prop('src', "/images/9.png");
});
$('#char-8').click(function () {
    $(clicked).prop('src', "/images/8.png");
});
$('#char-9').click(function () {
    $(clicked).prop('src', "/images/9.png");
});
$('#char-10').click(function () {
    $(clicked).prop('src', "/images/10.png");
});
$('#char-11').click(function () {
    $(clicked).prop('src', "/images/11.png");
});

// --------------------------------------


$('#defense').click(function () {
    var defense = document.getElementById("defense").value;
    var totalDefense = document.getElementById("total-defense").textContent;
    var newDefense = parseInt(totalDefense) + parseInt(defense);

    console.log(totalDefense);
    console.log(defense);
    $("#total-defense").html(newDefense);
});

// --------------------------------------

$('#abil1').click(function () {
    $('#abilText').attr("value,Ability 1");
});






