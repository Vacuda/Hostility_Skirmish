
    // ***************************************
    // ***************************************
    // ***************************************

    let Char = "";
    let Tar = "";
    let Item = "";

    //from db
    let Team = getElementById("Team").innerHTML; //from html elements
    let gamestate_id = getElementById("gamestate_id").innerHTML;

    // PLAYER One
    // ---------------------------
    $('#P1Char1').click(function () {
        $('#P1Fight').prop('src', "/images/1.png");
        if (Char == "") {
            Char = "A1";
        }
        else {
            Tar = A1;
        }
    });
    $('#P1Char2').click(function () {
        $('#P1Fight').prop('src', "/images/2.png");
        if (Char == "") {
            Char = "A2";
        }
        else {
            Tar = "A2";
        }
    });
    $('#P1Char3').click(function () {
        $('#P1Fight').prop('src', "/images/3.png");
        if (Char == "") {
            Char = "A3";
        }
        else {
            Tar = "A3";
        }
    });
    $('#P1Char4').click(function () {
        $('#P1Fight').prop('src', "/images/4.png");
        if (Char == "") {
            Char = "A4";
        }
        else {
            Tar = "A4";
        }
    });
    $('#P1Char5').click(function () {
        $('#P1Fight').prop('src', "/images/6.png");
        if (Char == "") {
            Char = "A5";
        }
        else {
            Tar = "A5";
        }
    });


    // PLAYER TWO
    // ----------------------------
    $('#P2Char1').click(function () {
        $('#P2Fight').prop('src', "/images/1.png");
        if (Char == "") {
            Char = "B1";
        }
        else {
            Tar = "B1";
        }
    });
    $('#P2Char2').click(function () {
        $('#P2Fight').prop('src', "/images/2.png");
    if (Char == "") {
            Char = "B2";
        }
        else {
            Tar = "B2";
        }
    });
    $('#P2Char3').click(function () {
        $('#P2Fight').prop('src', "/images/3.png");
        if (Char == "") {
            Char = "B3";
        }
        else {
            Tar = "B3";
        }
    });
    $('#P2Char4').click(function () {
        $('#P2Fight').prop('src', "/images/4.png");
    if (Char == "") {
            Char = "B4";
        }
        else {
            Tar = "B4";
        }
    });
    $('#P2Char5').click(function () {
        $('#P2Fight').prop('src', "/images/6.png");
    if (Char == "") {
            Char = "B5";
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
            body: Team+":"+Char+":Attack:"+Tar //of the form xxx:xxx:xxx:xxx ex. A:1:Attack:B1
          })
            .then(response => {
                if (!response.ok) {
                    throw response;
                }
                return response.json();
            })
            .then(json => {
                console.log(json);
                json = JSON.parse(json);
                
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
      url = "/Game/character_action/"+gamestate_id;
      fetch(url, {
      headers: { "Content-Type": "application/json" },
      credentials: 'include'
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
                console.log(game_state.Parties[1].Characters[x].Health);
                for(var x=0; x<game_state.Parties[0].Characters.Length ;x++){ //for each character
                        console.log(game_state.Parties[0].Characters[x].Name);
                        var HealthHTMLId = "HealthP"+0+"C"+x;
                        getElementById(HealthHTMLId).innerHTML = game_state.Parties[1].Characters[x].Health;
                    }
            }else{ //Team == "B"
                for(var x=0; x<game_state.Parties[1].Characters.Length ;x++){ //for each character
                        console.log(game_state.Parties[1].Characters[x].Name);
                        var HealthHTMLId = "HealthP"+1+"C"+x;
                        getElementById(HealthHTMLId).innerHTML = game_state.Parties[1].Characters[x].Health;
                    }
            }
      })
      .catch(response => console.log(response));
    }, 2000);
    
