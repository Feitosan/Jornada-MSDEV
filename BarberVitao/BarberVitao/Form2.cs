using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberVitao
{
    public partial class Form2 : Form
    {
        public object Continue { get; private set; }

        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // DECLARANDO AS VARIAVEIS QUE VÃO RECEBER OS VALORES
            string nome;
            DateTime dataNascimento;
            string cidade;
            string genero;
            int numCadastro;
            // REBENDO OS VALORES DAS TEXTBOX, DATETIMEPICKER E COMBOBOX
            nome = textBox1.Text;
            dataNascimento = dateTimePicker1.Value;
            cidade = comboBox1.Text;
            genero = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;
            numCadastro = int.Parse(textBox2.Text);
            // CONTROLE DE ERROS
            if (nome.Length == 0)
            {
                MessageBox.Show("Nome não digitado!!");

            }
            else if (cidade.Length == 0)
            {
                MessageBox.Show("Nome da Cidade não selecionado!!");

            }
            else if (numCadastro == ' ') 
            {
                MessageBox.Show("Numero de Cadastro não digitado!!");
            }
            else if (genero.Length == ' ') 
            {
                MessageBox.Show("Genero não selecionado!!");
            }
            else
            {
                MessageBox.Show($"Nome:{nome}\n Data de Nascimento:{dataNascimento}\n Cidade:{cidade}\n Genero:{genero}\n Numero de Cadastro:{numCadastro}");
            }

            
        
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
