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

-------------------------------------------------------------------------------
Date: 2024-01-24
Time - 22:55:56
Student Id - 0849075

Task 4 - 
I have created a data model class named LokeshMovies under the models and have entered code manually by modifiying the namespace as Lab_1_Lokesh.Models.Models;
Next i have created NuGet Packages by right clicking on the controllers -> Add -> New Scaffolded Item. For the Controller name i gave name as LokeshMoviesConttroller and click on Add.
Scaffolding has created below 
1. Controllers/LokeshMoviesController.cs
2. Views/LokeshMovies/Create,Delete,Details,Edit and Index .cshtml
3. Data/Lab_1_LokeshContext.cs
Now, I have created the Migration to create and update a database to match the data model.
navigated to Tools -> NuGet Package Manager -> Package Manager Console
and run the below comands in PowerShell 
Add-Migration InitialCreate
Update-Database
A new migration file created with the date and time stamp - C:\Users\donga\source\repos\Lab 1-Lokesh\Lab 1-Lokesh\Migrations\20240124222556_InitialCreate.Designer.cs
I have cleaned the console and build without any errors and Run the application.

Problems faced and New Things Learned:
1. As i have changed the name of the controller from MvcMovie to LokeshMovie, they are some changes required in the code, which lead to me 
errors and page not loaded when i run the code. Not able to find the Movies page. I have stared going through the complete steps one by one 
and then able to find the code changes where all modifications required. Successfully i am able to open the movies page.
Also understood that about scaffold that it creates CRUD pages automatically 