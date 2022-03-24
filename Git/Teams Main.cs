using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Git
{
    public partial class Teams_Main : Form
        
    {
        public Teams_Main()
        {
            InitializeComponent();
            String[] imgList = new String[]
            {"1.jpg","2.jpg","3.jpg","4.jpg","5.jpg","6.jpg","7.jpg","8.jpg","9.jpg","10.jpg","11.jpg","12.jpg","13.jpg","14.jpg","15.jpg","16.jpg","17.jpg","18.jpg","19.jpg","20.jpg","21.jpg","22.jpg","23.jpg","24.jpg","25.jpg","26.jpg","27.jpg","28.jpg","29.jpg","30.jpg"};
            int index = 0;
           
            logo1.Load("../../../Teams/" + imgList[0]);
            logo2.Load("../../../Teams/" + imgList[1]);
            logo3.Load("../../../Teams/" + imgList[2]);
            logo4.Load("../../../Teams/" + imgList[3]);
            logo5.Load("../../../Teams/" + imgList[4]);
            logo6.Load("../../../Teams/" + imgList[5]);
            logo7.Load("../../../Teams/" + imgList[6]);
            logo8.Load("../../../Teams/" + imgList[7]);
            logo9.Load("../../../Teams/" + imgList[8]);
            logo10.Load("../../../Teams/" + imgList[9]);
            logo11.Load("../../../Teams/" + imgList[10]);
            logo12.Load("../../../Teams/" + imgList[11]);
            logo13.Load("../../../Teams/" + imgList[12]);
            logo14.Load("../../../Teams/" + imgList[13]);
            logo15.Load("../../../Teams/" + imgList[14]);
            logo16.Load("../../../Teams/" + imgList[15]);
            logo17.Load("../../../Teams/" + imgList[16]);
            logo18.Load("../../../Teams/" + imgList[17]);
            logo19.Load("../../../Teams/" + imgList[18]);
            logo20.Load("../../../Teams/" + imgList[19]);
            logo21.Load("../../../Teams/" + imgList[20]); 
            logo22.Load("../../../Teams/" + imgList[21]); 
            logo23.Load("../../../Teams/" + imgList[22]);
            logo24.Load("../../../Teams/" + imgList[23]);
            logo25.Load("../../../Teams/" + imgList[24]);
            logo26.Load("../../../Teams/" + imgList[25]);
            logo27.Load("../../../Teams/" + imgList[26]);
            logo28.Load("../../../Teams/" + imgList[27]);
            logo29.Load("../../../Teams/" + imgList[28]);
            logo30.Load("../../../Teams/" + imgList[29]);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form RosterForm = new Team_Detail();
            RosterForm.Show();
        }
    }
    }

