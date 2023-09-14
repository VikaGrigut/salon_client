using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;
using System.Net.Sockets;
using System.Text.Json;

namespace курсач
{
    public partial class MakeServiceForm : Form
    {
        public string loginUser;

        public MakeServiceForm()
        {
            InitializeComponent();
        }
        public MakeServiceForm(string login)
        {
            InitializeComponent();
            loginUser = login;
        }

        private void servicesBox_TextChanged(object sender, EventArgs e)
        {
            if (servicesBox.Text == "Стрижка")
            {
                PriceBox.Text = "35";
            }
            else if (servicesBox.Text == "Укладка волос")
            {
                PriceBox.Text = "23";
            }
            else if (servicesBox.Text == "Окрашивание волос")
            {
                PriceBox.Text = "54";
            }
            else if (servicesBox.Text == "Маникюр")
            {
                PriceBox.Text = "27";
            }
            else if (servicesBox.Text == "Массаж")
            {
                PriceBox.Text = "48";
            }
            else if (servicesBox.Text == "Макияж")
            {
                PriceBox.Text = "64";
            }
            else
            {
                MessageBox.Show("Нет такой услуги!!!");
            }
        }
        private void enrollButton_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>() { DateTimePicker.Text , servicesBox.Text, PriceBox.Text};
            Socket socket = Connection.GetSocket();
            Request request = new Request("makeService", JsonSerializer.Serialize(data));
            string mes = JsonSerializer.Serialize(request);
            var messageBytes = Encoding.UTF8.GetBytes(mes);
            socket.Send(messageBytes, SocketFlags.None);
            var buffer = new byte[1_024];
            Task<int> received = socket.ReceiveAsync(buffer, SocketFlags.None);
            var response = Encoding.UTF8.GetString(buffer, 0, received.Result);
            Response response1 = JsonSerializer.Deserialize<Response>(response);
            if (response1.command == "no")
            {
                if(response1.data == "Введена некорректная дата. Выберете другую дату.")
                {
                    MessageBox.Show(response1.data);
                    DateTime date = DateTime.Today;
                    DateTimePicker.Text = date.ToLongDateString();
                }
                else
                {
                    MessageBox.Show(response1.data);
                }

            }
            else
            {
                MessageBox.Show(response1.data);
                ProfileForm profileForm = new ProfileForm();
                profileForm.Show();
                this.Hide();
            }
        }

        private void servicesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void PaymentBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PriceBox_TextChanged(object sender, EventArgs e)
        {
            PriceBox.ReadOnly = true;
        }

        private void backLabel_Click(object sender, EventArgs e)
        {

            ProfileForm profileForm = new ProfileForm();
            profileForm.Show();
            this.Hide();
        }

        private void MakeServiceForm_Load(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
