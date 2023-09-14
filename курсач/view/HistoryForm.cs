using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using Microsoft.VisualBasic.ApplicationServices;


namespace курсач
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            Socket socket = Connection.GetSocket();
            Request request = new Request("history", "");
            string mes = JsonSerializer.Serialize(request);
            var messageBytes = Encoding.UTF8.GetBytes(mes);
            socket.Send(messageBytes, SocketFlags.None);
            var buffer = new byte[10000];
            var received = socket.Receive(buffer, SocketFlags.None);
            var response = Encoding.UTF8.GetString(buffer, 0, received);
            Response respons = JsonSerializer.Deserialize<Response>(response);
            if (respons.command == "no")
            {
                historyList.Items.Add("У Вас нет записей.");
            }
            else
            {
                List<Service> history = JsonSerializer.Deserialize<List<Service>>(respons.data);
                for (int i = 0; i < history.Count; i++)
                {
                    historyList.Items.Add(history[i].Name + " " + history[i].Date + " " + history[i].Price + "р.");
                }
            }
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {
        }

        private void historyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
