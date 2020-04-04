using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace NikitaApp
{
    public partial class EditData : UserControl
    {
        public int a;
        public EditData(int a)
        {
            this.a = a;
            InitializeComponent();
        }

        public EditData()
        {
        }

        private void dataProcess()
        {

            StreamReader sr = new StreamReader("C:\\Users\\nikit\\Documents\\coding\\DataWork.json");


            String json = sr.ReadToEnd();


            List<SaveData> data = JsonConvert.DeserializeObject<List<SaveData>>(json);

            sr.Close();

            AdressInput.Text = data[a].GetSAdress();


            while (data[a].GetWorks()=="")
            {
                listBox1.Items.Add(data[a].GetWorks());

            }

            KMinput.Text = data[a].GetKm();
            dateInput.Text = data[a].GetDate();
            inputPhone.Text = data[a].GetMobile();
        }





        private void autoLabel8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void inputPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.SendToBack();
            

        }

        private void EditData_Load(object sender, EventArgs e)
        {

        }
    }
}
