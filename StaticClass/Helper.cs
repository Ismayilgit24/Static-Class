using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StaticClass
{
	internal static class Helper
	{
        public static bool IsOdd(this int number)
		{
			if(number%2 == 1)
			{
				return true;
			}
			return false;
		}
		public static bool IsEven(this int number)
		{
			if (number % 2 == 0)
			{
				return true;
			}
			return false;
		
		}

		public static bool HasDigit(this string word)
		{
			for(int i=0; i<word.Length; i++)
			{
				if (char.IsDigit(word[i]))
				{
					return true;
				}
				
			}
			return false;
		}

		public static bool CheckPassword(this string password)
		{
			for(int i=0; i<password.Length; i++)
			{
				if (password.Length < 8)
					return false;

				
				if (!Regex.IsMatch(password, "[A-Z]"))
					return false;

				
				if (!Regex.IsMatch(password, "[a-z]"))
					return false;

				
				if (!Regex.IsMatch(password, "[0-9]"))
					return false;

				
			}
			return true;
		}

		public static string Capitalize(this string word)
		{
			return  word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower();
		}
	}
}
