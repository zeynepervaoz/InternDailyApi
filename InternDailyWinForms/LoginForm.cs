using Microsoft.Win32;
using System.Net.Http;
using System.Net.Http.Json;



namespace InternDailyWinForms
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (!rbSupervisor.Checked && !rbIntern.Checked)
            {
                MessageBox.Show("Kullanıcı türü seçiniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Kullanıcı adı giriniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Şifre giriniz");
                return;
            }

            string userType = rbIntern.Checked ? "Stajyer" : "Staj Sorumlusu";

            HttpClient client = new HttpClient();

            var response = await client.PostAsJsonAsync(
                "https://localhost:7134/api/users/login",
                new
                {
                    Username = textBox1.Text,
                    Password = textBox2.Text,
                    Usertype = userType
                }
            );

            if (!response.IsSuccessStatusCode)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                return;
            }

            RegistryKey key = Registry.CurrentUser.CreateSubKey(
                @"Software\InternDailyApp"
            );
            key.SetValue("UserType", userType);
            key.SetValue("UserName", textBox1.Text);
            key.Close();

            if (rbSupervisor.Checked)
            {
                new Form1().Show();
            }
            else
            {
                new Form2().Show();
            }

            this.Hide();
        }


        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new RegisterForm().ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
            private void LoginForm_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(
                @"Software\InternDailyApp"
            );

            if (key != null)
            {
                var lastUser = key.GetValue("UserName");
                if (lastUser != null)
                {
                    textBox1.Text = lastUser.ToString();
                }
            }
        

    }
}
}
