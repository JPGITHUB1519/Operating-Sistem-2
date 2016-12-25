using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Data;

namespace AsyncClientForm
{
    class CommunicationClient
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public static void Connect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("Connectiom Attemps : " + attempts);
                }
            }
            MessageBox.Show("Connected");
        }

        public static string sendRequestForString(string request)
        {
            // encriptar peticion para enviar al servidor
            request = Encrypt.encriptar(request);
            byte[] buffer = Encoding.ASCII.GetBytes(request);
            _clientSocket.Send(buffer);
            // receive data from server
            byte[] receivedBuf = new byte[1024];
            int rec = _clientSocket.Receive(receivedBuf);
            byte[] data = new byte[rec];
            Array.Copy(receivedBuf, data, rec);
            // desencriptar y retornar informacion encriptada por el server
            return Encrypt.desencriptar(Encoding.ASCII.GetString(data));
        }

        // Convert to DataTable.
        public static DataTable ConvertListToDataTable(List<string> lista)
        {
            // New table.
            DataTable dt = new DataTable();
            string[] string_splited;
            int cont = 0;
            foreach (string element in lista)
            {
                // first row are the columns
                string_splited = element.Split(',');
                if (cont == 0)
                {
                    foreach (string column in string_splited)
                    {
                        dt.Columns.Add(column, typeof(string));
                    }
                }
                else
                {
                    DataRow dr = dt.NewRow();
                    for (int i = 0; i < string_splited.Length; i++)
                    {
                        dr[i] = string_splited[i];
                    }
                    dt.Rows.Add(dr);
                }
                cont++;

            }

            return dt;
        }

        public static string[] queryResultStripperToArray(string response)
        {
            string[] records = response.Split('[');
            return records;
        }

        public static List<string> stringResponseToList(string response)
        {
            List<string> records = new List<string>();
            records = queryResultStripperToArray(response).ToList();
            return records;
        }
    }
}
