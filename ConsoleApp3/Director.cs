using System;

namespace Company
{
	class Director : Human
	{
		private const int MaxAmountOfSubordinates = 10_000;

		// отдельная переменная, куда вынесено максимальное количество подчинённых у директора
		// сделано это для того, чтобы 10 000 не выглядело как магическое число
		// а почему 10 000? А почему не 5000? Данная переменная это объясняет

		private int subordinatesAmount; // приватная переменная класса, которая хранит количество рабочих
		public int SubordinatesAmount // свойство класса директор
		{
			/*
			 * get
			 * {
			 *   return subordinatesAmount;
			 * }
			*/

			get => subordinatesAmount;
			set
			{
				if (value < 1 || value > MaxAmountOfSubordinates)
				{
					throw new ArgumentException("Number of subordinates should be between 1 and 10 000");
				}
				subordinatesAmount = value;
			}
		}

		private string companyName;
		public string CompanyName
        {
			get => companyName;
            set
            {
				if (string.IsNullOrEmpty(value) || value.Length < 1)
                {
					throw new ArgumentException("Invalid company name. Please choose another");
                }
				companyName = value;
            }
        }

		public Director(int subordinatesAmount, string companyName) =>
			(SubordinatesAmount, CompanyName) = (subordinatesAmount, companyName);
	}
}
