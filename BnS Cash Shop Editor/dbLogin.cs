using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BnS_Cash_Shop_Editor
{
    public partial class dbLogin : Form
    {
        private static Form _main;
        public static Form instance;
        public dbLogin()
        {
            InitializeComponent();
            instance = this;
        }

        private void btn_dbConnect_Click(object sender, EventArgs e)
        {
            var _connection = dbHelper.dbConnect(DataSource: tb_IP.Text, UserID: tb_dbUser.Text, Password: tb_dbPass.Text);
            var _result = dbHelper.IsServerConnected(_connection.ConnectionString);

            if (_result)
            {
                _main = new Form1();
                _main.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Can't Connect to Server Database!");
            }
        }
    }
}
