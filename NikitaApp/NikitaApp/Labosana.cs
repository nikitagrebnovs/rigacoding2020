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
    public partial class Labosana : UserControl
    {

        

        public Labosana()
        {
            InitializeComponent();

            fillEmpty();
        }


        




        public void fillEmpty()
        {
            StreamReader sr = new StreamReader("C:\\Users\\nikit\\Documents\\coding\\DataWork.json");


            String json = sr.ReadToEnd();


            List<SaveData> data = JsonConvert.DeserializeObject<List<SaveData>>(json);

            sr.Close();

            int a = 0;
            Parskats obj = new Parskats();

            a =  Convert.ToInt32(label4.Text);


            



            

            

            AdressInput.Text = data[a].GetSAdress();


            while (data[a].GetWorks() == "")
            {
                listBox1.Items.Add(data[a].GetWorks());

            }

            KMinput.Text = data[a].GetKm();
            dateInput.Text = data[a].GetDate();
            inputPhone.Text = data[a].GetMobile();



        }

        private void Labosana_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void parskats1_Load(object sender, EventArgs e)
        {

        }
    }
}
