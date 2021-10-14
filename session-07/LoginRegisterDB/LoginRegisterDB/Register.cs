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
    public partial class Register : Form
    {
        Config db = new Config();

        public Register()
        {
            InitializeComponent();
            db.Connect("userdata");
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reg_register_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Register ?", "Registration Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.Execute(String.Format("INSERT INTO `user_info` (`id`, `names`, `username`, `password`) VALUES (NULL, '{0}', '{1}', '{2}')", name.Text, username.Text, password.Text));
                MessageBox.Show("Registration is successful");
                this.Close();
            }
            
        }
    }
}
