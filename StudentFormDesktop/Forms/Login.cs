using StudentFormDesktop.Data;
using StudentFormDesktop.Forms;
using StudentFormDesktop.Models;

namespace StudentFormDesktop
{
    public partial class Login : Form
    {
        List<Student> students = ApplicationDbContext.Students;
        public Login()
        {
            InitializeComponent();
        }

        private void Register_Panel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register(this);
            register.Show();




        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Update update = new Update();
            update.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_Shown(object sender, EventArgs e)
        {

        }

        private void Login_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true)
            {
                List<Student> students = ApplicationDbContext.Students;
                dataGridView1.Rows.Clear();

                for (int i = 0; i < students.Count; i++)
                {
                    dataGridView1.Rows.Add(students[i].Id,
                                           students[i].Name,
                                           students[i].Surname,
                                           students[i].Email,
                                           students[i].Faculty,
                                           students[i].Profession);
                }
            }
        }
    }
}