namespace StudentFormDesktop
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Register_Panel_btn = new Button();
            Add_Panel_btn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Register_Panel_btn
            // 
            Register_Panel_btn.Location = new Point(221, 299);
            Register_Panel_btn.Name = "Register_Panel_btn";
            Register_Panel_btn.Size = new Size(138, 55);
            Register_Panel_btn.TabIndex = 0;
            Register_Panel_btn.Text = "RegPanel";
            Register_Panel_btn.UseVisualStyleBackColor = true;
            // 
            // Add_Panel_btn
            // 
            Add_Panel_btn.Location = new Point(508, 299);
            Add_Panel_btn.Name = "Add_Panel_btn";
            Add_Panel_btn.Size = new Size(138, 55);
            Add_Panel_btn.TabIndex = 1;
            Add_Panel_btn.Text = "Smt_Add";
            Add_Panel_btn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 25);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(776, 205);
            dataGridView1.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Add_Panel_btn);
            Controls.Add(Register_Panel_btn);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Register_Panel_btn;
        private Button Add_Panel_btn;
        private DataGridView dataGridView1;
    }
}