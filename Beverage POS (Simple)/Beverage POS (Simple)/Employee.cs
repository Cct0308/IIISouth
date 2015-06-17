using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_POS__Simple_
{
    public class Employee
    {
        private int idx;
        public int id
        {
            get
            {
                return idx;
            }
            set
            {
                idx = value;
            }
        }

        private string namex;
        public string name
        {
            get
            {
                return namex;
            }
            set
            {
                namex = value;
            }
        }

        private string phonex;
        public string phone
        {
            get
            {
                return phonex;
            }
            set
            {
                phonex = value;
            }
        }

        private string mailx;
        public string mail
        {
            get
            {
                return mailx;
            }
            set
            {
                mailx = value;
            }
        }
    }
}
