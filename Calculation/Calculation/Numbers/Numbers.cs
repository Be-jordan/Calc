using System;
namespace Calculation
{
	public class Numbers
	{
		int firstNumber;
		int secondNumber;

		CalculatorController calcView;

		public Numbers()
		{
			firstNumber = FirstNumber;
			secondNumber = SecondNumber;
		}

		public int FirstNumber
		{
			get
			{
				return firstNumber;
			}
			set
			{
				firstNumber = value;
			}
		}

		public int SecondNumber
		{
			get
			{
				return secondNumber;
			}
			set
			{
				secondNumber = value;
			}
		}

	}
}