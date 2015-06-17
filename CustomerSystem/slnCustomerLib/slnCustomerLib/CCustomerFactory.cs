using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ex1
{
    public class CCustomerFactory
    {
        List<CCustomer> customers = new List<CCustomer>();
        int count = 0;

        public CCustomerFactory()
        {
            loadData();
        }

        public void insert(CCustomer customer)
        {
            customers.Add(customer);
            string sql = "INSERT INTO AspnetForEx3Table1 (";
            sql += " fName, ";
            sql += " fPhone, ";
            sql += " fMail, ";
            sql += " fAddress ";
            sql += " )VALUES( ";
            sql += " '" + customer.name + "', ";
            sql += " '" + customer.phone + "', ";
            sql += " '" + customer.mail + "', ";
            sql += " '" + customer.addrs + "') ";
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = @"Data Source=CR4-06\MSSQLSERVER2013;Initial Catalog=ASPNET_for_ex3;Integrated Security=True";
            sds.InsertCommand = sql;
            sds.Insert();
        }

        public void delete(int intId)
        {
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = @"Data Source=CR4-06\MSSQLSERVER2013;Initial Catalog=ASPNET_for_ex3;Integrated Security=True";
            sds.DeleteCommand = "DELETE FROM AspnetForEx3Table1 WHERE fId=" + intId.ToString();
            sds.Delete();
            foreach (CCustomer c in customers)
            {
                if (c.id == intId)
                {
                    customers.Remove(c);
                    return;
                }
            }
        }

        private void loadData()
        {
            SqlDataSource sds = new SqlDataSource();
            sds.ConnectionString = @"Data Source=CR4-06\MSSQLSERVER2013;Initial Catalog=ASPNET_for_ex3;Integrated Security=True";
            sds.SelectCommand = "SELECT * FROM AspnetForEx3Table1";
            DataView dv = sds.Select(DataSourceSelectArguments.Empty) as DataView;

            if (dv.Count > 0)
            {
                for (int i = 0; i < dv.Count; i++)
                {
                    CCustomer customer = new CCustomer();
                    customer.addrs = dv.Table.Rows[i]["fAddress"].ToString();
                    customer.mail = dv.Table.Rows[i]["fMail"].ToString();
                    customer.id = Convert.ToInt32(dv.Table.Rows[i]["fId"].ToString());
                    customer.name = dv.Table.Rows[i]["fName"].ToString();
                    customer.phone = dv.Table.Rows[i]["fPhone"].ToString();
                    customers.Add(customer);
                }

            }

            ///*
            //customers[0] = new CCustomer();
            //customers[0].id = 1;
            //customers[0].name = "Tom";
            //customers[0].phone = "071456895";
            //customers[0].mail = "071456895@iii.org.tw";
            //customers[0].addrs = "ksh";

            //customers[1] = new CCustomer();
            //customers[1].id = 2;
            //customers[1].name = "Peter";
            //customers[1].phone = "074569852";
            //customers[1].mail = "074569852@iii.org.tw";
            //customers[1].addrs = "ksh";

            //customers[2] = new CCustomer();
            //customers[2].id = 3;
            //customers[2].name = "Mary";
            //customers[2].phone = "073256851";
            //customers[2].mail = "073256851@iii.org.tw";
            //customers[2].addrs = "ksh";
            //*/

            //customers[0] = new CCustomer()
            //{
            //    id = 1,
            //    name = "Tom",
            //    phone = "071456895",
            //    mail = "071456895@iii.org.tw",
            //    addrs = "ksh"
            //};

            //customers[1] = new CCustomer()
            //{
            //    id = 2,
            //    name = "Peter",
            //    phone = "074569852",
            //    mail = "074569852@iii.org.tw",
            //    addrs = "tpe"
            //};

            //customers[2] = new CCustomer()
            //{
            //    id = 3,
            //    name = "Mary",
            //    phone = "073256851",
            //    mail = "073256851@iii.org.tw",
            //    addrs = "tna"
            //};
        }

        public void moveFirst()
        {
            count = 0;
        }

        public void moveLeft()
        {
            count--;
            if (count < 0)
            {
                count = 0;
            }
        }

        public void moveRight()
        {
            count++;
            if (count > customers.Count - 1)
            {
                count = customers.Count - 1;
            }
        }

        public void moveLast()
        {
            count = customers.Count - 1;
        }

        public void moveTo(int p)
        {
            count = p;
        }

        public CCustomer getById(string p)
        {
            try
            {
                int intId = Convert.ToInt32(p);

                for (int i = 0; i < customers.Count; i++)
                {
                    if (customers[i].id == intId)
                    {
                        count = i;
                        return customers[i];
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

        public CCustomer getCurrent()
        {
            return customers[count];
        }
        public CCustomer[] getAll()
        {
            return customers.ToArray();
        }
    }
}
