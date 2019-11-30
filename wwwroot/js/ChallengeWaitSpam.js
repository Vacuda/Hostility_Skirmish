
    //**not currently implemented. delete if desired**
    //intended to kick the challenger back to the lobby if the challenged player does not accept.
    
    var unchallenged = true;
    var timer = 0;
    var start = false;

    setInterval(function()
    { 
      if(start == false){
        fetch("/Lobby/check_challengers", {   //UPDATE CHALLENGER!
          headers: { "Content-Type": "application/json" },
          credentials: 'include'
        })
        .then(response => {
            if (!response.ok) {
                throw response;
            }
            return response.json();
        })
        .then(json => {
            challenger= JSON.parse(json);
            console.log(challenger);
            console.log(challenger.Challenged);
            if(!challenger.Challenged){
              document.getElementById("sorry").innerHTML = "";
              document.getElementById("game").innerHTML = "";
              $('#game').append('<p href="/game">LET THE GAME BEGIN!!!</p>');
              }
          }).catch(response => console.log(response));
        }
    }, 1000);

    function increment_time(){
      if(start == false && unchallenged == true){
        timer += 1;
        document.getElementById("timer").innerHTML = "Seconds: "+timer;
      }else{
        document.getElementById("timer").innerHTML = "";
        document.getElementById("sorry").innerHTML = "";
        $('#sorry').append('<a href="/lobby">Back to Lobby</a>');
      }
    }

    setInterval(increment_time, 1000);

    setInterval(function()
    { 
      if(start == false){
      fetch("/Lobby/drop_challenge", { //times up bye!!!!
      headers: { "Content-Type": "application/json" },
      credentials: 'include'
    })
    .then(response => {
        if (!response.ok) {
            throw response;
        }
        return response.json();
    })
    .then(json => {
        challenger = JSON.parse(json);
       start = true;
      })
      .catch(response => console.log(response));
     }
    }, 10000);
    