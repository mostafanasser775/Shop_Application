using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Shop_Application.receptionist.Clients;
using Shop_Application.receptionist;

namespace Shop_Application
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            guna2Button2.PerformClick();

            //load clients data
            ClientForm clients = new ClientForm
            {
                TopLevel = false,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            panel2.Controls.Add(clients);
            panel2.Tag = clients;
            clients.BringToFront();
            clients.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Guna2ToggleSwitch1_CheckedChanged(sender, e);

        }
    
        async Task Love() {
            while (true)
            {
                try
                {
                    Ping myPing = new Ping();
                    String host = "google.com";
                    byte[] buffer = new byte[32];
                    int timeout = 1000;
                    PingOptions pingOptions = new PingOptions();
                    PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                    if (reply.Status == IPStatus.Success)
                    {
                        label6.Text = "متصل بالانترنت";
                        guna2CircleButton1.FillColor = Color.Lime;

                    }
                }
                catch (Exception)
                {
                    label6.Text = "غير متصل";
                    guna2CircleButton1.FillColor = Color.Red;
                }

                await Task.Delay(5000);

            }
        }
        private void Guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            _ = Love();

        }
    }
}
