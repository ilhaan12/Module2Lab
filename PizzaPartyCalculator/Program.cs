//Pizza Party Calculator
//Name: Ilhaan Mohamed
//Date: 1/21/2025

//Declare variables
int numberOfGuests;
int slicesPerGuest = 3; //Assumes each guest wants 3 pieces 
int slicePerPizza = 8; //Standard pizza has 8 slices

//Prompt the user to enter the number of guests
Console.Write("Enter the number of guests: ");

//Call the parse function to turn the value the user entered into an int
numberOfGuests = int.Parse(Console.ReadLine());

//Calculate the total number of slices needed:
int totalSlicesNeeded = numberOfGuests * slicesPerGuest;

//Calculate the number of pizza required:
int pizzasNeeded = (int)Math.Ceiling((double)totalSlicesNeeded / slicePerPizza);

//Output the number of pizzas needed
Console.WriteLine($"For {numberOfGuests} guests, you'll need {pizzasNeeded} pizzas.");