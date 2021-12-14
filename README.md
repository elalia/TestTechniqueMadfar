# README #

Medfar MVC Test


### How do I get set up? ###

In order to complete the test you need : 

 Visual Studio 2015  [ Community Version is free
	https://www.visualstudio.com/vs/older-downloads/	
	
 SQL Server Express 
    https://www.microsoft.com/en-us/sql-server/sql-server-editions-express
 
 You need an SQL EXPRESS instance names "SQLEXPRESS" or else you will need to change connection string(s) of the code base.

 ### Coding Version Instructions : 
 
  1 - open MVC/Medfar.Test.WEB/MEDFAR.Test.Web.sln in VS2015-2019
  
  2 - right-click solution, click on restore NuGet Package
  
  3 - compile solution
  
  4 - run the createdb.sql script on your SQLExpress instance to create the MEDFAR_DEV_INTERVIEW database and inject default data in it
  
  5 - run Medfar.Interview.Web - you should see complete instructions on the main page
  
  Complete your task, and commit & push your version in a branch named LASTNAME_FIRSTNAME

  Any comments or extra information should be put in a readme.txt at root of spplication
  
  
### Coding Review Instructions :     

  1 - Create a pull request from the TEST branch
  
  2 - Add comments in the Azure Devops PR interface
  
  3 - Send additional notes and suggestions in a document to the person that gave you the test.






### Who do I talk to? ###

questions ? pl.ladouceur@medfarsolutions.com