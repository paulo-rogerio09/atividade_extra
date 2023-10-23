using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pontosExtras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            // fecha o form.
            this.Close();
        }

        private void backgroundButton_Click(object sender, EventArgs e)
        {
            //Mostra a caixa de diálogo de cores. Se o usuário clicar em OK, altere o
            // Fundo do controle PictureBox na cor escolhida pelo usuário.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // apagar a imagem.
            pictureBox1.Image = null;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            //Mostre o Open File dialog. Se o usuário clicar em OK, carregue o
            //imagem que o usuário escolheu.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Se o usuário marcar a Stretch check box,
            // altera o PictureBox
            // Propriedade SizeMode para "Stretch". Se o usuário limpar
            // a caixa de seleção, altere-a para "Normal".
            if (checkBox1.Checked)
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            else
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
        }
    }
}
