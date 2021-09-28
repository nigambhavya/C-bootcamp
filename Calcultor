using System;
using System.Collections.Generic;
					
public class Addition
{
		
	public void AddTheNums(string str)
	{
		//Console.WriteLine(str);
		int sum = 0;
		
		for(int i = 0; i  < str.Length; i++)
		{
			if(str[i].ToString() == "," || str[i].ToString() == "\n")
			{
				//if(str[i].ToString() == "\n") cnt++;
				continue;
			}
			else if(Char.IsDigit(str[i]))
			{
							sum += (int)Char.GetNumericValue(str[i]);
				
				
			}
			
		}
		Console.WriteLine(sum);
	}
	
	public static void Main()
	{
		Addition obj = new Addition();
		string str = "7,8\n1,332,3";
		
		//str = Console.ReadLine();
		
		//Console.WriteLine(str);
		
		obj.AddTheNums(str);

		
	}
}
