using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace BBDD
{
    public class Base
    {
        SqlConnection cnx; //Conector para acceder a la bbdd

        public int Start()
        {
            try
            {
                string dataSource = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brcri\OneDrive\Escritorio\Proyecto\Prueba_Omega\BBDD\Database1.mdf";
                cnx = new SqlConnection(dataSource);
                cnx.Open();
            }
            catch (SqlException)
            {
                return -1;
            }
            return 0;
        }

        //public DataTable Datos_Usuario()
        //{
        //    SqlDataAdapter adp;
        //    DataTable dt = new DataTable();
        //    string command = "SELECT*FROM Users";
        //    adp = new SqlDataAdapter(command, cnx);
        //    adp.Fill(dt);
        //    return dt;
        //}

        public void Datos_Usuario(int ID, int psw)
        {
            SqlCommand cmd = new SqlCommand("SELECT UserID, Password FROM Users WHERE UserID=@userid AND Password=@password", cnx);
            cmd.Parameters.AddWithValue("userid", ID);
            cmd.Parameters.AddWithValue("password", psw);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows.Count == 1)
            {
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }


    }
}
