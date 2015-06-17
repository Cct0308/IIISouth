using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverage_POS__Simple_
{
    public class BeverageFactory
    {
        protected Beverage[] beveragesDetails = new Beverage[45];
        int count = 0;

        public BeverageFactory()
        {
            loadData();
        }

        private void loadData()
        {
            beveragesDetails[0] = new Beverage()
            {
                no = 1,
                name = "茉莉綠茶  ",
                unitPrice = 25
            };

            beveragesDetails[1] = new Beverage()
            {
                no = 2,
                name = "阿薩姆紅茶",
                unitPrice = 25
            };


            beveragesDetails[2] = new Beverage()
            {
                no = 3,
                name = "四季春青茶",
                unitPrice = 25
            };

            beveragesDetails[3] = new Beverage()
            {
                no = 4,
                name = "黃金烏龍  ",
                unitPrice = 25
            };

            beveragesDetails[4] = new Beverage()
            {
                no = 5,
                name = "檸檬綠茶  ",
                unitPrice = 35
            };

            beveragesDetails[5] = new Beverage()
            {
                no = 6,
                name = "梅果綠茶  ",
                unitPrice = 45
            };

            beveragesDetails[6] = new Beverage()
            {
                no = 7,
                name = "８冰綠茶  ",
                unitPrice = 45
            };

            beveragesDetails[7] = new Beverage()
            {
                no = 8,
                name = "多多綠茶  ",
                unitPrice = 45
            };

            beveragesDetails[8] = new Beverage()
            {
                no = 9,
                name = "蜂蜜綠茶  ",
                unitPrice = 45
            };

            beveragesDetails[9] = new Beverage()
            {
                no = 10,
                name = "冰淇淋紅茶",
                unitPrice = 45
            };

            beveragesDetails[10] = new Beverage()
            {
                no = 11,
                name = "芒果青茶  ",
                unitPrice = 45
            };

            beveragesDetails[11] = new Beverage()
            {
                no = 12,
                name = "鮮柚綠茶  ",
                unitPrice = 55
            };

            beveragesDetails[12] = new Beverage()
            {
                no = 13,
                name = "紅茶拿鐵  ",
                unitPrice = 55
            };

            beveragesDetails[13] = new Beverage()
            {
                no = 14,
                name = "烏龍拿鐵  ",
                unitPrice = 55
            };

            beveragesDetails[14] = new Beverage()
            {
                no = 15,
                name = "珍珠紅茶拿鐵",
                unitPrice = 55
            };

            beveragesDetails[15] = new Beverage()
            {
                no = 16,
                name = "波霸紅茶拿鐵",
                unitPrice = 55
            };

            beveragesDetails[16] = new Beverage()
            {
                no = 17,
                name = "榛果紅茶拿鐵",
                unitPrice = 65
            };

            beveragesDetails[17] = new Beverage()
            {
                no = 18,
                name = "焦糖紅茶拿鐵",
                unitPrice = 65
            };

            beveragesDetails[18] = new Beverage()
            {
                no = 19,
                name = "仙草紅茶拿鐵",
                unitPrice = 55
            };

            beveragesDetails[19] = new Beverage()
            {
                no = 20,
                name = "布丁紅茶拿鐵",
                unitPrice = 70
            };

            beveragesDetails[20] = new Beverage()
            {
                no = 21,
                name = "冰淇淋紅茶拿鐵",
                unitPrice = 70
            };

            beveragesDetails[21] = new Beverage()
            {
                no = 22,
                name = "巧克力拿鐵",
                unitPrice = 65
            };

            beveragesDetails[22] = new Beverage()
            {
                no = 23,
                name = "可可芭蕾拿鐵",
                unitPrice = 70
            };

            beveragesDetails[23] = new Beverage()
            {
                no = 24,
                name = "奶香紅茶  ",
                unitPrice = 45
            };

            beveragesDetails[24] = new Beverage()
            {
                no = 25,
                name = "奶香綠茶  ",
                unitPrice = 45
            };

            beveragesDetails[25] = new Beverage()
            {
                no = 26,
                name = "烏龍奶茶  ",
                unitPrice = 45
            };

            beveragesDetails[26] = new Beverage()
            {
                no = 27,
                name = "珍珠奶茶  ",
                unitPrice = 45
            };

            beveragesDetails[27] = new Beverage()
            {
                no = 28,
                name = "波霸奶茶  ",
                unitPrice = 45
            };

            beveragesDetails[28] = new Beverage()
            {
                no = 29,
                name = "焦糖奶茶  ",
                unitPrice = 50
            };

            beveragesDetails[29] = new Beverage()
            {
                no = 30,
                name = "仙草奶茶  ",
                unitPrice = 45
            };

            beveragesDetails[30] = new Beverage()
            {
                no = 31,
                name = "布丁奶茶  ",
                unitPrice = 55
            };

            beveragesDetails[31] = new Beverage()
            {
                no = 32,
                name = "冰淇淋奶茶",
                unitPrice = 55
            };

            beveragesDetails[32] = new Beverage()
            {
                no = 33,
                name = "紅茶瑪奇朵",
                unitPrice = 45
            };

            beveragesDetails[33] = new Beverage()
            {
                no = 34,
                name = "巧克力奶茶",
                unitPrice = 50
            };

            beveragesDetails[34] = new Beverage()
            {
                no = 35,
                name = "可可芭蕾  ",
                unitPrice = 55
            };

            beveragesDetails[35] = new Beverage()
            {
                no = 36,
                name = "鮮檸檬汁  ",
                unitPrice = 55
            };

            beveragesDetails[36] = new Beverage()
            {
                no =37 ,
                name = "葡萄柚汁  ",
                unitPrice = 55
            };

            beveragesDetails[37] = new Beverage()
            {
                no = 38,
                name = "金桔檸檬  ",
                unitPrice = 55
            };

            beveragesDetails[38] = new Beverage()
            {
                no = 39,
                name = "檸檬梅子  ",
                unitPrice = 55
            };

            beveragesDetails[39] = new Beverage()
            {
                no = 40,
                name = "檸檬多多  ",
                unitPrice = 65
            };

            beveragesDetails[40] = new Beverage()
            {
                no = 41,
                name = "鮮檸檬蜜  ",
                unitPrice = 65
            };

            beveragesDetails[41] = new Beverage()
            {
                no = 42,
                name = "葡萄柚多多",
                unitPrice = 65
            };

            beveragesDetails[42] = new Beverage()
            {
                no = 43,
                name = "金桔檸檬綠",
                unitPrice = 65
            };

            beveragesDetails[43] = new Beverage()
            {
                no = 44,
                name = "檸檬冬瓜  ",
                unitPrice = 45
            };

            beveragesDetails[44] = new Beverage()
            {
                no = 45,
                name = "蜂蜜蘆薈  ",
                unitPrice = 45
            };
        }

        public Beverage moveTo(int n)
        {
            try
            {
                int intCount = n;

                for (int i = 0; i < beveragesDetails.Length; i++)
                {
                    if (beveragesDetails[i].no == intCount)
                    {
                        count = i;
                        return beveragesDetails[i];
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public void addChar()
        {
            if (beveragesDetails[count].name.Length < 5)
            {
                beveragesDetails[count].name += "\t";
            }
        }
    }    
}
