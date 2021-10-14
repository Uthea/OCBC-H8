using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegisterDB
{   
    public partial class Form1 : Form
    {
        //initialize connection
        Config db = new Config();
        public Form1()
        {
            InitializeComponent();
            db.Connect("userdata");
        }

        private void register_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }

        private void login_Click(object sender, EventArgs e)
        {
            db.ExecuteSelect(String.Format("SELECT * FROM `user_info` where username='{0}' and password='{1}'",
                username.Text, password.Text));

            if (db.Count() == 1)
            {
                MessageBox.Show("Success You Will login as " + db.Results(0, "names"));
            }
            else { MessageBox.Show("Wrong username and password combination"); }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
