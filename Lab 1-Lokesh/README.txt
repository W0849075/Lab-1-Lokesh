Date - 2024-01-16 
Time - 18:20 - 19:30
Student Id - 0849075

Task1: 
Creating a web app using ASP.NET Core MVC using Visual Studio
Installed Visual Studio app 2022 and created a new project by selcting the ASP.NET Core Web App (Model-View-Controller) template. 
Click on Create a New project and provide the project name and se;ect >NET 8.0 (Long Term Support) and uncheck the top-level statements.
Click on Create and Start the Debug, Web Page should be opened and shows the page as Welcome


Task2:
Add a controller to an ASP.NET Core MVC application.

Steps:
1. Navigate to Solution Explorer, right click on Controllers -> Add -> Controller
2. Select MVC Controller - Empty and Click on Add.
3. Replaced the Contents of Controllers/HelloWorldController.ca 


Task3: Create a view for the Index action method of the HelloWorldController class that displays a welcome message and the current date and time.

Problems:
How to create a view file and associate it with a controller action method?
How to use Razor syntax to write dynamic HTML code in the view file?
How to pass data from the controller to the view?

Solutions:

1. In the Solution Explorer, right-click on the Views folder and select *Add > New Folder*. Name the folder HelloWorld.
2. Right-click on the HelloWorld folder and select *Add > New Item*.
3. In the *Add New Item* dialog, select *Show All Templates*.
4. In the search box in the upper-right corner, enter view.
5. Select *Razor View - Empty* and keep the default name Index.cshtml.
6. Replace the contents of the Views/HelloWorld/Index.cshtml Razor view file with the following code:

