// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// $('#P1Char1').click(function () {
//     $('#P1Fight').prop('src', "/images/4.png");
// });

let clicked = "";
let clicked2 = "";
let clicked3 = "";
let clicked4 = "";
let clickedCard = "";
let newDefense1 = 0;
let newDefense2 = 0;
let newDefense3 = 0;
let check = 0;
function CheckItem() {


    if (!$('#abilText1').val() || !$('#abilText2').val() || !$('#abilText3').val() || !$('#abilText4').val() || !$('#abilText5').val()) {
        check = 0
    }
    else {
        check = 1
    }

    if (!$('#ItemText1').val() || !$('#ItemText2').val() || !$('#ItemText3').val() || !$('#ItemText4').val() || !$('#ItemText5').val()) {
        check = 0
    }
    else {
        check = 1
    }
    return check

}



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
    clicked2 = "#abilText1"
    clicked3 = "#ItemText1"
    clicked4 = "#char-name1"
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
    clicked2 = "#abilText2"
    clicked3 = "#ItemText2"
    clicked4 = "#char-name2"
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
    clicked2 = "#abilText3"
    clicked3 = "#ItemText3"
    clicked4 = "#char-name3"
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
    clicked2 = "#abilText4"
    clicked3 = "#ItemText4"
    clicked4 = "#char-name4"
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
    clicked2 = "#abilText5"
    clicked3 = "#ItemText5"
    clicked4 = "#char-name5"
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
    clicked2 = "#abilText5"
    clicked3 = "#ItemText5"
    console.log(clicked)
    return clicked
});

//HANDLING PLAYER STATISTICS
// --------------------------------------
$('#check-btn').click(function () {
    var defense1 = document.getElementById("DefenseText1").value;
    var defense2 = document.getElementById("DefenseText2").value;
    var defense3 = document.getElementById("DefenseText3").value;
    var defense4 = document.getElementById("DefenseText4").value;
    var defense5 = document.getElementById("DefenseText5").value;
    var totalDefense = document.getElementById("total-defense").textContent;
    newDefense1 = parseInt(defense1) + parseInt(defense2) + parseInt(defense3) + parseInt(defense4) + parseInt(defense5);
    if (newDefense1 == 10) {
        $('#LbDefense').css({
            'color': 'green',
            'font-weight': 'bold',
        });
    }
    else {
        $('#LbDefense').css({
            'color': 'red',
            'font-weight': 'bold',
        });
    }
    $("#total-defense").html(10 - newDefense1);
    return newDefense1
});
$('#check-btn').click(function () {
    var health1 = document.getElementById("HealthText1").value;
    var health2 = document.getElementById("HealthText2").value;
    var health3 = document.getElementById("HealthText3").value;
    var health4 = document.getElementById("HealthText4").value;
    var health5 = document.getElementById("HealthText5").value;
    var totalDefense = document.getElementById("total-health").textContent;
    newDefense2 = parseInt(health1) + parseInt(health2) + parseInt(health3) + parseInt(health4) + parseInt(health5);
    if (newDefense2 == 250) {
        $('#LbHealth').css({
            'color': 'green',
            'font-weight': 'bold',
        });
    }
    else {
        $('#LbHealth').css({
            'color': 'red',
            'font-weight': 'bold',
        });
    }
    $("#total-health").html(250 - newDefense2);
    return newDefense2
});
$('#check-btn').click(function () {
    var attack1 = document.getElementById("AttackText1").value;
    var attack2 = document.getElementById("AttackText2").value;
    var attack3 = document.getElementById("AttackText3").value;
    var attack4 = document.getElementById("AttackText4").value;
    var attack5 = document.getElementById("AttackText5").value;
    var totalDefense = document.getElementById("total-attack").textContent;
    newDefense3 = parseInt(attack1) + parseInt(attack2) + parseInt(attack3) + parseInt(attack4) + parseInt(attack5);
    if (newDefense3 == 15) {
        $('#LbAttack').css({
            'color': 'green',
            'font-weight': 'bold',
        });
    }
    else {
        $('#LbAttack').css({
            'color': 'red',
            'font-weight': 'bold',
        });
    }
    $("#total-attack").html(15 - newDefense3);
    return newDefense3
});

