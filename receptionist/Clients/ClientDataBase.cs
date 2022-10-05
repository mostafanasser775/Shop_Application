using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Shop_Application.receptionist.Clients
{
    internal class ClientDataBase
    {
        static bool connection = false;
        public static MySqlConnection GetConnection()
        {
            //string sql = "datasource=remotemysql.com;port=3306;username=ilVkC4MipF;password=9iFTLbGYlN;database=ilVkC4MipF";
            //string sql = "datasource=127.0.0.1;port=3306;username=root;password=;database=project";
            string sql = "datasource=sql.freedb.tech;port=3306;username=freedb_sexoman;password=rr?Etx5qB#Xjgf8;database=freedb_alnasser123";

            MySqlConnection con = new MySqlConnection(sql);
            try
            {
                con.Open();
                connection = true;
            }
            catch (MySqlException)
            {
                connection = false;
                MessageBox.Show("لم يتم الاتصال بالسيرفر من فضلك قم بالاتصال بالانترنت");

            }
            return con;
        }
        public static void AddClient(Client client)
        {

            string InsertQuery = @"insert into Clients(Client_Name,Phone,Phone1,Phone2,City,Location,Age,Whatsup,Whatsup1,Whatsup2,Notes) values (@client_name, @phone, @phone1, @phone2,@city,@location,@age,@whatsup,@whatsup1,@whatsup2,@notes)";
            MySqlConnection con = GetConnection();

            if (connection)
            {

                MySqlCommand cmd = new MySqlCommand(InsertQuery, con);

                MySqlParameter name = new MySqlParameter("@client_name", client.Name);
                cmd.Parameters.Add(name);

                MySqlParameter phone = new MySqlParameter("@phone", client.Phone);
                cmd.Parameters.Add(phone);

                MySqlParameter phone1 = new MySqlParameter("@phone1", client.Phone1);
                cmd.Parameters.Add(phone1);

                MySqlParameter phone2 = new MySqlParameter("@phone2", client.Phone2);
                cmd.Parameters.Add(phone2);

                MySqlParameter city = new MySqlParameter("@city", client.City);
                cmd.Parameters.Add(city);

                MySqlParameter location = new MySqlParameter("@location", client.Location);
                cmd.Parameters.Add(location);

                MySqlParameter whatsup = new MySqlParameter("@whatsup", client.Whatsup);
                cmd.Parameters.Add(whatsup);

                MySqlParameter whatsup1 = new MySqlParameter("@whatsup1", client.Whatsup1);
                cmd.Parameters.Add(whatsup1);

                MySqlParameter whatsup2 = new MySqlParameter("@whatsup2", client.Whatsup2);
                cmd.Parameters.Add(whatsup2);

                MySqlParameter notes = new MySqlParameter("@notes", client.Notes);
                cmd.Parameters.Add(notes);

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم بنجاح اضافة العميل");

                }
                catch (Exception)
                {
                    MessageBox.Show("يوجد بالفعل نفس اسم العميل");
                }
            }
            con.Close();
        }


        public static void UpdateClient(Client client)
        {
            string UpdateQuery = @"update Clients set Client_Name=@client_name ,Phone=@phone,Phone1=@phone1,Phone2=@phone2,City=@city,Location=@location,Age=@age,Whatsup=@whatsup,Whatsup1=@whatsup1,Whatsup2=@whatsup2,Notes=@notes where Client_Name = @client_name";

            MySqlConnection con = GetConnection();

            MySqlCommand cmd = new MySqlCommand(UpdateQuery, con);

            MySqlParameter name = new MySqlParameter("@client_name", client.Name);
            cmd.Parameters.Add(name);

            MySqlParameter phone = new MySqlParameter("@phone", client.Phone);
            cmd.Parameters.Add(phone);

            MySqlParameter phone1 = new MySqlParameter("@phone1", client.Phone1);
            cmd.Parameters.Add(phone1);

            MySqlParameter phone2 = new MySqlParameter("@phone2", client.Phone2);
            cmd.Parameters.Add(phone2);

            MySqlParameter city = new MySqlParameter("@city", client.City);
            cmd.Parameters.Add(city);

            MySqlParameter location = new MySqlParameter("@location", client.Location);
            cmd.Parameters.Add(location);

            MySqlParameter age = new MySqlParameter("@age", client.Age);
            cmd.Parameters.Add(age);

            MySqlParameter whatsup = new MySqlParameter("@whatsup", client.Whatsup);
            cmd.Parameters.Add(whatsup);

            MySqlParameter whatsup1 = new MySqlParameter("@whatsup1", client.Whatsup1);
            cmd.Parameters.Add(whatsup1);

            MySqlParameter whatsup2 = new MySqlParameter("@whatsup2", client.Whatsup2);
            cmd.Parameters.Add(whatsup2);

            MySqlParameter notes = new MySqlParameter("@notes", client.Notes);
            cmd.Parameters.Add(notes);
          
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم تعديل العميل بنحاح");

            }
            catch (Exception)
            {
                MessageBox.Show("يوجد خطا قم بالمحاولة مرة اخرى");
            }
            con.Close();

        }
        DataTable Fulltable = new DataTable();
         public static int c = 0;
        public void  Display( Guna2DataGridView dgv) {
            string Query = "SELECT * FROM Clients";
            MySqlConnection con = GetConnection();
            if (connection) {
                MySqlCommand cmd = new MySqlCommand(Query, con);
                MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                if (c == 0) {
                    Fulltable = table;
                    c++;
                }
                adp.Fill(table) ;
                dgv.DataSource = table;
            }     
            con.Close();

        }
        public  void FullData() {
            c = 0;
        }
        public  void search(DataGridView dgv,String Search) {
            DataView dv = Fulltable.DefaultView;
            dv.RowFilter = "Client_Name LIKE '" + Search + "%'";
            dgv.DataSource = dv;


           
        }
    }

}
