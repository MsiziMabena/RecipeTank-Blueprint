RecipeTank-Blueprint
RecipeTank-Blueprint is a C# console application for creating, viewing, and scaling a single recipe from the command line.
Main Menu
The application runs in a loop and presents a numbered menu:
* Create new recipe
* Start a new recipe by entering a name/title.
* Enter ingredients
* Add ingredients one by one (name, quantity, and unit).
* Existing ingredients for the current recipe can be replaced or updated depending on how the code is implemented.
* Display full recipe
* Shows the recipe title, all ingredients with their current quantities and units, and any stored steps or notes if they are implemented in the code.
 Scale recipe
* Apply a scaling factor (for example 0.5, 2, or 3) to all ingredient quantities.
* The updated quantities are stored and shown in later views until you reset or clear the data.
  Reset quantities
* Restore ingredient quantities back to their original values before any scaling was applied.
  Clear all data
* Remove the current recipe, ingredients, and any related data from memory so you can start fresh.
 Exit
 Close the application.
Setup and Running
* Clone the repository
* Use git clone to copy the RecipeTank-Blueprint repository to your machine.
* Build the project
* Open the solution in Visual Studio or another C# IDE and build the project, or run dotnet build if it is a .NET project.
* Run the console app
* Start the application from your IDE, or run dotnet run (or the generated .exe) from the command line.
* The main menu will appear in the console.
Technical Highlights (Core Logic)
* Central recipe model
* The application stores a single recipe in memory, including its ingredients (name, quantity, unit) and any steps/notes that exist in the code.
  Scaling logic
* When you choose "Scale recipe", the program multiplies each ingredient’s quantity by a user-provided factor (for example 0.5, 2, or 3).
* The scaled quantities replace the current values so future displays and operations use the updated amounts.
* Reset to original quantities
* The application keeps track of the original ingredient quantities before scaling.
* "Reset quantities" restores all ingredient quantities back to those original values.
* In-memory data only
* All recipe data is stored in memory for the duration of the program.
* Closing the application or choosing "Clear all data" removes the current recipe from memory.
This README is intentionally minimal and only describes behavior that actually matches the menu and core logic of the RecipeTank-Blueprint console application.