$('#check-btn').click(function () {
    var totalBuild = newDefense1 + newDefense2 + newDefense3
    console.log(totalBuild)
    CheckItem();
    console.log(CheckItem())
    if (275 - totalBuild == 0 && check == 1) {
        $("#build-btn").css({
            'display': 'block'

        });
        $("#check-btn").css({
            'display': 'none'

        });
        $("#edit-btn").css({
            'display': 'block'

        });

        $("input").prop("readonly", true);
    }
});
$('#edit-btn').click(function () {
    var totalBuild = newDefense1 + newDefense2 + newDefense3
    console.log(totalBuild)
    if (275 - totalBuild == 0) {
        $("#build-btn").css({
            'display': 'none'

        });
        $("#check-btn").css({
            'display': 'block'

        });
        $("#edit-btn").css({
            'display': 'none'

        });
        $("input").prop("readonly", false);
    }
});



// ADD CHAR IMG TO CLICK CARD
//-----------------------------
$('#char-1').click(function () {
    $(clicked4).html("Brian");
    $(clicked).prop('src', "/images/1.png");
});
$('#char-2').click(function () {
    $(clicked4).html("Yarn");

    $(clicked).prop('src', "/images/2.png");
});
$('#char-3').click(function () {
    $(clicked4).html("Amber");

    $(clicked).prop('src', "/images/3.png");
});
$('#char-4').click(function () {
    $(clicked4).html("Scott");

    $(clicked).prop('src', "/images/4.png");
});
$('#char-6').click(function () {
    $(clicked4).html("Chris");

    $(clicked).prop('src', "/images/6.png");
});
$('#char-7').click(function () {
    $(clicked4).html("Brandon");



    $(clicked).prop('src', "/images/7.png");
});
$('#char-8').click(function () {
    $(clicked4).html("Adam");

    $(clicked).prop('src', "/images/8.png");
});
$('#char-9').click(function () {
    $(clicked4).html("Patty");

    $(clicked).prop('src', "/images/9.png");
});
// $('#char-8').click(function () {
//     $(clicked4).html("Steve");

//     $(clicked).prop('src', "/images/8.png");
// });
// $('#char-9').click(function () {
//     $(clicked4).html("Andy");

//     $(clicked).prop('src', "/images/9.png");
// });
$('#char-10').click(function () {
    $(clicked4).html("Steve");

    $(clicked).prop('src', "/images/10.png");
});
$('#char-11').click(function () {
    $(clicked4).html("Andy");

    $(clicked).prop('src', "/images/11.png");
});
$('#char-12').click(function () {
    $(clicked4).html("Chuck");

    $(clicked).prop('src', "/images/12.png");
});
$('#char-13').click(function () {
    $(clicked4).html("Adrien");

    $(clicked).prop('src', "/images/13.png");
});

