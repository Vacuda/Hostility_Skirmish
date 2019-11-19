
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
          console.log("Done! It's all good");
          console.log(json.FirstName);
          console.log(json);
          
          player_list = JSON.parse(json);
          console.log(player_list);
          console.log(player_list.length);
          
          document.getElementById("hi").innerHTML = player_list[0];
          
            document.getElementById("hi2").innerHTML = player_list[0].FirstName + " " +player_list[0].LastName;
            
            for(var x=1;x<player_list.length;x++){
              document.getElementById("hi2").innerHTML += " " + player_list[x].FirstName + " " +player_list[x].LastName;
            }
          
      })
      .catch(response => console.log(response));
    }, 3000);