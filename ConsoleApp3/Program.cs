using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Human human = new Human();
            Console.WriteLine(human);
            Console.WriteLine(human.ToString());
            Console.WriteLine(human.genre);
            Console.WriteLine(human.nationality);
            Console.WriteLine(human.Name); //поле: чтение
            human.Name = "Вася";           //поле: запись
            Console.WriteLine(human.Name); 
            Console.WriteLine(human.getName());*/

            try
            {
                //класс абстрактный - нет возможности создать его экземпляр
                //Human human = new Human("Марко", "Поло", "Иммануилович", new DateTime(1775, 10, 25), Genre.MALE, Nationality.English);
                //Employee employee = new Employee();
                //Console.WriteLine(employee);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Я ошибка, но программа не вылетела :)");
                Console.WriteLine(ex.Message);
                Console.ResetColor();
            }
            Console.WriteLine("Я программа и я все одно работаю :)");

            Company aliBaba = new Company
            {
                CompanyName = "AliBaba",
                CompanyCost = 356.74,
                EmployeesAmount = 56
            };

            BookKeeper lena = new BookKeeper(aliBaba);

            double companyRate = lena.CalculateCompanyRate("AliBaba");
            Console.WriteLine(companyRate);
        }
    }
}
