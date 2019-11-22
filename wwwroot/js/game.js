
    // ***************************************
    // ***************************************
    // ***************************************
    let Char = "";
    let Tar = "";
    let Item = "";

    //from db
    let Team = document.getElementById("Team").innerHTML; //from html elements
    let gamestate_id = document.getElementById("gamestate_id").innerHTML;


    // PLAYER One
    // ---------------------------
    
    let lava =  "";
    $('#P1Char1').click(function () {
        lava =  $('#charlineA1').prop('src')
        $('#P1Fight').prop('src', lava);
        if (Char == "") {
            Char = "1";
        }
        else {
            Tar = "A1";
        }
    });
    $('#P1Char2').click(function () {
        lava =  $('#charlineA2').prop('src')
        $('#P1Fight').prop('src', lava);
        if (Char == "") {
            Char = "2";
        }
        else {
            Tar = "A2";
        }
    });
    $('#P1Char3').click(function () {
        lava =  $('#charlineA3').prop('src')
        $('#P1Fight').prop('src', lava);
        if (Char == "") {
            Char = "3";
        }
        else {
            Tar = "A3";
        }
    });
    $('#P1Char4').click(function () {
        lava =  $('#charlineA4').prop('src')
        $('#P1Fight').prop('src', lava);
        if (Char == "") {
            Char = "4";
        }
        else {
            Tar = "A4";
        }
        // $('#P1Char4').css({
        // 'opacity': '0'
        // });
    });
    $('#P1Char5').click(function () {
        lava =  $('#charlineA5').prop('src')
        $('#P1Fight').prop('src', lava);
        if (Char == "") {
            Char = "5";
        }
        else {
            Tar = "A5";
        }
    });


    // PLAYER TWO
    // ----------------------------
    $('#P2Char1').click(function () {
        lava =  $('#charlineB1').prop('src')
        $('#P2Fight').prop('src', lava);
        if (Char == "") {
            Char = "1";
        }
        else {
            Tar = "B1";
        }
    });
    $('#P2Char2').click(function () {
        lava =  $('#charlineB2').prop('src')
        $('#P2Fight').prop('src', lava);
    if (Char == "") {
            Char = "2";
        }
        else {
            Tar = "B2";
        }
    });
    $('#P2Char3').click(function () {
        lava =  $('#charlineB3').prop('src')
        $('#P2Fight').prop('src', lava);
        if (Char == "") {
            Char = "3";
        }
        else {
            Tar = "B3";
        }
    });
    $('#P2Char4').click(function () {
        lava =  $('#charlineB4').prop('src')
        $('#P2Fight').prop('src', lava);
    if (Char == "") {
            Char = "4";
        }
        else {
            Tar = "B4";
        }

    // $('#P2Char4').css({
    //     'display': 'none'
    // });
    });
    $('#P2Char5').click(function () {
        lava =  $('#charlineB5').prop('src')
        $('#P2Fight').prop('src', lava);
    if (Char == "") {
            Char = "5";
        }
        else {
            Tar = "B5";
        }
    });

    // Actions
    // -------------------------------
    $('#game-attack').click(function () { //attack option
        fetch("/Game/character_action/"+gamestate_id, { 
            headers: { "Content-Type": "application/json" },
            credentials: 'include',
            method: "POST",
            body: Team+":"+Char+":Attack:"+Tar //of the form xxx:xxx:xxx:xxx ex. 
          })
            .then(response => {
                if (!response.ok) {
                    throw response;
                }
                return response.json();
            })
            .then(json => {
                console.log(json);
                console.log(Team+":"+Char+":Attack:"+Tar)
                json = JSON.parse(json);
                Char = "";
                Tar = "";
            })
            .catch(response => console.log(response));
            
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

    
    
    setInterval(function() //get data from database
    { 
      url = "/Game/getstate/"+gamestate_id;
      fetch(url, {
      headers: { "Content-Type": "application/json" },
      credentials: 'include',
      method: "GET"
    })
      .then(response => {
          if (!response.ok) {
              throw response;
          }
          return response.json();
      })
      .then(json => { //main game loop
            if (Team == "A"){
                game_state = JSON.parse(json);
                var HealthHTMLId = "HealthP0C0";
                document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[0].Characters[0].Health;
                //console.log(game_state.Parties[0].Characters[0].Health);
                var HealthHTMLId = "HealthP0C1";
                document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[0].Characters[1].Health;
                //console.log(game_state.Parties[0].Characters[1].Health);
                var HealthHTMLId = "HealthP0C2";
                document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[0].Characters[2].Health;
                //console.log(game_state.Parties[0].Characters[2].Health);
                var HealthHTMLId = "HealthP0C3";
                document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[0].Characters[3].Health;
                //console.log(game_state.Parties[0].Characters[3].Health);
                var HealthHTMLId = "HealthP0C4";
                document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[0].Characters[4].Health;
                //console.log(game_state.Parties[0].Characters[4].Health);
                // document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[0].Characters[x].Health;
                // document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[1].Characters[x].Health;
                // document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[1].Characters[x].Health;
                // document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[1].Characters[x].Health;
                // document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[1].Characters[x].Health;

                for(var x=0; x<game_state.Parties[0].Characters.Length ;x++){ //for each character
                        console.log(game_state.Parties[0].Characters[x].Avatar_Name);
                        var HealthHTMLId = "HealthP"+0+"C"+x;
                        document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[1].Characters[x].Health;
                    }
            }else{ //Team == "B"
                // for(var x=0; x<game_state.Parties[1].Characters.Length ;x++){ //for each character
                //         console.log(game_state.Parties[1].Characters[x].Name);
                //         var HealthHTMLId = "HealthP"+1+"C"+x;
                //         document.getElementById(HealthHTMLId).innerHTML = game_state.Parties[1].Characters[x].Health;
                //     }
            }
      })
      .catch(response => console.log(response));
    }, 7000);
    
