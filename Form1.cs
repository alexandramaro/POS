using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double PrecoArtigos()
        {
            Double soma = 0;
            int i = 0;

            for (i = 0; i < (dataGridView1.Rows.Count); i++)
            {
                soma += Convert.ToDouble(dataGridView1.Rows[i].Cells[2].Value);
            }
            return soma;
        }

        private void AddCost()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                txtTotal.Text = String.Format("{0:c2}", PrecoArtigos());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                txtTotal.Text = "0";
                dataGridView1.Rows.Clear();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonRemove_MouseEnter(object sender, EventArgs e)
        {
            this.btnRemove.BackColor = ColorTranslator.FromHtml("#2f4f4f");
        }

        private void buttonRemove_MouseLeave(object sender, EventArgs e)
        {
            this.btnRemove.BackColor = ColorTranslator.FromHtml("#008080");
        }

        private void buttonApaga_MouseEnter(object sender, EventArgs e)
        {
            this.btnApaga.BackColor = ColorTranslator.FromHtml("#2f4f4f");
        }

        private void buttonApaga_MouseLeave(object sender, EventArgs e)
        {
            this.btnApaga.BackColor = ColorTranslator.FromHtml("#008080");
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
            AddCost();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 0.65;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Café Expresso"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Café Expresso", "1", PrecoArtigo);
            AddCost();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 0.95;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Galão"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Galão", "1", PrecoArtigo);
            AddCost();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 1.05;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Garoto"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Garoto", "1", PrecoArtigo);
            AddCost();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 2.25;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Cappuccino"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Cappuccino", "1", PrecoArtigo);
            AddCost();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 0.75;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Água"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Água", "1", PrecoArtigo);
            AddCost();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 2.75;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sumo Natural"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Sumo Natural", "1", PrecoArtigo);
            AddCost();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 2.35;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sumo Lata"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Sumo Lata", "1", PrecoArtigo);
            AddCost();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 1.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Imperial"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Imperial", "1", PrecoArtigo);
            AddCost();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 1.25;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Cerveja"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Cerveja", "1", PrecoArtigo);
            AddCost();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 1.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pastelaria"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Pastelaria", "1", PrecoArtigo);
            AddCost();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 1.00;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Salgados"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Salgados", "1", PrecoArtigo);
            AddCost();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 2.50;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sandes Mista"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Sandes Mista", "1", PrecoArtigo);
            AddCost();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 2.75;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Tosta Mista"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Tosta Mista", "1", PrecoArtigo);
            AddCost();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 1.10;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Sopa"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Sopa", "1", PrecoArtigo);
            AddCost();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 0.10;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Pastilhas"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Pastilhas", "1", PrecoArtigo);
            AddCost();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Double PrecoArtigo = 12.75;
            foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
            {
                if ((bool)(row.Cells[0].Value = "Bolos"))
                {
                    row.Cells[1].Value = Double.Parse((string)row.Cells[1].Value + 1);
                    row.Cells[2].Value = Double.Parse((string)row.Cells[1].Value) * PrecoArtigo;
                }
            }
            dataGridView1.Rows.Add("Bolos", "1", PrecoArtigo);
            AddCost();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