// ADD ABILITY TO CLICK CARD
// --------------------------------------
$('#abil1').click(function () {
    var text = document.getElementById("abil1").getElementsByTagName('p')[0].textContent;
    console.log(text)
    $(clicked2).attr("value", text);
});
$('#abil2').click(function () {
    var text = document.getElementById("abil2").getElementsByTagName('p')[0].textContent;
    $(clicked2).attr("value", text);
});
$('#abil3').click(function () {
    var text = document.getElementById("abil3").getElementsByTagName('p')[0].textContent;
    $(clicked2).attr("value", text);
});
$('#abil4').click(function () {
    var text = document.getElementById("abil4").getElementsByTagName('p')[0].textContent;
    $(clicked2).attr("value", text);
});
$('#abil5').click(function () {
    var text = document.getElementById("abil5").getElementsByTagName('p')[0].textContent;
    $(clicked2).attr("value", text);
});
$('#abil6').click(function () {
    var text = document.getElementById("abil6").getElementsByTagName('p')[0].textContent;
    $(clicked2).attr("value", text);
});
$('#abil7').click(function () {
    var text = document.getElementById("abil7").getElementsByTagName('p')[0].textContent;
    $(clicked2).attr("value", text);
});
$('#abil8').click(function () {
    var text = document.getElementById("abil8").getElementsByTagName('p')[0].textContent;
    $(clicked2).attr("value", text);
});
$('#abil9').click(function () {
    var text = document.getElementById("abil9").getElementsByTagName('p')[0].textContent;
    $(clicked2).attr("value", text);
});
$('#abil10').click(function () {
    var text = document.getElementById("abil10").getElementsByTagName('p')[0].textContent;
    $(clicked2).attr("value", text);
});


// ADD ITEM TO CLICK CARD
// --------------------------------------
$('#item1').click(function () {
    var text = document.getElementById("abil1").getElementsByTagName('p')[0].textContent;
    $(clicked3).attr("value", text);
});
$('#item2').click(function () {
    $(clicked3).attr("value", "Item 2");
});
$('#item3').click(function () {
    $(clicked3).attr("value", "Item 3");
})
$('#item4').click(function () {
    $(clicked3).attr("value", "Item 4");
});
$('#item5').click(function () {
    $(clicked3).attr("value", "Item 5");
});


// ***************************************
// ***************************************
// ***************************************
// ***************************************
// ***************************************
// ***************************************


let Char = ""
let Tar = ""
let Item = ""
// PLAYER One
// ---------------------------
$('#P1Char1').click(function () {
    $('#P1Fight').prop('src', "/images/1.png");
    if (Char == "") {
        Char = A1;
    }
    else {
        Tar = A1;
    }
});
$('#P1Char2').click(function () {
    $('#P1Fight').prop('src', "/images/2.png");
    if (Char == "") {
        Char = A2;
    }
    else {
        Tar = A2;
    }
});
$('#P1Char3').click(function () {
    $('#P1Fight').prop('src', "/images/3.png");
    if (Char == "") {
        Char = A3;
    }
    else {
        Tar = A3;
    }
});
$('#P1Char4').click(function () {
    $('#P1Fight').prop('src', "/images/4.png");
    if (Char == "") {
        Char = A4;
    }
    else {
        Tar = A4;
    }
});
$('#P1Char5').click(function () {
    $('#P1Fight').prop('src', "/images/6.png");
    if (Char == "") {
        Char = A5;
    }
    else {
        Tar = A5;
    }
});


// PLAYER TWO
// ----------------------------
$('#P2Char1').click(function () {
    $('#P2Fight').prop('src', "/images/1.png");
    if (Char == "") {
        Char = B1;
    }
    else {
        Tar = B1;
    }
});
$('#P2Char2').click(function () {
    $('#P2Fight').prop('src', "/images/2.png");
   if (Char == "") {
        Char = B2;
    }
    else {
        Tar = B2;
    }
});
$('#P2Char3').click(function () {
    $('#P2Fight').prop('src', "/images/3.png");
    if (Char == "") {
        Char = B3;
    }
    else {
        Tar = B3;
    }
});
$('#P2Char4').click(function () {
    $('#P2Fight').prop('src', "/images/4.png");
  if (Char == "") {
        Char = B4;
    }
    else {
        Tar = B4;
    }
});
$('#P2Char5').click(function () {
    $('#P2Fight').prop('src', "/images/6.png");
   if (Char == "") {
        Char = B5;
    }
    else {
        Tar = B5;
    }
});

// ITEM
// -------------------------------
$('#game-attack').click(function () {
// Set Variable
});
$('#game-defend').click(function () {
// Set Variable
});
$('#game-ability').click(function () {
// Set Variable
});
$('#game-item').click(function () {
// Set Variable
});










