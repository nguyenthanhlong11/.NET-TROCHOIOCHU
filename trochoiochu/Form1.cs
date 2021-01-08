using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trochoiochu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_Cau1(object sender, EventArgs e)
        {
            txt_question.Text = "";
            String question = "Bỏ ngoài nướng trong, ăn ngoài bỏ trong là gì?";
            txt_question.Text = question;
        }

        private void bt_DapAn1(object sender, EventArgs e)
        {
            txt_1a.Text = "B";
            txt_1b.Text = "Ắ";
            txt_1c.Text = "P";
        }

        private void bt_cau2(object sender, EventArgs e)
        {
            txt_question.Text = "";
            String question = "Bệnh gì bác sĩ bó tay?";
            txt_question.Text = question;
        }

        private void bt_DapAn2(object sender, EventArgs e)
        {
            txt_2a.Text = "G";
            txt_2b.Text = "Ã";
            txt_2c.Text = "Y";
            txt_2d.Text = "T";
            txt_2e.Text = "A";
            txt_2f.Text = "Y";
        }

        private void bt_cau3(object sender, EventArgs e)
        {
            txt_question.Text = "";
            String question = "Con gấu trúc ao ước gì mà không bao giờ được?";
            txt_question.Text = question;
        }

        private void bt_DapAn3(object sender, EventArgs e)
        {
            txt_3a.Text = "C";
            txt_3b.Text = "H";
            txt_3c.Text = "Ụ";
            txt_3d.Text = "P";
            txt_3e.Text = "H";
            txt_3f.Text = "I";
            txt_3g.Text = "N";
            txt_3h.Text = "H";
            txt_3i.Text = "M";
            txt_3k.Text = "À";
            txt_3l.Text = "U";
        }

        private void bt_cau4(object sender, EventArgs e)
        {
            txt_question.Text = "";
            String question = "Có 1 đàn chim đậu trên cành, người thợ săn bắn cái rằm. Hỏi chết mấy con?";
            txt_question.Text = question;
        }

        private void bt_DapAn4(object sender, EventArgs e)
        {
            txt_4a.Text = "C";
            txt_4b.Text = "H";
            txt_4c.Text = "Ế";
            txt_4d.Text = "T";
            txt_4e.Text = "1";
            txt_4f.Text = "5";
            txt_4g.Text = "C";
            txt_4h.Text = "O";
            txt_4i.Text = "N";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_chedapan_1(object sender, EventArgs e)
        {
            txt_1a.Text = "";
            txt_1b.Text = "";
            txt_1c.Text = "";
        }

        private void bt_chedapan1(object sender, EventArgs e)
        {
            txt_2a.Text = "";
            txt_2b.Text = "";
            txt_2c.Text = "";
            txt_2d.Text = "";
            txt_2e.Text = "";
            txt_2f.Text = "";
        }

        private void bt_chedapan3(object sender, EventArgs e)
        {
            txt_3a.Text = "";
            txt_3b.Text = "";
            txt_3c.Text = "";
            txt_3d.Text = "";
            txt_3e.Text = "";
            txt_3f.Text = "";
            txt_3g.Text = "";
            txt_3h.Text = "";
            txt_3i.Text = "";
            txt_3k.Text = "";
            txt_3l.Text = "";
        }

        private void bt_chedapan4(object sender, EventArgs e)
        {
            txt_4a.Text = "";
            txt_4b.Text = "";
            txt_4c.Text = "";
            txt_4d.Text = "";
            txt_4e.Text = "";
            txt_4f.Text = "";
            txt_4g.Text = "";
            txt_4h.Text = "";
            txt_4i.Text = "";

        }
    }
}
