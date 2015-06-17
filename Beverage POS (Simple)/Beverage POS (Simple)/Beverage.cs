using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_POS__Simple_
{
    public class Beverage
    {
        private int nox;
        public int no
        {
            get
            {
                return nox;
            }
            set
            {
                nox = value;
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

        private int countx;
        public int count
        {
            get
            {
                return countx;
            }
            set
            {
                countx = value;
            }
        }

        private int unitPricex;
        public int unitPrice
        {
            get
            {
                return unitPricex;
            }
            set
            {
                unitPricex = value;
            }
        }

        private string noteTx;
        public string noteT
        {
            get
            {
                return noteTx;
            }
            set
            {
                noteTx = value;
            }
        }

        private string noteSx;
        public string noteS
        {
            get
            {
                return noteSx;
            }
            set
            {
                noteSx = value;
            }
        }

        private string noteOx;
        public string noteO
        {
            get
            {
                return noteOx;
            }
            set
            {
                noteOx = value;
            }
        }

        private int pricex;
        public int price
        {
            get
            {
                return pricex;
            }
            set
            {
                pricex = value;
            }
        }

        public override string ToString()
        {
            return
                this.name + "\t" + this.count.ToString() + "\t" + this.unitPrice.ToString() +
                "\t" + this.noteT + "\t" + this.noteS + "\t" + this.noteO + "\t" + this.price.ToString();
        }
    }
}
