----------Overview of automated communications--------

lobby.js: "wwwroot/js/lobby.js"
Every second, lobby.js sends a request for an updated list of every user with logged = true.
HTML elements are created by lobby.js for each user in the query.

Clicking challenge will send the challenger to the "Game/{current_user_id}/{challenger_id}" route
and create a new gamestate object with a unique gamestate_id. Both the challenger and the user who is challenged have their field challenged = true.

If a user's challenged flag is set to true while in lobby, that user's lobby.js will reveal a button to accept a challenge.
This is being checked by an API get request every second.

A challenger is sent to the "/game" route and will switch both user's flags to challenged = false.
This is a non-ideal system as any player can assume the role of player2 after a challenger enters the game 
and before the challenged player accepts.

game.js: "wwwroot/js/game.js"
Every 2 seconds, game.js sends a request for an updated gamestate object. 
That object may be parsed for health, is_dead status, etc.

On clicking "attack" in game, an API post request is sent to the server's game controller.

data posted is a raw string of the form:
"A:3:Attack:B1"
    Where A is the attacker's team, 3 is the character index of the attacker's party,
Attack is the move type and B1 is the target's team and character index in party.
In the GameController, the "Game/character_action/{gamestate_id}" route will parse the string into 4 variables.
<Warning> JSON data sent to this route which is not in the appropriate form is likely to throw an exception.


IMPORTANT WHEN SENDING OBJECTS VIA JSON!
If you want to send an object via JSON and wish to parse it, know that
Newtonsoft's json parser will throw an exception for every object with a circular reference.
e.x. a database model's navigational properties. Ensure all references used more than once are marked with the 
[JsonIgnore] flag. See Models/GameClasses/Party for an example.
