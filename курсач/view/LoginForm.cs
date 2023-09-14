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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUp = new SignUpForm();
            signUp.Show();
        }
        private void signInButton_Click(object sender, EventArgs e)
        {
            Socket socket = Connection.GetSocket();
            if (login.Text == "" | password.Text == "")
            {
                MessageBox.Show("Одно из полей не заполнено!");
            }
            else
            {
                List<string> data = new List<string>() { login.Text, password.Text };
                Request request = new Request("entry", JsonSerializer.Serialize(data));
                string mes = JsonSerializer.Serialize(request);
                var messageBytes = Encoding.UTF8.GetBytes(mes);
                socket.Send(messageBytes, SocketFlags.None);
                var buffer = new byte[1_024];
                var received = socket.Receive(buffer, SocketFlags.None);
                var response = Encoding.UTF8.GetString(buffer, 0, received);
                Response respon = JsonSerializer.Deserialize<Response>(response);
                string message = JsonSerializer.Deserialize<List<string>>(respon.command)[0];
                bool exist = JsonSerializer.Deserialize<bool>(JsonSerializer.Deserialize<List<string>>(respon.command)[1]);
                if (exist)
                {
                    this.Hide();
                    ProfileForm profileForm = new ProfileForm();
                    profileForm.Show();
                }
                else
                {
                    login.Clear();
                    password.Clear();
                    MessageBox.Show(message);
                }
            }
            

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {

        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
