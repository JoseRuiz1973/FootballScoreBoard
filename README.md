# FootballScoreBoard

This solution has 2 projects:

- FootballLibrary: This is a library that offers CRUD services for the Football World Cup Score Board.

- FootballClient: This is a client project to test the FootballLibrary, calling its different methods. 

  We assume that the partner sends the matches and results in json format (this can be captured by reading from a web service, for example). 
  
  The json that we assume to start a match is of the type {"HomeTeam":"Spain","AwayTeam":"Brazil"}, and the json to update the score of a match 
  is of the type {" HomeTeam":"Mexico","AwayTeam":"Canada","HomeScore":"0","AwayScore":"5"}. These are the json passed to FootballLibrary.    

  On the FootballClient screen, a series of buttons have been added for the different test cases, already with default values, but they can be 
  modified to add text and free values.
