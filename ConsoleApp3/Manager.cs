using System;

namespace Company
{
    class Manager : Human
    {
        public bool IsSalesManager { get; set; } = false;//properties - является ли это менеджер SalesManager - именно по продажам, а не например  менеджером по управлению

        private int salesAmount;// переменная колличество продаж
        public int SalesAmount // properties
        {
            get => salesAmount;
            set
            {
                if (salesAmount < 0)
                {
                    throw new ArgumentException("Manager can not sell less than zero");
                }
                salesAmount = value;
            }
        }

        // Manages Vasya = new Manager();
        // it is the same as next
        // Manager Vasya = new Manager(false, 0);
        // parameters by default, we don't need to clarify them

        public Manager(bool isSalesManager = false, int salesAmount = 0) =>
            (IsSalesManager, SalesAmount) = (isSalesManager, salesAmount);
    }
}
