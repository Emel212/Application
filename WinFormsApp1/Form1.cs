using Entities.Models;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<List<string>,List<string>> _dict=new Dictionary<List<string>, List<string>>();
        public async void  Get()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyError) => { return true; };
            HttpClient client = new HttpClient(clientHandler);
            client.BaseAddress = new Uri("https://localhost:5001");
            HttpResponseMessage response =await client.GetAsync("/api/Column/GetVisibleColumns");
             string result =await response.Content.ReadAsStringAsync();
            var res=  JsonConvert.DeserializeObject<List<TableView>>(result);
            var columns = res.Select(x => x._column.Name);
            List<string> val = new List<string>();
            List<string>col = new List<string>();


           /* foreach (var item in res)
            {
                col.Add(item._column.Name);
                foreach (var value in item._values)
                {
                   
                    val.Add(value.Value1);
                   
                }
                
            }*/
            _dict.Add(col, val);
            foreach (var item in _dict.Keys)
            {
                foreach (var itemm in item)
                {
                    dataGridView1.Columns.Add(itemm, itemm.ToString());
                    var values = _dict[item];

                    for (int i = 0; i < 1; i++)
                    {
                        dataGridView1[itemm, i].Value = values[i];
                    }
                }

            }
         



        }

        private void Form1_LoadAsync(object sender, EventArgs e)
        {
            Get();
        }
    }
}