using System;
namespace BMICalculator.src {
	class Program {
		static void Main(string[] args) {
			double height, weight;

			Console.Write("Enter your height in meters: ");
			height = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter your weight in kilograms: ");
			weight = Convert.ToDouble(Console.ReadLine());

			Calculate.Results(height, weight);
		}
	}
}