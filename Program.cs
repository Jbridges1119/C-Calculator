string? chosenOperator = "";
string operatorWord = "";
string? endGame = "no";
float number1 = 0;
float number2 = 0;
bool is1Number;
bool is2Number;
string statement = "The numbers {0} and {1} {2} to {3}";
float equation = 0;

Console.Clear();
while (endGame != "yes")
{
is1Number = false;
is2Number = false;
 while (chosenOperator == "")
  {

  Console.WriteLine("What maths you want?");
  Console.WriteLine("Press 1 -- (+) \nPress 2 -- (-)\nPress 3 -- (/)\nPress 4 -- (*)");
  chosenOperator = Console.ReadLine();
  Console.Clear();
    switch (chosenOperator)
    {
      case "1":
        Console.WriteLine("Adding.. You should be able to do this in your head");
        operatorWord = "Add";
        break;
      case "2":
        Console.WriteLine("Subtracting.. You should be able to do this in your head");
        operatorWord = "Subtract";
        break;
      case "3":
        Console.WriteLine("Dividing.. Can be pretty difficult");
        operatorWord = "Divide";
        break;
      case "4":
        Console.WriteLine("Multiplying.. The most fun of operators");
        operatorWord = "Multiply";
        break;
      default:
        Console.WriteLine("Uh oh, you picked wrong, try again.");
        chosenOperator = "";
        break;
    }
  } 
while (!is1Number)
{
Console.WriteLine("Pick the first number");
is1Number = float.TryParse(Console.ReadLine(),out number1);
if(!is1Number){
  Console.WriteLine("Not a number, try again.");
}
}
while (!is2Number)
{
Console.WriteLine("Pick the second number");
is2Number = float.TryParse(Console.ReadLine(),out number2);
if(!is2Number){
  Console.WriteLine("Not a number, try again.");
}
}
    
    switch (chosenOperator)
    {

      case "1":
       equation = number1 + number2;
        Console.WriteLine($"{statement}",number1, number2, operatorWord, equation );
        break;
      case "2":
        equation = number1 - number2;
        Console.WriteLine($"{statement}",number1, number2, operatorWord, equation );
        break;
      case "3":
       equation = number1 / number2;
        Console.WriteLine($"{statement}",number1, number2, operatorWord, equation );
        break;
      case "4":
       equation = number1 * number2;
        Console.WriteLine($"{statement}",number1, number2, operatorWord, equation );
        break;
      default:
        Console.WriteLine("Oof, I dunno what happened.");
        break;
    }




  Console.WriteLine("We done? No Or Yes?");
  endGame = Console.ReadLine()?.ToLower();
  if (endGame != "yes")
  {
    Console.Clear();
    Console.WriteLine("WE GO AGAIN!");
    chosenOperator = "";
  }
}
