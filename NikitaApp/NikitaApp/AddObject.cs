using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace NikitaApp
{
    public partial class AddObject : UserControl
    {

        

        public AddObject()
        {
            InitializeComponent();
            SetRoundedShape(gradientPanel3, 30);
            SetRoundedShape(gradientPanel4, 30);
            SetRoundedShape(gradientPanel5, 30);
            SetRoundedShape(gradientPanel9, 30);
            SetRoundedShape(gradientPanel8, 30);
            SetRoundedShape(gradientPanel6, 30);
            idManager();

        }

        private void idManager()
        {

            

            try
            { 
                StreamReader sr = new StreamReader("C:\\Users\\nikit\\Documents\\coding\\DataWork.json");


                String json = sr.ReadToEnd();

                if (json != "")
                {
                    List<SaveData> data = JsonConvert.DeserializeObject<List<SaveData>>(json);

                    for (int i = 0; i < data.Count; i++)
                    {
                        int number = Convert.ToInt32(data[i].GetId()) + 1;
                        idlable.Text = Convert.ToString(number);

                    }
                    sr.Close();
                }
                else
                    idlable.Text = "1";


            }
            
            catch
            {

            }

            


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void autoLabel2_Click(object sender, EventArgs e)
        {

        }

        private void autoLabel7_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void autoLabel9_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddObject_Load(object sender, EventArgs e)
        {

        }

        private void montāžaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bīdāmieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bīdāmieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bīdāmie vārti");

        }

        private void veramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Veramie vārti");
        }

        private void vārtiņiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Vārtiņi");
        }

        private void veramoVārtuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Veramo vārtu automātika");
        }

        private void bīdāmoVārtuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Bīdāmo vārtu automātika");
        }

        private void buttomPievienot_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(ievadeDarbi.Text);
            ievadeDarbi.Text = "";
        }

        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void fotoelementiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Fotoelementi");
        }

        private void signāllampaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Signāllampa");
        }

        private void gSMModulisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("GSM modulis");
        }

        private void wiFiModulisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Wi-Fi modulis");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Papildus pultis x1");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Papildus pultis x2");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Papildus pultis x3");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Papildus pultis x4");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Papildus pultis x5");
        }

        private void mehaniskoBojājumuRemontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Mehānisko bojājumu remonts");
        }

        private void elektroniskāsDaļasRemontsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Elektriskās daļas remonts");
        }

        private void lampiņasMaiņaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Lampiņas maiņa");
        }

        private void vārtuRegulēšanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Vārtu regulēšana");
        }

        private void automātikasRegulēšanaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Automātikas regulēšana");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Remove(listBox1.SelectedItem);
                
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ņikitaGrebņovsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        static void SetRoundedShape(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddLine(radius, 0, control.Width - radius, 0);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddLine(control.Width, radius, control.Width, control.Height - radius);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddLine(control.Width - radius, control.Height, radius, control.Height);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.AddLine(0, control.Height - radius, 0, radius);
            path.AddArc(0, 0, radius, radius, 180, 90);
            control.Region = new Region(path);
        }

        public void buttonSave_Click(object sender, EventArgs e)
        {
            getDataFromUser();

            ClearAll();




        }

        private void ClearAll()
        {
            AdressInput.Text = "";
            KMinput.Text = "";
            checkRamex.Checked = false;
            checkVap.Checked = false;
            inputPhone.Text = "";
            listBox1.Items.Clear();
            checkDONE.Checked = false;
            checkInProcess.Checked = false;

            idManager();

        }


        private void ClearButtom()
        {
            AdressInput.Text = "";
            KMinput.Text = "";
            checkRamex.Checked = false;
            checkVap.Checked = false;
            inputPhone.Text = "";
            listBox1.Items.Clear();
            checkDONE.Checked = false;
            checkInProcess.Checked = false;
        }




        private void getDataFromUser()
        {
            String id = idlable.Text;
            String adress = AdressInput.Text;

            String date = dateInput.Value.ToString();

            String kilometres = KMinput.Text;

            String owner="";
            if (checkVap.Checked)
                owner = "Vap comfort";
            else if (checkRamex.Checked)
                owner = "RAMEX";
            else
                owner = "Error";

            String TelNumber = inputPhone.Text;
            String status;
            if (checkDONE.Checked)
                status = "Pabeigts";
            else if (checkInProcess.Checked)
                status = "Procesā";
            else
                status = "error";

            String works="";

            foreach(String a in listBox1.Items)
            {
                works += a+" ";
            }

            List<SaveData> data = new List<SaveData>();

            data.Add(new SaveData(id, date, adress, kilometres, owner, TelNumber, status, works));




            
            List<SaveData> oldData = GetolFile();
            if (idlable.Text!="1")
            {
                oldData.AddRange(data);

                String json = JsonConvert.SerializeObject(oldData);
                writeToFile(json);
            }
            else
            {

                String json = JsonConvert.SerializeObject(data);
                writeToFile(json);
            }
            


            


        }

        private List<SaveData> GetolFile()
        {
            
            StreamReader sr = new StreamReader("C:\\Users\\nikit\\Documents\\coding\\DataWork.json");

            String oldjson = sr.ReadToEnd();

            List<SaveData> data = JsonConvert.DeserializeObject<List<SaveData>>(oldjson);

            sr.Close();
            return data;
            
        }


        public static void writeToFile(String json)
        {








           
                try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\nikit\\Documents\\coding\\DataWork.json");
                sw.WriteLine(json);
                sw.Close();
            }
            catch
            { }
            



        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearButtom();
        }
    }
}
