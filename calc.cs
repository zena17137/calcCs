using System;
					
public class Program
{
	public static void Main()
	{
		double number1, number2;
		string action;
		
		Console.WriteLine("Введите превое число: ");
		number1 = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Введите второе число: ");
		number2 = double.Parse(Console.ReadLine());
		
		Console.WriteLine("Виберите операцию: '+' '-' '*' '/' ");
		action = Console.ReadLine();
		
		switch (action) {
			case "+":
				Console.WriteLine(number1 + number2);
				break;
			case "-":
				Console.WriteLine(number1 - number2);
				break;
			case "*":
				Console.WriteLine(number1 * number2);
				break;
			case "/":
				if (number2 == 0) {
					Console.WriteLine(0);
				} else
					Console.WriteLine(number1 / number2);
				break;
		}
	}
}