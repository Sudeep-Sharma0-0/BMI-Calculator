using System;
namespace BMICalculator.src {
	public static class Calculate {
		public static void Results(double h, double w) {
			double bmi = Math.Round((w / Math.Pow(h, 2)), 2);
			Console.WriteLine("Your BMI is: " + bmi);

			if (bmi >= 40.0) Console.WriteLine("Obese (Class III)");
			else if (bmi >= 35.0) Console.WriteLine("Obese (Class II)");
			else if (bmi >= 30.0) Console.WriteLine("Obese (Class I)");
			else if (bmi >= 25.0) Console.WriteLine("Overweight (Pre Obese)");
			else if (bmi >= 18.5) Console.WriteLine("Normal Range");
			else if (bmi >= 17.0) Console.WriteLine("Underweight (Mild Thinness)");
			else if (bmi >= 16.0) Console.WriteLine("Underweight (Moderate Thinness)");
			else if (bmi >= 00.0) Console.WriteLine("Underweight (Severe Thinness)");
			else Console.WriteLine("Error");
		}
	}
}