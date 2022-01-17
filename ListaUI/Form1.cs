using ListaCompras;
using System;
using System.Windows.Forms;

namespace ListaUI
{
    public partial class Form1 : Form
    {
        double totalCompras = 0;

        private void lbinit()
        {
            lbDados.Items.Clear();
            lbDados.Items.AddRange(new Alimento[] { new Banana(), new Tomate(), new Laranja(), new Cenoura(), new Alface(), new Leite(), new Guarana(), new Presunto(), new Queijo(), new Salmao()});
            totalCompras = 0;
        }

        private void ExibirItem(Alimento i)
        {
            txt_calorias.Text = i.Calorias.ToString();
            txt_custototal.Text = "";
            txt_tipo.Text = i.Tipo;
            txt_unidade.Text = i.Unidade;
            txt_preco.Text = i.Preco.ToString("C");
            if(i.Custo != 0)
            {
                txt_custototal.Text = i.Custo.ToString("C");
            }
        }

        public Form1()
        {
            InitializeComponent();
            lbinit();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach(var c in Controls)
            {
                if(c is TextBox)
                {
                    ((TextBox)c).Text = "";
                }
            }
        }

        private void lbDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            errorProvider.Clear();
            ExibirItem((Alimento)lbDados.Items[lbDados.SelectedIndex]);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                double qnt = Convert.ToDouble(txt_quantidade.Text);
                Alimento i = (Alimento)lbDados.Items[lbDados.SelectedIndex];
                i.setCusto(qnt);
                txt_custototal.Text = i.Custo.ToString("C");
                txt_quantidade.Text = "";
                totalCompras += i.getCustoCompra(qnt);
                string x = totalCompras.ToString("C");
                label_total.Text = $"Total: {x}";
            } catch (FormatException)
            {
                errorProvider.SetError(txt_quantidade, "Coloque um valor!");
                txt_quantidade.Focus();
            } catch (ArgumentOutOfRangeException)
            {
                errorProvider.SetError(lbDados, "Selecione um item da lista!");
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();
            try
            {
                Alimento i = (Alimento)lbDados.Items[lbDados.SelectedIndex];
                totalCompras -= i.Custo;
                i.resetCusto();
                txt_custototal.Text = "";
                txt_quantidade.Text = "";
                label_total.Text = "Total: 0";
                if(totalCompras != 0)
                {
                    string x = totalCompras.ToString("C");
                    label_total.Text = $"Total: {x}";
                }
            } catch (ArgumentOutOfRangeException)
            {
                errorProvider.SetError(lbDados, "Selecione um item da lista!");
            }
        }
    }
}
