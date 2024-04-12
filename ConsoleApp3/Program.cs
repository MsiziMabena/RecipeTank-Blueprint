using System;
using System.Collections.Generic;
using System.Numerics;

namespace recipeApplicatio
{
    class Application
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe(); // Creating a new recipe object
            bool continueApplication = true; //Variable to control the loop

            while (continueApplication)
            {
                //Displaying the name of the application and its menu options
                Console.WriteLine("********************** RECIPE TANK **********************");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("**********made for easy and fast recipe storage**********");
                Console.WriteLine("*********************************************************");
                Console.WriteLine("1. Please enter the recipe ingredients");
                Console.WriteLine("2. Display the full Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset Quantities");
                Console.WriteLine("5. Clear All the Data");
                Console.WriteLine("6. Exit Application");

                Console.WriteLine("*********************************************************");
                Console.Write("Please input your selection: ");             
                int select = int.Parse(Console.ReadLine());//Read the user input of the menu options
                 Console.WriteLine("*********************************************************");
                //Using the switch statement to process the user's choice
                switch (select)
                {
                    case 1:
                        recipe.EnterRecipeDetails();
                        break;
                    case 2:
                        recipe.DisplayRecipe();
                        break;
                    case 3:
                        recipe.ScaleRecipe();
                        break;
                    case 4:
                        recipe.ResetQuantities();
                        break;
                    case 5:
                        recipe.ClearData();
                        break;
                    case 6:
                        continueApplication = false; //Exit the loop
                        break;
                    default:
                        Console.WriteLine("Incorrect choice, please start over ");
                        break;
                }
            }
        }
    }

    class Recipe
    {
        private List<Ingredient> ingredients; //List to store the ingredients
        private List<string> steps;//List to store the steps

        public Recipe()
        {
            ingredients = new List<Ingredient>();//Initialize the ingredients list
            steps = new List<string>();//Initialize the steps list
        }

        //Method for entering the recipe details
        public void EnterRecipeDetails()
        {
            //Prompting the user to input the number of ingredients that will be used
            Console.Write("Please enter the number of ingredients that will be used: ");
            int ingredientNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < ingredientNum; i++)
            {
                //Read ingredient details from the user's input
                Console.WriteLine($"Please enter the full details of the recipe you are going to use. Recipe no: {i + 1}:");//Prompting the user to input the full details of the recipe the user is going to use
                Console.WriteLine("*********************************************************");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Quantity(Number): ");
                double quantity = double.Parse(Console.ReadLine());
                Console.Write("Unit of Measurement(eg kg or g: ");
                string unit = Console.ReadLine();
                //Creating a new object and adding it to List
                ingredients.Add(new Ingredient(name, quantity, unit)); 
                Console.WriteLine("*********************************************************");
            }
            //Prompting the user to enter the step details
            Console.Write("Please input the number of steps: ");
            int stepCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < stepCount; i++)
            {
                //Read the step details from the user's input
                Console.WriteLine($"Enter step {i + 1}:");
                string step = Console.ReadLine();
                steps.Add(step);//Adding step to list
            }

            Console.WriteLine("The recipe ingredients have been inputted successfully");
        }

        //Method to display the full recipe details
        public void DisplayRecipe()
        {
            //Displaying the full recipe, involving the ingredients and steps
            Console.WriteLine("Recipe Details:");
            Console.WriteLine("Ingredients:");
            foreach (Ingredient ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name}: {ingredient.Quantity} {ingredient.Unit}");
            }

            Console.WriteLine("Steps:");
            for (int i = 0; i < steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
        }

        //Method to scale the recipe
        public void ScaleRecipe()
        {
            //Propmpting the user to enter the scaling factor of their choice
            Console.Write("Input the scaling factor of your choice(0, 5, 2, 3)");
            double Scalingfactor = double.Parse(Console.ReadLine());
            //Scaling the quantities of every ingredient
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.Quantity *= Scalingfactor;
            }

            Console.WriteLine("Your recipe has been scaled successfully.");
        }

        //Method to reset all the quantities of ingredients to original values
        public void ResetQuantities()
        {
            //Reseting the quantities of each ingredient to its original value
            foreach (Ingredient ingredient in ingredients)
            {
                ingredient.ResetQuantity();
            }

            Console.WriteLine("Quantities reset to original values.");
        }

        public void ClearData()
        {
            //Clearing all the data that was entered by the user
            ingredients.Clear();
            steps.Clear();

            Console.WriteLine("All the data has been scaled successfully.");
        }
    }

    class Ingredient
    {
        //Properties to store recipe details
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        //Constructers to used to initialize the ingredient properties
        public Ingredient(string name, double quantity, string unit)
        {
            Name = name;
            Quantity = quantity;
            Unit = unit;
        }

        public void ResetQuantity()
        {
            // Reset quantity to original value
            // Assuming original value is 1 for simplicity
            Quantity = 1;
        }
    }
}
