using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Mob_dal
{
    public class MobdetailsDAL
    {
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataSet ds;

        public static SqlConnection connect()
        {
            string Connection = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection con = new SqlConnection(Connection);

            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            else
            {
                con.Open();
            }

            return con;
        }

        public bool DML_Oppretion(string Query)
        {
            cmd = new SqlCommand(Query, MobdetailsDAL.connect());
            int x = cmd.ExecuteNonQuery();
            if (x==1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable SalectAll(string Query)
        {

            sda = new SqlDataAdapter(Query, MobdetailsDAL.connect());
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

    }
}
