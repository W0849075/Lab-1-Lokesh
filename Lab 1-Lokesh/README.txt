Date - 2024-01-16 
Time - 18:20 - 19:30
Student Id - 0849075

Task 1: Installing the Visual Studio 2022 and configuring 
I have installed the application and created a new project named Lab_1_Lokesh by following the stpes mentioned by learn.microsoft
Next, as i have the default code and able to see a Welcome page, next i have modified the code to display the web page to display Hello World.
Problems: Not faced any problems as steps clear and stright forward.
Things Learned: I have learned on how to install and configure the visual studio and create a project. Basic buttpn loctions and app overview.

Task 2:
I have added a controlled by following the steps, Steps to add a controller -> Rigth click on controller -> Add -> Controller
Once Controller is created, have modified the existing code to display the web page as "This is the Welcome action method.." when a user exexutes the 
https://localhost:5001/HelloWorld/Welcome 
Things Learned: I have learned on how to create the controlled and modify the code to seeing the expected resulsts and how to add the 
img to the welcome page. Also, Understood that when we add a controller a program.cs is created.
Problems Faced: Not able to add the img as steps are not in the learn page. After searching on how to add the image to the controller. 
I am able to add the img to welcome page.

Task 3: Create a view for the Index action method of the HelloWorldController class that displays a welcome message and the current date and time.

Created a New View by navigating to Views folder and right click on it -> Add -> New Item and followed the rest steps to create a new view.
Once the Index.cshtml razor is created, I have updated the Index.cshtml file with code mentioned on the learn page.
After modifiyng the code, i have executed/run the code, web page navigated to localhost:7183/HelloWorld where page displayed as Index.

Problems Faced: I have Changed the MvcMovie to Movie App in the Views/Shared/_Layout.cshtml page where by unknowing i ahve modify some other the line of code which gave me errors later of the execution.
When i searched for the errors i found that name at different places i have miss typed the word on as Movei App isntead of Movie App.

Things Learned: How to add views and change the page layout, how to changed the title, footer and menu links by following the gudielines steps.
Also uderstood that there are multiple there are different folders are available under the "Views" like ViewStart.cshtml, Index.cshtml.

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

Task 5: Working with Database
I have navigated to view menu option in the task bar and Selected "SQL Server Object Explorer" where it opened a SQL Server Object Explorer page which shows
the SQL Server data. I have navigated to Lab_1_LokeshContext project and selected dbo.LokeshMovie where i can find the
dbo.Movie design.
I hvae navigated to view data page by right clicking on the dbo.LokeshMovie and check the Movie table.
To Update the Movie data base with new names i have navigated to the SeedData.cs file in the Models Folder
and updated the movie names, release date and prices. Next i have added a Seed Initializer inside th Program.cs file with following code

using (var scope = app.Services.CreateScope())
{
 var services = scope.ServiceProvider;
 SeedData.Initialize(service);
 
}
 When i have executed the code, i am able to see the updated list from the database is shown in the webpage

 Problems faced: As i have mentioned earlier that i have renamed the default list to other name, there some changes which i need 
 find and replace with correct format.

 Things Learned: How to link the database to server and add the seed to initialzer. How to find the errors and where spot the errors.

 Task 6: Controller Methods and Views
 I have added the some code to show the release date in two words
 I have navigated to Modles/Movie.cs file and updated with the below code inside the public class Movie loop
 [Display(Name = "Release Date")]
 [DataType(DataType.Date)]
 [Column(TypeName = "decimal(18,2)")]
 Next, I have navigated to Views/Movies/Index.cshtml file and add some code to show the mvc anchor tag when ever user points the cursor on the
 edit, details,delete button links.

 Things Learned: how to modify the Models files to show the corresponding output, how to assign the limit values for date and other 
 How to add the MVC Anchor tag

------------------------------------------------------------
Date - 2024-01-31
Time - 18:32:56
Student Id - 0849075

Task 7:
Add search to an ASP.NET Core MVC app
I have navigated to Controllers/LokeshMoviesController.cs and modified the Index Action Method.
Where i have added below code 
var movies = from m in _context.LokeshMovie
                         select m;
to create a LINQ query to select the movies
Next, i have navigated to Program.cs file and checked for the id parameter pattern.
Next, I have modified the Index loop inside the LokeshMoviesController.cs with id instead of searchString and build the code and executed 
After the changes in program.cs file and LokeshMoviesController.cs user need not to be enter the index?searchString= "Movie name" where now he can directly enter the movie title after LokeshMovies 
Next i have added a <form> markup loop insided the Views/Movies/Index.cshtml which added a filter button on the app.
Below code has been added to the Index.cshtml
<form asp-controller="LokeshMovies" asp-action="Index">
    <p>
        Title: <input type="text" name="SearchString" />
        <input type="submit" value="Filter" />
    </p>
</form>
Now, I have added a Search by genre filter inside the app by updating the LokeshMoviesController.cs file
Below is the code to get the LINQ query that retrives the genres 
// Use LINQ to get list of genres.
IQueryable<string> genreQuery = from m in _context.Movie
                                orderby m.Genre
                                select m.Genre;
I also updated the Index.cshtml where loop with MovieGenre has been modified according to the requirement.
After rebuild the code anf navigating to the web url. I am able to see the filter for genre and title.
Observation and Things Learnerd:
Controller file is where user need to modified the code for MovieGenre and searchString to add a filter to the 
app, Index method is where the code changes are done, also linq query is created to selecte the 
movies from the context movies. Next modified the Views/Movies/Index.cshtml to add the filter related to Genre and 
tile. 

Problems Faced: Faced isses with name resolution, when ever i run the code i had received the errors with name issues
where i need to modify the code as per the my file names. For genre fiter to able to figure out the issue where the loop
is unable to find the LINQ query to context file. Next i have removed the entire code of index.cshtml file and added the code 
by manually. Then issue has bee resolved.


Task 8:
Task: To add a new field to an ASP.NET Core MVC app

Navigated to Models/LokeshMovie.cs file to add a Rating property to the movie model,
Add a bleow code to the existing code - public string? Rating { get, set;}

Observation:
Adding a new field to an ASP.NET Core MVC app required changes to both the model and data context classes, 
as well as updating the views and controllers to handle the new field. It is important to carefully plan the 
addition of a new field and ensure that it is relevant and necessary for the app's functionality. 

Task 9:
Opened the ASP.NET Core MVC app in Visual Studio: Navigated to the Model Class: Identify and open the model class that corresponds to the data entity requiring validation.
Apply Data Annotations for Validation Within the model class, use data annotations (attributes) to define validation rules for the properties. For instance, use [Required]
for mandatory fields, [StringLength] for maximum length, or custom annotations for specific requirements.
Observation:
ASP.NET Core MVC offers immediate feedback to users, supports client-side and server-side validation, and allows developers to implement
custom validation logic. This enhances user experience by providing immediate feedback on input. The system also supports error message localization, allowing applications to display messages in different languages based on user preferences. This allows for better integration with other systems and enhances user experience.
Immediate Feedback to Users: The incorporation of validation provides users with immediate feedback on their input, 
enhancing the user experience.
