using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class CDconxion
    {
        SqlConnection Conexion = new SqlConnection("Data Source=SQL5110.site4now.net;Initial Catalog=db_a9830d_naturvida;User Id=db_a9830d_naturvida_admin;Password=Jose202018*");
       
       //SqlConnection Conexion = new SqlConnection("Server=BUCDFPCSEFSD021;Database=NaturVida;Integrated Security=True");
       //SqlConnection Conexion = new SqlConnection("Server=LAPTOP-OLT4063B\\SQLEXPRESS;Database=NaturVida;Integrated Security=True");

        public SqlConnection abrirconexion()
        {
            if(Conexion.State==ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }


        public SqlConnection Cerrarconxion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }

    }
}
