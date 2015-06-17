using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    public class CCustomer
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

        private string addrsx;
        public string addrs
        {
            get
            {
                return addrsx;
            }
            set
            {
                addrsx = value;
            }
        }
    }
}
