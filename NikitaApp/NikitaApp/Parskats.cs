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
    public partial class Parskats : UserControl
    {
        private bool ownerCheck;
        private bool statusCheck;



        public Parskats()
        {
            InitializeComponent();

            GetInfo();

            SetRoundedShape(dataPanel, 30);
            SetRoundedShape(panel1, 30);

            panel5.Visible = false;




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sfDataGrid1_Click(object sender, EventArgs e)
        {

        }


        private void fillDataGrid(List<SaveData> data)
        {




            for (int i = 0; i < data.Count; i++)
            {
                if (dataViewView.Rows.Count < data.Count)
                    dataViewView.Rows.Add();
                dataViewView.Rows[i].Cells[0].Value = data[i].GetId();
                dataViewView.Rows[i].Cells[1].Value = data[i].GetDate();
                dataViewView.Rows[i].Cells[2].Value = data[i].GetSAdress();
                dataViewView.Rows[i].Cells[3].Value = data[i].GetStatus();

            }








        }
        public void GetInfo()
        {






            StreamReader sr = new StreamReader("C:\\Users\\nikit\\Documents\\coding\\DataWork.json");


            String json = sr.ReadToEnd();

            if (json != "")
            {
                List<SaveData> data = JsonConvert.DeserializeObject<List<SaveData>>(json);


                fillDataGrid(data);
            }
            sr.Close();




        }

        private void button2_Click(object sender, EventArgs e)
        {

            GetInfo();

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {

            searchInList();

        }

        private void searchInList()
        {
            StreamReader sr = new StreamReader("C:\\Users\\nikit\\Documents\\coding\\DataWork.json");


            String json = sr.ReadToEnd();


            List<SaveData> data = JsonConvert.DeserializeObject<List<SaveData>>(json);

            sr.Close();


            String search = ievadneMeklet.Text;

            int count = 0;

            int rowCOunt = 0;

            for (int i = 0; i < data.Count; i++)
            {

                String a = data[i].GetSAdress();

                if (a.Contains(search))
                {
                    count = i;



                    rowCOunt = dataViewSearch.Rows.Count;

                    dataViewSearch.Rows[0].Cells[0].Value = data[count].GetId();
                    dataViewSearch.Rows[0].Cells[1].Value = data[count].GetDate();
                    dataViewSearch.Rows[0].Cells[2].Value = data[count].GetSAdress();
                    dataViewSearch.Rows[0].Cells[3].Value = data[count].GetStatus();

                    break;

                }








            }








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

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;


            for (int i = dataViewView.RowCount - 1; i >= 0; i--)
            {
                if (dataViewView.Rows[i].Cells[4].Value != null)
                {
                    index = i;
                }


            }

            panel5.Visible = true;
            panel5.BringToFront();
            EditDatafill(index);



        }

        private void EditDatafill(int a)
        {
            StreamReader sr = new StreamReader("C:\\Users\\nikit\\Documents\\coding\\DataWork.json");


            String json = sr.ReadToEnd();


            List<SaveData> data = JsonConvert.DeserializeObject<List<SaveData>>(json);

            sr.Close();


            idNum.Text = Convert.ToString(data[a].GetId());
            AdressInput.Text = data[a].GetSAdress();
            KMinput.Text = data[a].GetKm();
            sfDateTimeEdit1.Text = data[a].GetDate();
            inputPhone.Text = data[a].GetMobile();

            if (data[a].GetOwner() == "RAMEX")
            {
                checkRamex.Checked = true;

            }
            else
                checkVap.Checked = true;


            string text = data[a].GetWorks();


            string[] words = text.Split(new char[] { ';' });



            foreach (string b in words)
            {
                listBox1.Items.Add(b);
            }


            if (data[a].GetStatus() == "Pabeigts")
                checkDONE.Checked = true;
            else
                checkInProcess.Checked = true;






        }











        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataViewSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ievadneMeklet_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            

           DialogResult result= MessageBox.Show(
        "Tiešām vēlaties dzēst?",
        "Message",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Information,
        MessageBoxDefaultButton.Button1,
        MessageBoxOptions.DefaultDesktopOnly
        );

            
            if(result==DialogResult.Yes)
                    deleteSelected();
            


        }

        private void deleteSelected()
        {

            


            int index = 0;


            for (int i = dataViewView.RowCount - 1; i >= 0; i--)
            {
                if (dataViewView.Rows[i].Cells[4].Value != null)
                {
                    index = i;
                }


            }

            dataViewView.Rows.RemoveAt(index);





            deleteFromFile();




        }


        private void deleteFromFile()
        {

            







        }

        private void dateInput_Click(object sender, EventArgs e)
        {

        }

        private void autoLabel6_Click(object sender, EventArgs e)
        {

        }

        private void fotoelementiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void signāllampaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gSMModulisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void wiFiModulisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void papildusPultisToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void radioUztvērējsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void remontdarbiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mehaniskoBojājumuRemontsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void elektroniskāsDaļasRemontsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lampiņasMaiņaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vārtuRegulēšanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void automātikasRegulēšanaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void citsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ievadeDarbi_TextChanged(object sender, EventArgs e)
        {

        }

        private void autoLabel8_Click(object sender, EventArgs e)
        {

        }

        private void buttomPievienot_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkRamex_CheckedChanged(object sender, EventArgs e)
        {
            if (ownerCheck)
            {
                checkRamex.Checked = true;
                ownerCheck = false;
            }
            else
                checkVap.Checked = false;
        }

        private void checkVap_CheckedChanged(object sender, EventArgs e)
        {
            if (ownerCheck)
            {
                checkVap.Checked = true;
                ownerCheck = false;
            }
            else
                checkVap.Checked = false;
        }

        private void autoLabel7_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdressInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void miniToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bīdāmoVārtuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void idlable_Click(object sender, EventArgs e)
        {

        }

        private void autoLabel4_Click(object sender, EventArgs e)
        {

        }

        private void autoLabel2_Click(object sender, EventArgs e)
        {

        }

        private void autoLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KMinput_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            panel5.Visible=false;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            ievadne.Text=Convert.ToString(listBox1.Items[index]);
        }

        

        private void gradientPanel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void inputPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void veramoVārtuToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkDONE_CheckedChanged(object sender, EventArgs e)
        {
            if (statusCheck)
            {
                checkDONE.Checked = true;
                statusCheck = false;
            }
            else
                checkDONE.Checked = false;
        }

        private void checkInProcess_CheckedChanged(object sender, EventArgs e)
        {
            if (statusCheck)
            {
                checkInProcess.Checked = true;
                statusCheck = false;
            }
            else
                checkDONE.Checked = false;

        }

        private void sfDateTimeEdit1_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void montāžaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bīdāmieToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void veramieToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void vārtiņiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void veramoVārtuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            changeList();


        }

        private void changeList()
        {
            List<String> a = new List<String>();

            foreach(String c in listBox1.Items)
            {

                a.Add(c);

            }
            int index = listBox1.SelectedIndex;

            for(int i=0;i<a.Count;i++)
            {
                if (i == index)
                {
                    a[i] = ievadne.Text;
                }
                else
                    a[i] = a[i];
            }

            listBox1.Items.Clear();
            foreach(String str in a)
            {
                listBox1.Items.Add(str);
            }

        }
    }

   
    
}
