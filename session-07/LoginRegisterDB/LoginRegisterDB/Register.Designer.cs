
namespace LoginRegisterDB
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.reg_register = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.reg_username = new System.Windows.Forms.Label();
            this.names = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.reg_password = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Have account ? ";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(242, 392);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 14;
            this.login.Text = "Login";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(306, 308);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 13;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // reg_register
            // 
            this.reg_register.Location = new System.Drawing.Point(131, 308);
            this.reg_register.Name = "reg_register";
            this.reg_register.Size = new System.Drawing.Size(75, 23);
            this.reg_register.TabIndex = 12;
            this.reg_register.Text = "Register";
            this.reg_register.UseVisualStyleBackColor = true;
            this.reg_register.Click += new System.EventHandler(this.reg_register_Click);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(131, 171);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(237, 22);
            this.username.TabIndex = 11;
            this.username.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(131, 115);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(237, 22);
            this.name.TabIndex = 10;
            this.name.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // reg_username
            // 
            this.reg_username.AutoSize = true;
            this.reg_username.Location = new System.Drawing.Point(9, 171);
            this.reg_username.Name = "reg_username";
            this.reg_username.Size = new System.Drawing.Size(73, 17);
            this.reg_username.TabIndex = 9;
            this.reg_username.Text = "Username";
            this.reg_username.Click += new System.EventHandler(this.label2_Click);
            // 
            // names
            // 
            this.names.AutoSize = true;
            this.names.Location = new System.Drawing.Point(9, 118);
            this.names.Name = "names";
            this.names.Size = new System.Drawing.Size(43, 17);
            this.names.TabIndex = 8;
            this.names.Text = "name";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(131, 222);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(237, 22);
            this.password.TabIndex = 17;
            // 
            // reg_password
            // 
            this.reg_password.AutoSize = true;
            this.reg_password.Location = new System.Drawing.Point(9, 222);
            this.reg_password.Name = "reg_password";
            this.reg_password.Size = new System.Drawing.Size(69, 17);
            this.reg_password.TabIndex = 16;
            this.reg_password.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(2, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(441, 100);
            this.panel1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(173, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Register";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LoginRegisterDB.Properties.Resources.PinClipart_com_student_thinking_clipart_463193;
            this.pictureBox1.Location = new System.Drawing.Point(28, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.password);
            this.Controls.Add(this.reg_password);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.login);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.reg_register);
            this.Controls.Add(this.username);
            this.Controls.Add(this.name);
            this.Controls.Add(this.reg_username);
            this.Controls.Add(this.names);
            this.Name = "Register";
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button reg_register;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label reg_username;
        private System.Windows.Forms.Label names;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label reg_password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}