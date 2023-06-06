using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai12_Trang74
{
    public partial class Form1 : Form
    {
        PhuongTrinhBac2 PTB2 = new PhuongTrinhBac2();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nudA.Minimum = -100;
            nudA.Maximum = 100;
            nudA.Increment = 1; // bước nhảy

            nudB.Minimum = -100;
            nudB.Maximum = 100;
            nudB.Increment = 1;

            nudC.Minimum = -100;
            nudC.Maximum = 100;
            nudC.Increment = 1;

            lstKetQua.ColumnWidth = Width;
        }

        private void btnGPT_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.LightBlue;
            btn.ForeColor = Color.Red;
        }

        private void btnGPT_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                this.Close();
        }

        private void btnGPT_Click(object sender, EventArgs e)
        {
            string str = $"A = {PTB2.a,3} | B = {PTB2.b,3} | C = {PTB2.c,3} | {PTB2.GiaiPT()}";
            lstKetQua.Items.Add(str);
        }

        private void nudA_ValueChanged(object sender, EventArgs e)
        {
            PTB2.a = (int)nudA.Value;
        }

        private void nudB_ValueChanged(object sender, EventArgs e)
        {
            PTB2.b = (int)nudB.Value;
        }

        private void nudC_ValueChanged(object sender, EventArgs e)
        {
            PTB2.c = (int)nudC.Value;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstKetQua.Items.Clear();
        }
    }
}
