using Microsoft.Data.SqlClient;


namespace QuanLy_QuanAn
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

    
        private void btn_Login_Click(object sender, EventArgs e)
        { 
            string username = txt_Username.Text;
            string password = txt_Pass.Text;
            if (Login(username, password))
            {
                //MessageBox.Show("Login success");
                this.Hide();
                frmMenu frmMenu = new frmMenu();
                frmMenu.ShowDialog();

            }
            else
            {
                MessageBox.Show("Information is incorrect! Please try again!");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit?", "NotificationStatus", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }


        private bool Login(string username, string password)
        {
            //string connectionString = "Data Source=(local);Initial Catalog=YourDatabase;Integrated Security=True";
            string connectionString = "Server=localhost;Database=QuanLyQuanAn;User Id=sa;Password=123;TrustServerCertificate=True";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Account WHERE Username = @username AND Password = @password";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            SqlDataReader reader = command.ExecuteReader();
            return reader.HasRows;
        }
        private bool ValidatePassword(string password)
        {
            // Validate password length
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.");
                return false;
            }

            // Validate password complexity
            bool hasUppercase = false;
            bool hasLowercase = false;
            bool hasNumber = false;
            bool hasSymbol = false;

            foreach (char c in password)
            {
                if (Char.IsUpper(c))
                {
                    hasUppercase = true;
                }
                else if (Char.IsLower(c))
                {
                    hasLowercase = true;
                }
                else if (Char.IsDigit(c))
                {
                    hasNumber = true;
                }
                else if (Char.IsSymbol(c) || Char.IsPunctuation(c))
                {
                    hasSymbol = true;
                }
            }

            if (!(hasUppercase && hasLowercase && hasNumber && hasSymbol))
            {
                MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one number, and one symbol.");
                return false;
            }

            // Password is valid
            return true;
        }

        private void txt_Pass_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_Show_CheckedChanged(object sender, EventArgs e)
        {
            if (cbo_Show.Checked)
            {
                txt_Pass.UseSystemPasswordChar = false;
            }
            else
            {
                txt_Pass.UseSystemPasswordChar = true;
            }
        }

        private void lb_Password_Click(object sender, EventArgs e)
        {

        }
    }
}