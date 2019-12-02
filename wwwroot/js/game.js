  //See APIREADME.txt for more information
  
    let Char = "";
    let Tar = "";
    let Item = "";
    //[[party[0]character[0], party[1]character[0], ...]
    let dead_bools = [[0,0],[0,0],[0,0],[0,0],[0,0]]; // 0 for alive 1 for dead

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
        $('#P1Char1').css({
        'opacity': '0'
        });
        $('#P1Char2').css({
        'opacity': '1'
        });
        $('#P1Char3').css({
        'opacity': '1'
        });
        $('#P1Char4').css({
        'opacity': '1'
        });
        $('#P1Char5').css({
        'opacity': '1'
        });
     
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
        $('#P1Char1').css({
        'opacity': '1'
        });
        $('#P1Char2').css({
        'opacity': '0'
        });
        $('#P1Char3').css({
        'opacity': '1'
        });
        $('#P1Char4').css({
        'opacity': '1'
        });
        $('#P1Char5').css({
        'opacity': '1'
        })
    
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
        $('#P1Char1').css({
        'opacity': '1'
        });
        $('#P1Char2').css({
        'opacity': '1'
        });
        $('#P1Char3').css({
        'opacity': '0'
        });
        $('#P1Char4').css({
        'opacity': '1'
        });
        $('#P1Char5').css({
        'opacity': '1'
        })
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
        $('#P1Char1').css({
        'opacity': '1'
        });
        $('#P1Char2').css({
        'opacity': '1'
        });
        $('#P1Char3').css({
        'opacity': '1'
        });
        $('#P1Char4').css({
        'opacity': '0'
        });
        $('#P1Char5').css({
        'opacity': '1'
        })
      
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
        $('#P1Char1').css({
        'opacity': '1'
        });
        $('#P1Char2').css({
        'opacity': '1'
        });
        $('#P1Char3').css({
        'opacity': '1'
        });
        $('#P1Char4').css({
        'opacity': '1'
        });
        $('#P1Char5').css({
        'opacity': '0'
        })
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
        $('#P2Char1').css({
        'opacity': '0'
        });
        $('#P2Char2').css({
        'opacity': '1'
        });
        $('#P2Char3').css({
        'opacity': '1'
        });
        $('#P2Char4').css({
        'opacity': '1'
        });
        $('#P2Char5').css({
        'opacity': '1'
        })
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
        $('#P2Char1').css({
        'opacity': '1'
        });
        $('#P2Char2').css({
        'opacity': '0'
        });
        $('#P2Char3').css({
        'opacity': '1'
        });
        $('#P2Char4').css({
        'opacity': '1'
        });
        $('#P2Char5').css({
        'opacity': '1'
        })
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
        $('#P2Char1').css({
        'opacity': '1'
        });
        $('#P2Char2').css({
        'opacity': '1'
        });
        $('#P2Char3').css({
        'opacity': '0'
        });
        $('#P2Char4').css({
        'opacity': '1'
        });
        $('#P2Char5').css({
        'opacity': '1'
        })
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
        $('#P2Char1').css({
        'opacity': '1'
        });
        $('#P2Char2').css({
        'opacity': '1'
        });
        $('#P2Char3').css({
        'opacity': '1'
        });
        $('#P2Char4').css({
        'opacity': '0'
        });
        $('#P2Char5').css({
        'opacity': '1'
        })


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
        $('#P2Char1').css({
        'opacity': '1'
        });
        $('#P2Char2').css({
        'opacity': '1'
        });
        $('#P2Char3').css({
        'opacity': '1'
        });
        $('#P2Char4').css({
        'opacity': '1'
        });
        $('#P2Char5').css({
        'opacity': '0'
        })
    });

    function ResetPlayerLocations(){

        $('#P1Fight').prop('src', "");
        $('#P2Fight').prop('src', "");

        $('#P1Char1').css({
        'opacity': '1'
        });
        $('#P1Char2').css({
        'opacity': '1'
        });
        $('#P1Char3').css({
        'opacity': '1'
        });
        $('#P1Char4').css({
        'opacity': '1'
        });
        $('#P1Char5').css({
        'opacity': '1'
        });
        
        $('#P2Char1').css({
        'opacity': '1'
        });
        $('#P2Char2').css({
        'opacity': '1'
        });
        $('#P2Char3').css({
        'opacity': '1'
        });
        $('#P2Char4').css({
        'opacity': '1'
        });
        $('#P2Char5').css({
        'opacity': '1'
        });
    };

    // Actions
    // -------------------------------
    $('#game-attack').click(function () { //attack option

        //reset player locations
        ResetPlayerLocations();

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

    $('#game-ability').click(function () {
        fetch("/Game/character_action/"+gamestate_id, { 
            headers: { "Content-Type": "application/json" },
            credentials: 'include',
            method: "POST",
            body: Team+":"+Char+":Ability:"+Tar //of the form xxx:xxx:xxx:xxx ex. 
          })
            .then(response => {
                if (!response.ok) {
                    throw response;
                }
                return response.json();
            })
            .then(json => {
                // console.log(json);
                console.log(Team+":"+Char+":Ability:"+Tar)
                json = JSON.parse(json);
                Char = "";
                Tar = "";
            })
            .catch(response => console.log(response));
    });
    $('#game-item').click(function () {
        fetch("/Game/character_action/"+gamestate_id, { 
            headers: { "Content-Type": "application/json" },
            credentials: 'include',
            method: "POST",
            body: Team+":"+Char+":Item:"+Tar //of the form xxx:xxx:xxx:xxx ex. 
          })
            .then(response => {
                if (!response.ok) {
                    throw response;
                }
                return response.json();
            })
            .then(json => {
                console.log(json);
                console.log(Team+":"+Char+":Item:"+Tar)
                json = JSON.parse(json);
                Char = "";
                Tar = "";
            })
            .catch(response => console.log(response));
    });
    $('#game-defend').click(function () {
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
                game_state = JSON.parse(json);

            //set turn
                if (Team == game_state.CurrentTeam){
                    document.getElementById("whoseturn").innerHTML = "<h1 class='yourturn'>Your Turn!</h1>"
                }
                else{
                    document.getElementById("whoseturn").innerHTML = "<h1 class='notyourturn'>It is not your turn!</h1>"
                }
                // Team = game_state.CurrentTeam

            //read health values                   
                document.getElementById("HealthP0C0").innerHTML = game_state.Parties[0].Characters[0].Health;
                document.getElementById("HealthP0C1").innerHTML = game_state.Parties[0].Characters[1].Health;                
                document.getElementById("HealthP0C2").innerHTML = game_state.Parties[0].Characters[2].Health;                
                document.getElementById("HealthP0C3").innerHTML = game_state.Parties[0].Characters[3].Health;            
                document.getElementById("HealthP0C4").innerHTML = game_state.Parties[0].Characters[4].Health;
                document.getElementById("HealthP1C0").innerHTML = game_state.Parties[1].Characters[0].Health;
                document.getElementById("HealthP1C1").innerHTML = game_state.Parties[1].Characters[1].Health;
                document.getElementById("HealthP1C2").innerHTML = game_state.Parties[1].Characters[2].Health;
                document.getElementById("HealthP1C3").innerHTML = game_state.Parties[1].Characters[3].Health;
                document.getElementById("HealthP1C4").innerHTML = game_state.Parties[1].Characters[4].Health;

            
            //read avatar images
                document.getElementById("charlineA1").src       = game_state.Parties[0].Characters[0].Avatar_Image;
                document.getElementById("charlineA2").src       = game_state.Parties[0].Characters[1].Avatar_Image;
                document.getElementById("charlineA3").src       = game_state.Parties[0].Characters[2].Avatar_Image;
                document.getElementById("charlineA4").src       = game_state.Parties[0].Characters[3].Avatar_Image;
                document.getElementById("charlineA5").src       = game_state.Parties[0].Characters[4].Avatar_Image;
                document.getElementById("charlineB1").src       = game_state.Parties[1].Characters[0].Avatar_Image;
                document.getElementById("charlineB2").src       = game_state.Parties[1].Characters[1].Avatar_Image;
                document.getElementById("charlineB3").src       = game_state.Parties[1].Characters[2].Avatar_Image;
                document.getElementById("charlineB4").src       = game_state.Parties[1].Characters[3].Avatar_Image;
                document.getElementById("charlineB5").src       = game_state.Parties[1].Characters[4].Avatar_Image;
              
            //check dead, rotate image and win condition
            
                for(var i=0; i<2 ;i++){ //iterate parties
                    var PartyTeam;
                    var dead_count=0;
                    if(i== 0){
                        PartyTeam = "A";
                    }else{ //i == 1
                        PartyTeam = "B";
                    }
                    
                    for(var j=0; j<5 ;j++){ //iterate characters
                        if(gamestate.Parties[i].Characters[j].Health < 0){ //check health
                            dead_count += 1; //count dead for given party, 5 flags a winner/loser
                            if(dead_bools[i][j] == 0){
                                dead_bools[i][j] = 1;
                                var id = "charline"+PartyTeam+j;
                                //css modified with rotate90 class
                                document.getElementById(id).className = "rotate90";
                            }
                    }
                    //Any parties dead?
                    if(deadcount >= 5){ 
                        if(PartyTeam == "A"){ //Team A dead
                            document.body.getElementById("whoseturn").innerHTML = "<h1>TEAM B WINS!!</h1>";
                        }else{ //Team B dead
                            document.body.getElementById("whoseturn").innerHTML = "<h1>TEAM A WINS!!</h1>";
                        }
                    }
                }
                
            //read log
                document.getElementById("logblock").innerHTML = "<h4>" + game_state.Logs[game_state.Logs.length-1].Content + "</h4>";

                //console.log(game_state.Parties[0].Characters[0].Health);
                //console.log(game_state.Parties[0].Characters[1].Health);
                //console.log(game_state.Parties[0].Characters[2].Health);
                //console.log(game_state.Parties[0].Characters[3].Health);
                //console.log(game_state.Parties[0].Characters[4].Health);
                // console.log("Health Team A char 1: "+game_state.Parties[0].Characters[0].Avatar_Name);
                // console.log("Health Team A char 2: "+game_state.Parties[0].Characters[1].Avatar_Name);
                // console.log("Health Team A char 3: "+game_state.Parties[0].Characters[2].Avatar_Name);
                // console.log("Health Team A char 4: "+game_state.Parties[0].Characters[3].Avatar_Name);
                // console.log("Health Team A char 5: "+game_state.Parties[0].Characters[4].Avatar_Name);

                console.log("Values Refilled!");
            

            }
        }).catch(response => console.log(response));
    }, 2000);
    
