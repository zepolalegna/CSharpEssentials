using System;
					
public class Program
{
	public Operations myOperator;
	
	public void Main()
	{
		myOperator = new Operations();
		
		Console.WriteLine("I am still confused :/");
		myOperator.DoMath(12, 8);
		myOperator.DoMath(55, 7);
		myOperator.DoMath(83, 13);
		myOperator.Compare(66,35);
		myOperator.Compare(23,64);
		myOperator.CheckPassword("OhWell");
		myOperator.CheckPassword("Thisisweird444");
	}
}

public class Operations {
	public void DoMath (int value, int value2) {
		var number = value + value2;
		Console.WriteLine(number);
	}
	
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, the first greater.");
		} else {
			Console.WriteLine("False, the second is greater.");
		}
	}
	
	public void CheckPassword (string password) {
		if(password == "Thisisweird444") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");	
		}
	}
}
