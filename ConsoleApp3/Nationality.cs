using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    //static class Nationality
    //{
    //    public const int Stateless = 0;
    //    public const int Ukrainian = 1;
    //    public const int Russian = 2;
    //}

    //class Example
    //{
    //    public void DoSomething()
    //    {
    //        int nationality = Nationality.Russian;
    //    }
    //}

    // Nationality[0] - forbidden
    // Nationality.German - allowed

    enum Nationality //enum - enumeration - перечисление чего -то, это набор именованных констант, статический класс, который содержит только статические члены, члены либо поля, либо методы,  поле это переменная в классе, а если в методе - локальная переменная
    {
        Stateless,//Stateless=1, что - бы нумерация начиналась с единицы
        Ukrainian,
        Russian,
        Argentine,
        British,
        Chinese,
        English,
        German
    }
}
