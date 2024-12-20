using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1_Demo
{
    internal class Employee
    {
        //int id;
        //string name;
        //Gender Sex;

        #region Attributes
        public int id;
        public string name;
        private decimal salary;
        #endregion
        #region constructor
        public Employee(int _id, string _name, decimal _salary)
        {
           id = _id;
            name = _name;
            salary = _salary;
        }
        #endregion
        #region Methods
        public override string ToString()
        {
            return $"Id : {id}\nname : {name}\nsalary : {salary}";
        }
        #endregion
        #region Encapsulations
        //1-Encapsulations: Separate data definition [Attributes]
         //From it is Use (Getter/Setter - Properety - Indexer)

         //Getter
         public string GetName()
        {
            return name ;
        }
        //Setter
        public void SetName(string value)
        {
            name = value.Length <= 5?value:value.Substring(0,5);
            //control data validation
        }

        //2- Applying Property
        //2.1- Full Property
        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;/* >= 4000 ? value : 4000; //control data validation*/
            }
        }

        //2.2- Automatic Property
        //public int age;
        public int Age { get; set; }
        #endregion
    }
}
