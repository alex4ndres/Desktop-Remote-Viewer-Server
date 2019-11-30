using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace Viewer_Server
{
    public partial class ScreenView : Form
    {
        private readonly int port1, port2, port3, port4;
        private TcpClient client1, client2, client3, client4;
        private TcpListener server1, server2, server3, server4;
        private NetworkStream mainStream1, mainStream2, mainStream3, mainStream4;

        private readonly Thread Listening;
        private readonly Thread GetImage;

        public ScreenView(int Port1, int Port2, int Port3, int Port4)
        {
            Listening = new Thread(StartListening);
            GetImage = new Thread(ReceiveImage);

            port1 = Port1;
            port2 = Port2;
            port3 = Port3;
            port4 = Port4;

            client1 = new TcpClient();
            client2 = new TcpClient();
            client3 = new TcpClient();
            client4 = new TcpClient();

            InitializeComponent();
        }

        private void StartListening()
        {
            while (!client1.Connected)
            {
                server1.Start();
                client1 = server1.AcceptTcpClient();
            }
            while (!client2.Connected)
            {
                server2.Start();
                client2 = server2.AcceptTcpClient();
            }
            while (!client3.Connected)
            {
                server3.Start();
                client3 = server3.AcceptTcpClient();
            }
            while (!client4.Connected)
            {
                server4.Start();
                client4 = server4.AcceptTcpClient();

            }
            GetImage.Start();
        }

        private void StopListening()
        {
            server1.Stop();
            server2.Stop();
            server3.Stop();
            server4.Stop();
            //client = null;
            if (Listening.IsAlive) Listening.Abort();
            if (GetImage.IsAlive) Listening.Abort();
        }

        private void ReceiveImage()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            while (client1.Connected)
            {
                mainStream1 = client1.GetStream();
                pbDesktop1.Image = (Image)binaryFormatter.Deserialize(mainStream1);
                mainStream2 = client2.GetStream();
                pbDesktop2.Image = (Image)binaryFormatter.Deserialize(mainStream2);
                mainStream3 = client3.GetStream();
                pbDesktop3.Image = (Image)binaryFormatter.Deserialize(mainStream3);
                mainStream4 = client4.GetStream();
                pbDesktop4.Image = (Image)binaryFormatter.Deserialize(mainStream4);
            }
            //while (client2.Connected)
            //{
            //    mainStream2 = client2.GetStream();
            //    pbDesktop2.Image = (Image)binaryFormatter.Deserialize(mainStream2);
            //}
            //while (client3.Connected)
            //{
            //    mainStream3 = client3.GetStream();
            //    pbDesktop3.Image = (Image)binaryFormatter.Deserialize(mainStream3);
            //}
            //while (client3.Connected)
            //{
            //    mainStream4 = client4.GetStream();
            //    pbDesktop4.Image = (Image)binaryFormatter.Deserialize(mainStream4);
            //}
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            server1 = new TcpListener(IPAddress.Any, port1);
            server2 = new TcpListener(IPAddress.Any, port2);
            server3 = new TcpListener(IPAddress.Any, port3);
            server4 = new TcpListener(IPAddress.Any, port4);
            Listening.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
