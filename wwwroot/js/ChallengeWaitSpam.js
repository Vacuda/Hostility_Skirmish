
    setInterval(function()
    { 
      fetch("/Lobby/getlogs", { 
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
        player_list = JSON.parse(json);
        console.log(player_list);
        console.log(player_list.length);
      })
      .catch(response => console.log(response));
    }, 1000);

    var timer = 0;
    function increment_time(){
        timer += 1;
        document.getElementById("timer").innerHTML = "Seconds: "+timer;
        console.log(timer);
    }

    setInterval(increment_time, 1000);
    alert("hi");
    