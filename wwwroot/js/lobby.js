
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
        document.getElementById("user_display").innerHTML = "";
        
        for(var x=0; x<player_list.length; x++){
            $('#user_display').append('<div><div class="media border p-3" id="@user.UserId"><img src="~/images/fight.png" alt="John Doe" class="mr-3 mt-3 rounded-circle" style="width:60px;"><div class="media-body"><h4>User: '+player_list[x].LastName+'</h4><p>User logged? @user.Logged</p><!-- <small><i>Last Logged-in on February 19, 2016</i></small> --></div></div></div><form action="/lobby/'+player_list[x].UserId+'" asp-controller="Home"><input Name='+player_list[x].UserId+' type=submit value="Challenge!"></form>');
        } 
      })
      .catch(response => console.log(response));
    }, 1000);

    setInterval(function(){ 
        //var challengables = document.getElementsByClassName("media border p-3");
            console.log(challengables[x].id.toString());
     
  
     }, 500);

     var challengables = document.getElementsByClassName("media border p-3");
    

    fetch("/Lobby/send_here", { 
      headers: { "Content-Type": "application/json" },
      credentials: 'include',
      method: "POST",
      body: "RAW STRING MADAFAKA!"
    })
      .then(response => {
          if (!response.ok) {
              throw response;
          }
          return response.json();
      })
      .then(json => {
          json = JSON.parse(json);
          console.log(json);
      })
      .catch(response => console.log(response));