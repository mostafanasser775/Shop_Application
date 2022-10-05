using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Guna.UI2.WinForms;
using System.Threading;
using System.CodeDom;

namespace Shop_Application.receptionist.Clients
{
    public partial class ClientForm : Form
    {

        public ClientForm()
        {
            InitializeComponent();
        }

        ClientDataBase clientDataBase = new ClientDataBase();

        private void ClientForm_Load(object sender, EventArgs e)
        {
            clientDataBase.Display(guna2DataGridView1);
            if (guna2DataGridView1.Columns.Count > 6)
            {
                guna2DataGridView1.Columns[6].Visible = false;
                guna2DataGridView1.Columns[7].Visible = false;
                guna2DataGridView1.Columns[8].Visible = false;
                guna2DataGridView1.Columns[9].Visible = false;
                guna2DataGridView1.Columns[10].Visible = false;
                guna2DataGridView1.Columns[11].Visible = false;
                guna2DataGridView1.Columns[12].Visible = false;
            }
        }

        private void Guna2Button1_Click(object sender, EventArgs e)
        {
            declaration();
            Client client = new Client(_Name,_Phone,_Phone1,_Phone2,_City,_Location,_Age,_Whatsup,_Whatsup1,_Whatsup2,_Notes);
            ClientDataBase.AddClient(client);
            ClientDataBase.c = 0;
            clientDataBase.Display(guna2DataGridView1);

            ClientForm_Load(sender, e);
            Reset();
        }
        private void Guna2Button2_Click(object sender, EventArgs e)
        {




        }

        private void Phone_Icon_Click(object sender, EventArgs e)
        {
            if (Phone_Text.Text != "")
            {
                if (Phone_Text.Text[1].ToString() == "1" && Phone_Text.Text[2].ToString() == "0")
                    Phone_Icon.BackgroundImage = Properties.Resources._143859_vodafone_icon;
                else if (Phone_Text.Text[1].ToString() == "1" && Phone_Text.Text[2].ToString() == "5")
                    Phone_Icon.BackgroundImage = Properties.Resources.we_المصرية_للاتصالات_مصر;
                else if (Phone_Text.Text[1].ToString() == "1" && Phone_Text.Text[2].ToString() == "2")
                    Phone_Icon.BackgroundImage = Properties.Resources.orange;
                else if (Phone_Text.Text[1].ToString() == "1" && Phone_Text.Text[2].ToString() == "1")
                    Phone_Icon.BackgroundImage = Properties.Resources.Etisalat_Emblem;
                else
                    Phone_Icon.BackgroundImage = Properties.Resources._1c6c0d91fad08db3c80296f3f2efc884;

                panel2.Location = new Point(0, 127);

            }
           
        }

      

        private void Phone_Icon1_Click_1(object sender, EventArgs e)
        {
            if (Phone_Text1.Text != "")
            {
                if (Phone_Text1.Text[1].ToString() == "1" && Phone_Text1.Text[2].ToString() == "0")
                    Phone_Icon1.BackgroundImage = Properties.Resources._143859_vodafone_icon;
                else if (Phone_Text1.Text[1].ToString() == "1" && Phone_Text1.Text[2].ToString() == "5")
                    Phone_Icon1.BackgroundImage = Properties.Resources.we_المصرية_للاتصالات_مصر;
                else if (Phone_Text1.Text[1].ToString() == "1" && Phone_Text1.Text[2].ToString() == "2")
                    Phone_Icon1.BackgroundImage = Properties.Resources.orange;
                else if (Phone_Text1.Text[1].ToString() == "1" && Phone_Text1.Text[2].ToString() == "1")
                    Phone_Icon1.BackgroundImage = Properties.Resources.Etisalat_Emblem;
                else
                    Phone_Icon1.BackgroundImage = Properties.Resources._1c6c0d91fad08db3c80296f3f2efc884;

                panel2.Location = new Point(0, 164);
            }

        }

        private void Whatsup_Icon_Click(object sender, EventArgs e)
        {
            if (Whatsup_Text.Text != "")
            {
                if (Whatsup_Text.Text[1].ToString() == "1" && Whatsup_Text.Text[2].ToString() == "0")
                    Whatsup_Icon.BackgroundImage = Properties.Resources._143859_vodafone_icon;
                else if (Whatsup_Text.Text[1].ToString() == "1" && Whatsup_Text.Text[2].ToString() == "5")
                    Whatsup_Icon.BackgroundImage = Properties.Resources.we_المصرية_للاتصالات_مصر;
                else if (Whatsup_Text.Text[1].ToString() == "1" && Whatsup_Text.Text[2].ToString() == "2")
                    Whatsup_Icon.BackgroundImage = Properties.Resources.orange;
                else if (Whatsup_Text.Text[1].ToString() == "1" && Whatsup_Text.Text[2].ToString() == "1")
                    Whatsup_Icon.BackgroundImage = Properties.Resources.Etisalat_Emblem;
                else
                    Whatsup_Icon.BackgroundImage = Properties.Resources._1c6c0d91fad08db3c80296f3f2efc884;

                panel3.Location = new Point(0, 186);
            }

        }

