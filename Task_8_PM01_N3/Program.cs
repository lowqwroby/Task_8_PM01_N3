using System;
using System.Text.RegularExpressions;

namespace Variant10
{
	class Program
	{
		static void Main()
		{
			double sum = 0;
			Console.WriteLine("Введите строку: ");
			String str = new string(Console.ReadLine());
			Regex regex = new Regex(@"(-|)(\d+,\d+|\d+)([eE](-|)\d+|)");
			int index = 0;
																	
			foreach (Match it in regex.Matches(str))                
			{                                                       
				if (it.Success)
				{
					sum += Convert.ToDouble(it.Value);
					index++;
				}
			}
			if(index == 0)
			{
				Console.WriteLine("В тексте нет чисел");
			}
			else
			{
				Console.WriteLine("Сумма чисел, которые были в этом предложении равна {0}", sum);
			}
			
		}
	}
}