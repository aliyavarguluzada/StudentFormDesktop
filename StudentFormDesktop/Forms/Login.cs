using StudentFormDesktop.Data;
using StudentFormDesktop.Forms;

namespace StudentFormDesktop
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Register_Panel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(this);
            register.Show();

            _ = ApplicationDbContext.Students;
            int index = 1;
            //dataGridView1.Rows.Add(ApplicationDbContext.Students[index - 1 ].Name);
        }
    }
}