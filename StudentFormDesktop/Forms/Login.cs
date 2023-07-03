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
                dataGridView1.Rows.Clear();

                for (int i = 0; i < students.Count; i++)
                {
                    dataGridView1.Rows.Add(students[i].Id,
                                           students[i].Name,
                                           students[i].Surname,
                                           students[i].Email,
                                           students[i].Address,
                                           students[i].Faculty,
                                           students[i].Profession);
                    break;
                }
            }
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

                MessageBox.Show(id);
                Update update = new Update(Convert.ToInt32(id));
                update.Show();
                this.Hide();
            
            
        }
    }
}