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
using Microsoft.VisualBasic.Logging;

namespace курсач
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }
        private void signUpSUF_Click(object sender, EventArgs e)
        {
            Socket socket = Connection.GetSocket();            
            bool res = Int32.TryParse(signUpAge.Text, out int resInt);
            if (signUpName.Text == "" | signUpLogin.Text == "" | signUpAge.Text == "" | signUpPhone.Text == "" | password.Text == "" | repeatPass.Text == "")
            {
                MessageBox.Show("Одно из полей не заполнено!");
            }
            else
            {
                if (res & resInt > 0 )
                {
                    User user = new()
                    {
                        Name = signUpName.Text,
                        Age = Int32.Parse(signUpAge.Text),
                        Password = password.Text,
                        Login = signUpLogin.Text,
                        NumberPhone = signUpPhone.Text,
                        ConfirmPassword = repeatPass.Text
                    };
                    Request request = new Request("registration", JsonSerializer.Serialize(user));
                    string mes = JsonSerializer.Serialize(request);
                    var messageBytes = Encoding.UTF8.GetBytes(mes);
                    socket.Send(messageBytes, SocketFlags.None);
                    var buffer = new byte[1_024];
                    Task<int> received = socket.ReceiveAsync(buffer, SocketFlags.None);
                    var response = Encoding.UTF8.GetString(buffer, 0, received.Result);
                    Response resp = JsonSerializer.Deserialize<Response>(response);
                    if (resp.command == "yes")
                    {
                        this.Hide();
                        ProfileForm profileForm = new ProfileForm();
                        profileForm.Show();
                    }
                    else
                    {
                        if (resp.data == "Пользователь с таким логином уже существует") { signUpLogin.Clear(); }
                        MessageBox.Show(resp.data);
                    }
                }
                else
                {
                    MessageBox.Show("Некорректный возраст.");
                    signUpAge.Clear();
                }
            }
            
            
        }

        private void TextLabel_Click(object sender, EventArgs e)
        {

        }

        private void signUpPhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void signUpName_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void signUpAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
