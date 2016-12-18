using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using Utils;


namespace servidor_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(delegate
            {
                new Form1().Start();
            }
                          )).Start();




        }

       public  void Start(  )
        { 
           //usamos el puerto de escucha 51111
            TcpListener listener = new TcpListener(51111);

            listener.Start();

             

            using (TcpClient c = listener.AcceptTcpClient())

   
           try
           {
               string theString = "";
              
             

                using (NetworkStream n = c.GetStream())
                {
                    //aqui leemos el codigo recivido del cliente para saber que archivo enviar
                    string codigo = new BinaryReader(n).ReadString();

                     string[] tt =  codigo.Split(",".ToCharArray());
                  
                         theString = Utilities.ejecutar(tt).ToString();

                 /*   switch (codigo)
                    {
                        case "Persona":
                            theString = Encrypt.encriptar(File.ReadAllText("file_persona.txt"));
                            break;
                        case "Provincia":
                            theString = Encrypt.encriptar(File.ReadAllText("file_provincia.txt"));
                            break;
                        case "Municipio":
                            theString = Encrypt.encriptar(File.ReadAllText("file_municipio.txt"));
                            break;
                        case "Barrio":
                            theString = Encrypt.encriptar(File.ReadAllText("file_barrio.txt"));
                            break;
                        case "BarrioDM":
                            theString = Encrypt.encriptar(File.ReadAllText("file_barrio_dm.txt"));
                            break;
                        case "Distrito_Municipal":
                            theString = Encrypt.encriptar(File.ReadAllText("file_distrito_municipal.txt"));
                            break;
                        case "Urbanizacion":
                            theString = Encrypt.encriptar(File.ReadAllText("file_urbanizacion.txt"));
                            break;
                        case "SeccionDM":
                            theString = Encrypt.encriptar(File.ReadAllText("file_seccion_dm.txt"));
                            break;
                        case "UrbanizacionDM":
                            theString = Encrypt.encriptar(File.ReadAllText("file_urbanizacion_dm.txt"));
                            break;
                        default:
                            
                            break;
                    }

                    */
                    BinaryWriter w = new BinaryWriter(n);
                    //aqui enviamos el archivo encriptado
                    w.Write(Encrypt.encriptar(  theString));
            
                    w.Flush();

                }

            }
            finally
            {
                //Cerramos las conexiones
             
                listener.Stop();
                new Thread(new ThreadStart(delegate
                {
                    new Form1().Start();
                }
                    )).Start();
            }

            
       }

    }
}
