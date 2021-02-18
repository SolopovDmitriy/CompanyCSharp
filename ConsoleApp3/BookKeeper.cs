using System;

namespace Company
{
	class BookKeeper : Human
	{
		private Company[] maintainingCompanies; // список из строк -> список тех компаний, которые обслуживает бухгалтер по аутсорсингу
		public Company[] MaintainingCompanies
		{
			get => maintainingCompanies;
			set
			{
				//Array.ForEach(value, company => maintainingCompanies.Add(company));
				//int companiesAmount = value.Length; // companiesAmount, колличество компаний - это длина массива
				//maintainingCompanies = new string[companiesAmount];
				//Array.Copy(value, maintainingCompanies, companiesAmount); // библиотечная функция копирования одного массива в другой
				//// нам нужно знать, откуда мы копируем, куда копируем, и какая длина того, что копируем
				///
				maintainingCompanies = value ?? throw new ArgumentException("'companies' parameter is not valid");
			}
		}

		public BookKeeper(params Company[] companies) => MaintainingCompanies = companies; // произвольное число компаний

		// BookKeeper Lena = new BookKeeper(new Company("AliBaba", 1000.36, 10));
		// double companyRate = Lena.CalculateCompanyRate("AliBaba");

		public virtual double CalculateCompanyRate(string companyName)
		{
            for (int i = 0; i < maintainingCompanies.Length; i++)
            {
				if (maintainingCompanies[i].CompanyName == companyName)
                {
					double companyCost = maintainingCompanies[i].CompanyCost;
					int employeesAmount = maintainingCompanies[i].EmployeesAmount;
					return companyCost / employeesAmount;
                }
            }

			return -1;

			//return new SomeClass
			//{
			//	s = 6.35,
			//	b = "34647"
			//};
		}
	}

	class Company
    {
		public string CompanyName { get; set; }

		public double CompanyCost { get; set; }

		public int EmployeesAmount { get; set; }
    }

	//class SomeClass
 //   {
	//	public double s;
	//	public string b;
 //   }
}
