namespace StudentFormDesktop.Forms
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
            txbx_Name = new TextBox();
            txbx_Surname = new TextBox();
            txbx_Email = new TextBox();
            txbx_Address = new TextBox();
            txbx_Faculty = new TextBox();
            txbx_Profession = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Register_btn = new Button();
            SuspendLayout();
            // 
            // txbx_Name
            // 
            txbx_Name.Location = new Point(94, 50);
            txbx_Name.Name = "txbx_Name";
            txbx_Name.Size = new Size(132, 27);
            txbx_Name.TabIndex = 0;
            // 
            // txbx_Surname
            // 
            txbx_Surname.Location = new Point(94, 115);
            txbx_Surname.Name = "txbx_Surname";
            txbx_Surname.Size = new Size(132, 27);
            txbx_Surname.TabIndex = 1;
            // 
            // txbx_Email
            // 
            txbx_Email.Location = new Point(94, 182);
            txbx_Email.Name = "txbx_Email";
            txbx_Email.Size = new Size(132, 27);
            txbx_Email.TabIndex = 2;
            // 
            // txbx_Address
            // 
            txbx_Address.Location = new Point(94, 253);
            txbx_Address.Name = "txbx_Address";
            txbx_Address.Size = new Size(132, 27);
            txbx_Address.TabIndex = 3;
            // 
            // txbx_Faculty
            // 
            txbx_Faculty.Location = new Point(94, 317);
            txbx_Faculty.Name = "txbx_Faculty";
            txbx_Faculty.Size = new Size(132, 27);
            txbx_Faculty.TabIndex = 4;
            // 
            // txbx_Profession
            // 
            txbx_Profession.Location = new Point(94, 380);
            txbx_Profession.Name = "txbx_Profession";
            txbx_Profession.Size = new Size(132, 27);
            txbx_Profession.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 9);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 92);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 7;
            label2.Text = "Surname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 159);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 8;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(94, 230);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 9;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 294);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 10;
            label5.Text = "Faculty";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 357);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 11;
            label6.Text = "Profession";
            // 
            // Register_btn
            // 
            Register_btn.Location = new Point(417, 317);
            Register_btn.Name = "Register_btn";
            Register_btn.Size = new Size(94, 29);
            Register_btn.TabIndex = 12;
            Register_btn.Text = "Register";
            Register_btn.UseVisualStyleBackColor = true;
            Register_btn.Click += Register_btn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Register_btn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbx_Profession);
            Controls.Add(txbx_Faculty);
            Controls.Add(txbx_Address);
            Controls.Add(txbx_Email);
            Controls.Add(txbx_Surname);
            Controls.Add(txbx_Name);
            Name = "Register";
            Text = "Register";
            FormClosed += Register_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbx_Name;
        private TextBox txbx_Surname;
        private TextBox txbx_Email;
        private TextBox txbx_Address;
        private TextBox txbx_Faculty;
        private TextBox txbx_Profession;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button Register_btn;
    }
}