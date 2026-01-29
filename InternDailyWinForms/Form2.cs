using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InternDailyWinForms.Models;
using Microsoft.Win32;
using System.Net.Http.Json;


namespace InternDailyWinForms
{
    public partial class Form2 : Form
    {
        private string userName = "";

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(
                @"Software\InternDailyApp"
            );

            if (key != null)
            {
                var value = key.GetValue("UserName");
                if (value != null)
                {
                    userName = value.ToString();
                    lblWelcome.Text = "Hoş geldin " + userName;
                }
            }
        }


        private async void btnGet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(userName))
            {
                MessageBox.Show("Kullanıcı bilgisi bulunamadı");
                return;
            }

            HttpClient client = new HttpClient();
            var allInfos = await client.GetFromJsonAsync<List<DailyInfo>>(
                "https://localhost:7134/api/dailyinfo"
            );

            listBoxDailyInfos.Items.Clear();

            foreach (var info in allInfos)
            {
                if (info.InternName == userName)
                {
                    listBoxDailyInfos.Items.Add(
                        info.Date.ToShortDateString() + " - " + info.Description
                    );
                }
            }

            if (listBoxDailyInfos.Items.Count == 0)
            {
                listBoxDailyInfos.Items.Add("Henüz size ait kayıt bulunmamaktadır.");
            }
        }

   
    }
}
