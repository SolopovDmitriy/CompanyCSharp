using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    enum WorkerType
    {
        Undefined,
        Loader,
        DeliveryMan,
        GeneralMan
    }

    class Worker : Human
    {
        public WorkerType WorkerType { get; set; } = WorkerType.Undefined;

        private string companyName;// настоящее имя компании
        public string CompanyName  //properties
        {
            get => companyName;
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 1)
                {
                    throw new ArgumentException("Please provice a valid company name");
                }
                companyName = value;
            }
        }
    }
}
