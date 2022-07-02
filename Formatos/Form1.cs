using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Formatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InstalledFontCollection fuentes = new InstalledFontCollection();
            FontFamily[] listaFuentes = fuentes.Families;
            foreach (FontFamily x in listaFuentes)
            {
                lbox_Fuentes.Items.Add(x.Name);
            }
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            this.Width += 20;
            this.Height += 20;
        }
        private void btn_Reduce_Click_1(object sender, EventArgs e)
        {
            this.Width -= 20;
            this.Height -= 20;
        }

        private void btn_Green_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btn_Blue_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void btn_Red_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void numericUpDown1_TextSize_ValueChanged(object sender, EventArgs e)
        {
            lbl_Texto.Font = new Font(lbox_Fuentes.SelectedItem.ToString(), Convert.ToSingle(numericUpDown1_TextSize.Value));
        }

        private void btn_Greentxt_Click(object sender, EventArgs e)
        {
            lbl_Texto.ForeColor = Color.Green;
        }

        private void btn_Bluetxt_Click(object sender, EventArgs e)
        {
            lbl_Texto.ForeColor = Color.Blue;
        }

        private void btn_Redtxt_Click(object sender, EventArgs e)
        {
            lbl_Texto.ForeColor = Color.Red;
        }

        private void btn_Hide_Click(object sender, EventArgs e)
        {
            lbl_Texto.Hide();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            lbl_Texto.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ckb_Bold_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Bold.Checked)
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, Font.Style | FontStyle.Bold);
            }
            else
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, Font.Style | FontStyle.Regular);
            }
        }

        private void ckb_Cursive_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Cursive.Checked)
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, Font.Style | FontStyle.Italic);
            }
            else
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, Font.Style | FontStyle.Regular);
            }
        }

        private void ckb_Underline_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Underline.Checked)
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, Font.Style | FontStyle.Underline);
            }
            else
            {
                lbl_Texto.Font = new Font(lbl_Texto.Font, Font.Style | FontStyle.Regular);
            }
        }

        private void lbox_Fuentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_Texto.Font = new Font(lbox_Fuentes.SelectedItem.ToString(), lbl_Texto.Font.Size);
        }
    }
}
