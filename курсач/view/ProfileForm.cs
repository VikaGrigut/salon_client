using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Net.Sockets;

namespace курсач
{
    public partial class ProfileForm : Form
    {
        public ProfileForm()
        {
            InitializeComponent();
            payButton.Hide();
            paybox.Hide();
            Socket socket = Connection.GetSocket();
            Request request = new Request("profile", "");
            string mes = JsonSerializer.Serialize(request);
            var messageBytes = Encoding.UTF8.GetBytes(mes);
            socket.Send(messageBytes, SocketFlags.None);
            var buffer = new byte[1_1000];
            var received = socket.Receive(buffer, SocketFlags.None);
            var response = Encoding.UTF8.GetString(buffer, 0, received);
            List<User> userProf = JsonSerializer.Deserialize<List<User>>(response);
            User user = userProf[0];
            nameUser.Text = user.Name;
            ageUser.Text = user.Age.ToString();
            phoneUser.Text = user.NumberPhone;
            balanceUser.Text = user.Balance.ToString();
        }

        private void makeService_Click(object sender, EventArgs e)
        {
            MakeServiceForm makeServiceForm = new MakeServiceForm();
            makeServiceForm.Show();
            this.Hide();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            
        }

        private void myService_Click(object sender, EventArgs e)
        {
            Socket socket = Connection.GetSocket();
            Request request = new Request("myService", "");
            string mes = JsonSerializer.Serialize(request);
            var messageBytes = Encoding.UTF8.GetBytes(mes);
            socket.Send(messageBytes, SocketFlags.None);
            var buffer = new byte[1_024];
            var received = socket.Receive(buffer, SocketFlags.None);
            var response = Encoding.UTF8.GetString(buffer, 0, received);
            Response respon = JsonSerializer.Deserialize<Response>(response);
            if (respon.command == "no")
            {
                servList.Items.Clear();
                servList.Items.Add("Список Bаших услуг:");
                servList.Items.Add("Вы никуда не записаны.");
            }
            else
            {
                List<Service> services = JsonSerializer.Deserialize<List<Service>>(respon.data);
                servList.Items.Clear();
                servList.Items.Add("Список Bаших услуг:");
                for (int i = 0; i < services.Count; i++)
                {
                    servList.Items.Add(services[i].Name + " " + services[i].Date + " " + services[i].Price + "р.");
                }
            }
        }

        private void balanceButton_Click(object sender, EventArgs e)
        {
            paybox.Clear();
            paybox.Show();
            payButton.Show();
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            Socket socket = Connection.GetSocket();
            bool result = Int32.TryParse(paybox.Text, out int res);
            if (result & res > 0)
            {
                Request request = new Request("balance", res.ToString());
                string mes = JsonSerializer.Serialize(request);
                var messageBytes = Encoding.UTF8.GetBytes(mes);
                socket.Send(messageBytes, SocketFlags.None);
                var buffer = new byte[1_024];
                var received = socket.Receive(buffer, SocketFlags.None);
                var response = Encoding.UTF8.GetString(buffer, 0, received);
                Response respon = JsonSerializer.Deserialize<Response>(response);
                balanceUser.Text = respon.data;
                payButton.Hide();
                paybox.Hide();
            }
            else
            {
                MessageBox.Show("Некорректные данные");
                paybox.Clear();
            }
        }

        private void historyButton_Click(object sender, EventArgs e)
        {            
            HistoryForm hf = new HistoryForm();
            hf.Show();
        }

        private void servList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logUser_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }

        private void paybox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
