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
        public List<String> dataParskats = new List<string>();

        List<Panel> listPanel = new List<Panel>();

        

        public Parskats()
        {
            InitializeComponent();
            
            GetInfo();

            SetRoundedShape(dataPanel, 30);
            SetRoundedShape(panel1, 30);

            

            listPanel.Add(panel2);
            listPanel.Add(panel3);

            listPanel[1].SendToBack();


            Main main2 = new Main();

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                if(dataViewView.Rows.Count<data.Count)
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
            
            for (int i=0;i<data.Count; i++)
            {

                String a = data[i].GetSAdress();

                if(a.Contains(search))
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


            int selected=0;


            for (int i= dataViewView.RowCount - 1; i>=0;i--)
            {
                if(dataViewView.Rows[i].Cells[4].Value!=null)
                {

                    selected = i;

                    Labosana labi = new Labosana();

                   labi.label4.Text = Convert.ToString(selected);
                    labi.label4.Text = "999999999999";
                }


            }

            






             Labosana lab = new Labosana();
            lab.fillEmpty();
            this.Visible = false;
            this.SendToBack();
            
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }

   
    
}