        private void Whatsup_Icon1_Click(object sender, EventArgs e)
        {
            if (Whatsup_Text1.Text != "")
            {
                if (Whatsup_Text1.Text[1].ToString() == "1" && Whatsup_Text1.Text[2].ToString() == "0")
                    Whatsup_Icon1.BackgroundImage = Properties.Resources._143859_vodafone_icon;
                else if (Whatsup_Text1.Text[1].ToString() == "1" && Whatsup_Text1.Text[2].ToString() == "5")
                    Whatsup_Icon1.BackgroundImage = Properties.Resources.we_المصرية_للاتصالات_مصر;
                else if (Whatsup_Text1.Text[1].ToString() == "1" && Whatsup_Text1.Text[2].ToString() == "2")
                    Whatsup_Icon1.BackgroundImage = Properties.Resources.orange;
                else if (Whatsup_Text1.Text[1].ToString() == "1" && Whatsup_Text1.Text[2].ToString() == "1")
                    Whatsup_Icon1.BackgroundImage = Properties.Resources.Etisalat_Emblem;
                else
                    Whatsup_Icon1.BackgroundImage = Properties.Resources._1c6c0d91fad08db3c80296f3f2efc884;

                panel3.Location = new Point(0, 222);
            }
        }



        private void Search_Person_TextChanged(object sender, EventArgs e)
        {

            clientDataBase.search(guna2DataGridView1, Search_Person.Text);

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            Adding_Client adding_Client = new Adding_Client(this);
            adding_Client.ShowDialog();
        }

        public void ClientForm_Shown(object sender, EventArgs e)
        {

            Name_Text.Text = guna2DataGridView1.CurrentRow.Cells["Client_Name"].FormattedValue.ToString();
            Phone_Text.Text = guna2DataGridView1.CurrentRow.Cells["Phone"].FormattedValue.ToString();
            Phone_Text1.Text = guna2DataGridView1.CurrentRow.Cells["Phone1"].FormattedValue.ToString();
            Phone_Text2.Text = guna2DataGridView1.CurrentRow.Cells["Phone2"].FormattedValue.ToString();
            City_Text.Text = guna2DataGridView1.CurrentRow.Cells["City"].FormattedValue.ToString();
            Location_Text.Text = guna2DataGridView1.CurrentRow.Cells["Location"].FormattedValue.ToString();
            Age_Text.Text = guna2DataGridView1.CurrentRow.Cells["Age"].FormattedValue.ToString();
            Whatsup_Text.Text = guna2DataGridView1.CurrentRow.Cells["Whatsup"].FormattedValue.ToString();
            Whatsup_Text1.Text = guna2DataGridView1.CurrentRow.Cells["Whatsup1"].FormattedValue.ToString();
            Whatsup_Text2.Text = guna2DataGridView1.CurrentRow.Cells["Whatsup2"].FormattedValue.ToString();
            Notes_Text.Text = guna2DataGridView1.CurrentRow.Cells["Notes"].FormattedValue.ToString();

            panel2.Location = new Point(0, 90);
            panel3.Location = new Point(0, 149);

            Phone_Icon.BackgroundImage = Properties.Resources.add;
            Phone_Icon1.BackgroundImage = Properties.Resources.add;
            Phone_Icon2.BackgroundImage = Properties.Resources.add;

            Whatsup_Icon.BackgroundImage = Properties.Resources.add;
            Whatsup_Icon1.BackgroundImage = Properties.Resources.add;
            Whatsup_Icon2.BackgroundImage = Properties.Resources.add;


            if (guna2DataGridView1.CurrentRow.Cells["Phone1"].FormattedValue.ToString() != "")
                Phone_Icon_Click(sender, e);

            if (guna2DataGridView1.CurrentRow.Cells["Phone2"].FormattedValue.ToString() != "")
                Phone_Icon1_Click_1(sender, e);

            if (guna2DataGridView1.CurrentRow.Cells["Whatsup1"].FormattedValue.ToString() != "")
                Whatsup_Icon_Click(sender, e);

            if (guna2DataGridView1.CurrentRow.Cells["Phone2"].FormattedValue.ToString() != "")
                Whatsup_Icon1_Click(sender, e);

        }


    }
    }


