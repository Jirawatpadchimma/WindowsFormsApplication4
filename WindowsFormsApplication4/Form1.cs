using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str = "แบบประเมินประสิทธิภาพการจัดทำโพลด์ของศูนย์วิจัยมหาลีย :" + Environment.NewLine;
            string n = textBox1.Text;
            string s = textBox2.Text;
            string m = textBox3.Text;


            

            str = str + "1.หน่วยงานที่สังกัด ===";
            if (bpt1.Checked == true)
            {
                str = str + "โรงเรียน" + Environment.NewLine;
            }
            if (bpt2.Checked == true)
            {
                str = str + "เทศบาล" + Environment.NewLine;
            }
            if (radioButton1.Checked == true)
            {
                str = str + "อบจ." + Environment.NewLine;

            }
            if (radioButton3.Checked == true)
            {
                str = str + "อบต." + Environment.NewLine;
            }
            if (radioButton8.Checked == true)
            {
                str = str + "กศน.อำเภอ" + Environment.NewLine;
            }
            if (radioButton2.Checked == true)
            {
                str = str + "กศน.จังหวัด" + Environment.NewLine;
            }
            if (radioButton9.Checked == true)
            {
                str = str + "อื่น ๆ ===" + n + Environment.NewLine;

            }
            str = str + "2.ท่านได้รับข่าวสารข้อมูลจากแหล่งใด ===";
            if (cpt1.Checked == true)
            {
                str = str + "www.google.co.th" + Environment.NewLine;
            }
            if (cpt2.Checked == true)
            {
                str = str + "www.yahoo.com" + Environment.NewLine;
            }
            if (cpt3.Checked == true)
            {
                str = str + "แผ่นพับประชาสัมพันธ์ที่ได้รับแจก" + Environment.NewLine;
            }
            if (radioButton4.Checked == true)
            {
                str = str + "แผ่นซีดีข้อมูลที่ได้รับแจก" + Environment.NewLine;
            }
            if (radioButton10.Checked == true)
            {
                str = str + "การบอกต่อ" + Environment.NewLine;
            }
            if (radioButton11.Checked == true)
            {
                str = str + "อื่น ๆ ===" +s + Environment.NewLine;
                

            }
            str = str + "3.แหล่งเรียนรู้และภูมิท้องถิ่นไปใช้ประโยชน์อย่างไรบ้าง ===";
            if (dpt1.Checked == true)
            {
                str = str + "จัดการเรียนการสอน" + Environment.NewLine;
            }
            if (dpt2.Checked == true)
            {
                str = str + "ศึกษาค้นคว้าและทำรายงาน" + Environment.NewLine;
            }
            if (dpt3.Checked == true)
            {
                str = str + "ข้อมูลเชิงการท่องเที่ยว" + Environment.NewLine;
            }
            if (radioButton5.Checked == true)
            {
                
           str = str + "อื่น ๆ ===" + m +Environment .NewLine ;









            }
            MessageBox.Show(str, "รายงานผล");
        }

        private void optMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void apt2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

