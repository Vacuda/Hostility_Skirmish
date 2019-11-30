
    //See APIREADME.txt for more information

    setInterval(function()
    { 
      fetch("/Lobby/getlogs", {    //UPDATE LOGINS
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
        document.getElementById("user_display").innerHTML = "";

        //get the logged in user by accessing a hidden input in html
        logged_in_user_id = document.getElementById("logged_in_user_id").value;
        
        for(var x=0; x<player_list.length; x++){
            $('#user_display').append('<div><div class="media border p-3" id="@user.UserId"><img src="~/images/fight.png" alt="John Doe" class="mr-3 mt-3 rounded-circle" style="width:60px;"><div class="media-body"><h4>User: '+player_list[x].LastName+'</h4><p>User logged? @user.Logged</p><!-- <small><i>Last Logged-in on February 19, 2016</i></small> --></div></div></div><form action="/game/'+logged_in_user_id+'/'+player_list[x].UserId+'" ><input Name='+player_list[x].UserId+' type=submit value="Challenge!"></form>');
        } 
      })
      .catch(response => console.log("ignore "+response));
    

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
          user = JSON.parse(json);
          console.log(user);
          console.log(user.Challenged);
          if(user.Challenged){
                $('#test').css({
                    'display': 'block',
                    'z-index':'1'
                });
            }
        }).catch(response => console.log(response));
    }, 1000);