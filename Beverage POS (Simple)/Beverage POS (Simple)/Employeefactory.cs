using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_POS__Simple_
{
    public class Employeefactory
    {
        protected Employee[] employees = new Employee[3];
        int count = 0;

        public Employeefactory()
        {
            loadData();
        }

        private void loadData()
        {
            employees[0] = new Employee()
            {
                id = 1,
                name = "Kitty",
                phone = "071456895",
                mail = "071456895@iii.org.tw"
            };

            employees[1] = new Employee()
            {
                id = 2,
                name = "Mary",
                phone = "074569852",
                mail = "074569852@iii.org.tw"
            };


            employees[2] = new Employee()
            {
                id = 3,
                name = "Peter",
                phone = "073256851",
                mail = "073256851@iii.org.tw"
            };
        }

        public Employee getById(string p)
        {
            try
            {
                int intId = Convert.ToInt32(p);

                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].id == intId)
                    {
                        count = i;
                        return employees[i];
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }
    }   
}
