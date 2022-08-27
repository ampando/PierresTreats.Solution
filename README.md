# Pierre's Bakery INC. 

#### Authentication with Identity Web Application, using Many-To-Many database relationships with C# for Epicodus 08.26.2022

### By Adrienne Matosich 

## Description

Another C# independent project focusing on many-to-many relationships using SQL and Entity. I also added authentication with Identity. This bakery application is designed for Pierre's Bakery keep track of different types of treats and flavor in his shop. This application allows the user to create, update, and delete information about the treats and flavors. 

## Specifications

**Behavior**: Program will allow user to create an account
  * Input: *User clicks "Register"*
  * Output: User is taken to a page to create a username and password

**Behavior**: Program will allow user to login after registering
  * Input: *User enters login information and clicks "Login"*
  * Output: User is taken to a splash page

**Behavior**: Program will list all treats and flavors
  * Input: *User clicks on "Treat/Flavor Options"*
  * Output: User is taken to a splash page with a list of all treats and flavors

**Behavior**: Program will allow user to select an treat and see all flavors associated with that particular treat
  * Input: *User clicks on specific treat*
  * Output: User is taken to a details page with flavors listed 

**Behavior**: Program will allow user to select a flavor and see all treats associated with that particular flavor
  * Input: *User clicks on specific flavor*
  * Output: User is taken to a details page with treats listed 

**Behavior**: Program will allow authenticated users to add new treats
  * Input: *User clicks "Add new treat"*
  * Output: User is taken to a page with a form to add a treat

**Behavior**: Program will allow authenticated users to add new flavors 
  * Input: *User clicks "Add new flavor"*
  * Output: User is taken to a page with a form to add a flavor

**Behavior**: Program will allow authenticated users to add flavors to an existing treat 
  * Input: *On a treat's details page, user clicks "Add flavor"*
  * Output: User is taken to a page with a form that allows them to add a flavor for that treat

**Behavior**: Program will allow authenticated users to add treats to an existing flavor 
  * Input: *On a flavor's details page, user clicks "Add treat"*
  * Output: User is taken to a page with a form that allows them to add a treat for that flavor

**Behavior**: Program will allow authenticated users to remove flavors from a treat
  * Input: *User clicks "Delete" under an flavor's name on treat's details page*
  * Output: Relationship to that flavor is removed

**Behavior**: Program will allow authenticated users to remove treats from a flavor
  * Input: *User clicks "Delete" under an treat's name on flavor's details page*
  * Output: Relationship to that treat is removed

## Setup/Installation Requirements

*_These instructions are specifically for MySql Workbench, but should work similarly for or any generic SQL database manager._* 

1.  Navigate to the [PierresTreats.Solution repository](https://github.com/adrienne_matosich/PierresTreats.Solution) or open your terminal

2. Clone this project using the GitHub button or the command:
`$ git clone https://github.com/adrienne_matosich/PierresTreats.Solution.git`

3. Navigate to the `PierresTreats` directory in your editor of choice, or use [Visual Studio Code](https://code.visualstudio.com/)

4. Within the project, navigate to the Factory directory, and type `dotnet restore`, then `dotnet build`. 

5. After the build is complete, run the command `dotnet ef database update`. This will create a `treats` database in MySql Workbench. Open or refresh MySql Workbench and confirm that the new database has been created.

7. Type `dotnet run` into the terminal. Click on the provided local host link in the terminal to view the web application in your browser. 

## appsettings.json

Update your username and password in the appsettings.json file. By default these are set to:
user:root and an [empty password].

## Protecting Your Data

1. In your project's root directory, create an .gitignore file.

2. Add the following to your .gitignore file (this protects your sensitive data).
    DO NOT PROCEED UNTIL YOU COMPLETE THIS STEP!
    * appsettings.json
    * bin/
    * obj/

3. Commit your .gitignore file.

## Known Bugs

The css styling needs more time. 

## Support and Contact Details

If there are any issues or questions, please reach out to me through [my GitHub account](https://github.com/ampando).

## Technologies Used

*  [Visual Studio Code](https://code.visualstudio.com/)
*  [Markdown](https://daringfireball.net/projects/markdown/)
*  [C#](https://docs.microsoft.com/en-us/dotnet/csharp/)
*  [.NET5.0](https://dotnet.microsoft.com/download/dotnet-core/net5.0)
*  [ASP.NET Core MVC](https://docs.microsoft.com/en-us/aspnet/core/mvc/overview?view=aspnetcore-5.0)
*  [Entity FrameWork](https://docs.microsoft.com/en-us/ef/)
* [Identity](https://docs.microsoft.com/en-us/aspnet/core/security/authentication/identity?view=aspnetcore-5.0&tabs=visual-studio)


### License

*This project uses the following license: [MIT](https://opensource.org/licenses/MIT)*

Copyright(c) 2022  **_Adrienne Matosich_** 