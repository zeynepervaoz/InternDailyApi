using InternDailyWinForms.Models;
using Microsoft.Win32;
using System.Net.Http;
using System.Net.Http.Json;

namespace InternDailyWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                HttpClient client = new HttpClient();

                var interns = await client.GetFromJsonAsync<List<string>>(
                    "https://localhost:7134/api/users/interns"
                );

                cmbIntern.Items.Clear();

                foreach (var intern in interns)
                {
                    cmbIntern.Items.Add(intern);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Stajyerler yüklenemedi");
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (cmbIntern.SelectedItem == null)
            {
                MessageBox.Show("Lütfen stajyer seçiniz");
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show("Günlük bilgi boþ olamaz");
                return;
            }

            DailyInfo info = new DailyInfo();
            info.InternName = cmbIntern.SelectedItem.ToString();
            info.Description = rtbDescription.Text;

            HttpClient client = new HttpClient();
            var response = await client.PostAsJsonAsync(
     "https://localhost:7134/api/dailyinfo",
     info
 );

            RegistryKey key = Registry.CurrentUser.CreateSubKey(
                @"Software\InternDailyApp"
            );
            key.SetValue("LastInfo", rtbDescription.Text);
            key.Close();

            MessageBox.Show("Günlük bilgi eklendi");
            rtbDescription.Clear();
        }
    }
}
