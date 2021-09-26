using System;

public class StringCalculator{
	
	public int Add(string numbers){
		int i=0;
		string number="";
		int sum;
		
		if(numbers.Length == 0)
			return 0;
		
		while(i<numbers.Length){
			if(numbers[i] != ',' && numbers[i] != '\n'){
				number += numbers[i];
			}
			
			else{
				sum+=int.TryParse(number);
				number="";
			}
			i+=1;
		}
		sum+=int.TryParse(number);
		
		return sum;
	}
}
					
public class Program
{
	public static void Main()
	{
		StringCalculator calc = new StringCalculator();
		Console.WriteLine("Sum = " + calc.Add("1,2,3,4\n5,6,7,8,9"));
	}
}
