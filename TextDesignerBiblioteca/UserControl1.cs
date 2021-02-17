using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextDesignerBiblioteca
{
    public partial class UserControl1: UserControl
    {
        FontStyle style = FontStyle.Regular;
        Decimal size = 8;
        String font = "GenericSansSerif";

        public UserControl1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            size = numericUpDown1.Value;
            label1.Font = new Font(font, (float)size, style);
        }

        private void estilos_CheckedChanged(object sender, EventArgs e)
        {
            style = FontStyle.Regular;
            if (checkBox1.Checked)
            {
                style |= FontStyle.Bold;
            }
            if (checkBox2.Checked)
            {
                style |= FontStyle.Italic;
            }
            if (checkBox3.Checked)
            {
                style |= FontStyle.Underline;
            }

            label1.Font = new Font(font, (float)size, style);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            label1.ForeColor = colorDialog1.Color;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<String> opciones = new List<String>(){
            "Microsoft Sans Serif",
            "Arial",
            "Consolas",
            "Verdana",
            "Harlow Solid Italic",
            "Aharoni"};


            String seleccion = opciones[listBox1.SelectedIndex];

            if (seleccion == "Microsoft Sans Serif")
            {
                font = seleccion;
            }
            if (seleccion == "Arial")
            {
                font = seleccion;
            }
            if (seleccion == "Consolas")
            {
                font = seleccion;
            }
            if (seleccion == "Verdana")
            {
                font = seleccion;
            }
            if (seleccion == "Harlow Solid Italic")
            {
                font = seleccion;
            }
            if (seleccion == "Aharoni")
            {
                font = seleccion;
            }

            label1.Font = new Font(font, (float)size, style);
        }

        private void caps_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Text == "-")
            {
                checkBox4.Text = "<-";
                label1.Text = label1.Text.ToUpper();
            }
            if (checkBox4.Text == "->")
            {
                checkBox4.Text = "<-";
                label1.Text = label1.Text.ToUpper();
            }
            else
            {
                checkBox4.Text = "->";
                label1.Text = label1.Text.ToLower();
            }
        }
    }
}
