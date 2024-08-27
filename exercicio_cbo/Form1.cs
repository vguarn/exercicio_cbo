using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exercicio_cbo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            string est = comboBox1.Text.ToString();
            if (est == " São Paulo - SP" | est == " Espírito Santo - ES" | est == " Rio de Janeiro - RJ" | est == " Minas Gerais - MG")
            {
                comboBox5.Items.Add(comboBox5.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                lblTodos.Text = comboBox1.SelectedItem.ToString();
                lblSudeste.Text = comboBox5.SelectedItem.ToString();
            }
            else if (est== " Alagoas - AL" | est== " Bahia - BA" | est == " Ceará - CE"| est== " Maranhão - MA" | est== " Paraíba - PB" | est== " Pernambuco - PE" | est== " Piauí - PI" | est== " Rio Grande do Norte - RN" |est== " Sergipe - SE")
            {
                comboBox3.Items.Add(comboBox3.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                lblTodos.Text = comboBox1.SelectedItem.ToString();
                lblNordeste.Text = comboBox3.SelectedItem.ToString();
            }
            else if (est== " Amazonas -  AM" | est== " Pará - PA" | est== " Acre - AC" | est== "Roraima - RR" | est== " Rondônia - RO" | est== " Amapá - AP" | est== " Tocantins - TO")
            {
                comboBox2.Items.Add(comboBox2.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                lblTodos.Text = comboBox1.SelectedItem.ToString();
                lblNorte.Text = comboBox2.SelectedItem.ToString();
            }
            else if (est== " Goiás - GO" | est== " Mato Grosso - MT"| est== " Mato Grosso do Sul - MS" | est== " Distrito Federal - DF")
            {
                comboBox4.Items.Add(comboBox4.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                lblTodos.Text = comboBox1.SelectedItem.ToString();
                lblCentro.Text = comboBox4.SelectedItem.ToString();
            }
            else if (est== " Paraná - PR" | est== " Santa Catarina - SC" | est== " Rio Grande do Sul - RS")
            {
                comboBox6.Items.Add(comboBox6.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
                lblTodos.Text = comboBox1.SelectedItem.ToString();
                lblSul.Text = comboBox6.SelectedItem.ToString();
            }
                    
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            lblTodos.Text = comboBox1.Items.Count.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void lblNorte_Click(object sender, EventArgs e)
        {
            lblNorte.Text = comboBox2.Items.Count.ToString();
        }

        private void lblNordeste_Click(object sender, EventArgs e)
        {
            lblNordeste.Text = comboBox3.Items.Count.ToString();
        }

        private void lblCentro_Click(object sender, EventArgs e)
        {
            lblCentro.Text = comboBox4.Items.Count.ToString();
        }

        private void lblSudeste_Click(object sender, EventArgs e)
        {
            lblSudeste.Text = comboBox5.Items.Count.ToString();
        }

        private void lblSul_Click(object sender, EventArgs e)
        {
            lblSul.Text = comboBox6.Items.Count.ToString();
        }

        private void btnNorte_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox2.SelectedItem);
            comboBox2.Items.Remove(comboBox2.SelectedItem);
            lblNorte.Text = comboBox2.Items.Count.ToString();
            lblTodos.Text = comboBox1.Items.Count.ToString();
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox3.SelectedItem);
            comboBox3.Items.Remove(comboBox3.SelectedItem);
            lblNordeste.Text = comboBox3.Items.Count.ToString();
            lblTodos.Text = comboBox1.Items.Count.ToString();
        }

        private void btnCentro_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox4.SelectedItem);
            comboBox4.Items.Remove(comboBox4.SelectedItem);
            lblCentro.Text = comboBox4.Items.Count.ToString();
            lblTodos.Text = comboBox1.Items.Count.ToString();
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox5.SelectedItem);
            comboBox5.Items.Remove(comboBox5.SelectedItem);
            lblSudeste.Text = comboBox5.Items.Count.ToString();
            lblTodos.Text = comboBox1.Items.Count.ToString();
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(comboBox6.SelectedItem);
            comboBox6.Items.Remove(comboBox6.SelectedItem);
            lblSul.Text = comboBox6.Items.Count.ToString();
            lblTodos.Text = comboBox1.Items.Count.ToString();
        }
    }
}
