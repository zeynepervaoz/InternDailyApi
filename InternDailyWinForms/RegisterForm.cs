using System.Net.Http;
using System.Net.Http.Json;
using System.Windows.Forms;

namespace InternDailyWinForms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUserName.Text))
            {
                MessageBox.Show("Kullanıcı adı giriniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Şifre giriniz");
                return;
            }

            if (!rbIntern.Checked && !rbSupervisor.Checked)
            {
                MessageBox.Show("Kullanıcı türü seçiniz");
                return;
            }

            string userType = rbIntern.Checked ? "Stajyer" : "Staj Sorumlusu";

            HttpClient client = new HttpClient();

            var response = await client.PostAsJsonAsync(
                "https://localhost:7134/api/users/register",
                new
                {
                    Username = txtUserName.Text,
                    Password = txtPassword.Text,
                    Usertype = userType
                }
            );

            string responseText = await response.Content.ReadAsStringAsync();

            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("Kayıt başarılı. Giriş yapabilirsiniz.");
                this.Close();
            }
        }

    }
}
