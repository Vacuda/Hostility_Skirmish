
    var unchallenged = true;
    var timer = 0;
    var stop = false;

    setInterval(function()
    { 
      if(stop == false){
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
            if(challenger.Challenged){
              document.getElementById("sorry").innerHTML = "";
              document.getElementById("game").innerHTML = "";
              $('#game').append('<a href="/game">Go to game!</a>');
              }
          }).catch(response => console.log(response));

        }
    }, 1000);

    function increment_time(){
      if(stop == false && unchallenged == true){
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
        stop = true;
      })
      .catch(response => console.log(response));
    }, 10000);
    