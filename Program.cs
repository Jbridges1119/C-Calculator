string? chosenOperator = "";
string? endGame = "no";
string restart = "yes";
int number1;
bool isNumber;

while (endGame != "yes")
{
  
 while (restart == "yes")
  {
  Console.WriteLine("What maths you want?");
  Console.WriteLine("Press 1 -- (+) \nPress 2 -- (-)\nPress 3 -- (/)\nPress 4 -- (*)");
  chosenOperator = Console.ReadLine();
  Console.Clear();
 

 
    restart = "no";
    switch (chosenOperator)
    {
      case "1":
        Console.WriteLine("Adding.. You should be able to do this in your head");
        break;
      case "2":
        Console.WriteLine("Subtracting.. You should be able to do this in your head");
        break;
      case "3":
        Console.WriteLine("Dividing.. Can be difficult");
        break;
      case "4":
        Console.WriteLine("Multiplying.. The most fun of operators");
        break;
      default:
        Console.WriteLine("Uh oh, you picked wrong, try again.");
        restart = "yes";
        break;
    }
  } 
Console.WriteLine("Pick the first number");
isNumber = int.TryParse(Console.ReadLine(),out number1);
 


  Console.WriteLine("We done? No Or Yes?");
  endGame = Console.ReadLine()?.ToLower();
  if (endGame != "yes")
  {
    Console.Clear();
    Console.WriteLine("WE GO AGAIN!");
  }
}
