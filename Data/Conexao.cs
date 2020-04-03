using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailService.Data
{
   public class Conexao
    {
        public static SqlConnection conection()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"";
            cn.Open();

            return cn;

        }
    }
}
