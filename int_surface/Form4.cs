using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Windows;
using System.Threading;
using Newtonsoft.Json.Linq;

namespace int_surface
{
    
    public partial class Form4 : Form
    {
        private Thread thread2;
        public Form4()
        {
            InitializeComponent();
            HttpListener listener = new HttpListener();
            listener.Prefixes.Add("http://localhost:8000/");
            listener.Start();
            thread2 = new Thread(() =>
            {
                while (listener.IsListening)
                {
                    HttpListenerContext context = listener.GetContext();
                    HandleRequest(context);
                }
            });
            thread2.Start();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void HandleRequest(HttpListenerContext context)
        {
            if (context.Request.HttpMethod == "GET")
            {
                Boolean param1 = false;
                try
                {
                    param1 = Convert.ToBoolean(context.Request.QueryString["success"]);
                }
                catch
                {
                    param1 = false;
                }
                string jsonResponse = "{\"succes\":\"" + param1 + "\"}";
                byte[] jsonBytes = Encoding.UTF8.GetBytes(jsonResponse);
                context.Response.OutputStream.Write(jsonBytes, 0, jsonBytes.Length);
                context.Response.Close();
                if (param1 == true)
                {
                    thread2.Abort();

                    Application.Run(new Form1());
                }
            }

        }
    }
}

