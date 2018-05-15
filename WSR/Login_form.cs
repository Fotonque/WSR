using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WSR {
    public partial class Login_form : Form {
        public Login_form() {

            InitializeComponent();
            User.Login = null;
            User.Password = null;
            User.Role = null;
        }

        private void LoginIn_button_Click(object sender, EventArgs e) {
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-9OB2E6G;Initial Catalog=WSRtraining;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True")) {
                connection.Open();
                string query = "select * from dbo.users"; 
                using (SqlCommand command = new SqlCommand(query, connection)) {
                    SqlDataReader reader = command.ExecuteReader();
                    bool userFound = false;
                    userFound = UserCheck(reader, userFound);
                    reader.Close();
                    FormOpen(userFound);
                }
            }
        }

        private void FormOpen(bool userFound) {
            if (userFound == true) {
                if (User.Role == "Admin") {
                    Admin_form admin_ = new Admin_form();
                    this.Hide();
                    admin_.Show();
                } else if (User.Role == "Customer") {
                    Customer_form customer_ = new Customer_form();
                    this.Hide();
                    customer_.Show();
                } else if (User.Role == "Manager") {
                    Manager_form manager_ = new Manager_form();
                    this.Hide();
                    manager_.Show();
                } else if (User.Role == "Storage") {
                    Warehouser_form warehouser_ = new Warehouser_form();
                    this.Hide();
                    warehouser_.Show();
                } else {
                    MessageBox.Show("User does't have any role");
                }
            } else {
                MessageBox.Show("Login or Password is incorrect");
            }
        }

        private bool UserCheck(SqlDataReader reader, bool userFound) {
            while (reader.Read()) {
                User.Login = reader[0].ToString();
                User.Password = reader[1].ToString();
                User.Role = reader[2].ToString();
                if ((User.Login == Login_textbox.Text) && (User.Password == Password_textbox.Text)) {
                    userFound = true;
                    break;
                }
            }

            return userFound;
        }
    }
}
