## Notes
https://yorkcodedojowordleapi.azurewebsites.net/words.txt


## To release code
cd .\WordleAPI\
dotnet publish -c Release -o ./bin/Publish
Right click on publish and deploy to web app  (Note. the bin folder might be hidden in .gitignore)
If you see the error `Cannot read properties of undefined (reading 'createClient')` then opening the Azure extension and expanding YorkDevelopers/App Services seems to resolve it.

## To create database changes
dotnet tool install --global dotnet-ef 
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add DateStarted
dotnet ef migrations script --output DateStarted.sql
dotnet ef migrations script InitialCreate  --output DateStarted.sql 
Log into the Azure console,  and select the Wordle database.
Use the Query Editor to apply the script.



## TODO
Example solution

Admin methods for me
  List of teams
  Dashboard?

Rename end points

POST -> /team creates a new team
POST -> /team/{teamId}/game creates a new game
GET ->  /team/{teamId}/game retrieves all your games
GET ->  /team/{teamId}/game/{gameId} retrieves the specified game
POST ->  /team/{teamId}/game/{gameId}/guess makes a guess for the specified game