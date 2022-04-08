using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Controle_de_Produtos
{
    public partial class FrmEntrada : Controle_de_Produtos.FrmBase
    {
        public FrmEntrada()
        {
            InitializeComponent();
            DesahabilitaText();
        }
        private void HabilitaTex()
        {
            txtIdProduto.Enabled = true;
            txtQuantidade.Enabled = true;
            txtVlrTotal.Enabled = true;
            txtQuantidade.Enabled = true;
            txtIdProduto.Focus();
        }
        private void DesahabilitaText()
        {
            txtIdProduto.Enabled = false;
            txtQuantidade.Enabled = false;
            txtVlrTotal.Enabled = false;
            txtQuantidade.Enabled = false;
        }
        private void btnIncuir_Click(object sender, EventArgs e)
        {
            HabilitaTex();
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DesahabilitaText();
        }
        private void txtQuantidade_TextChanged(object sender, EventArgs e)
        {
            CalcularTotalDoItem(decimal.Parse(txtQuantidade.Text));
        }
        private void CalcularTotalDoItem(decimal v)
        {
            decimal vlrUni = decimal.Parse(txtVlrUnitario.Text);
            decimal vlrTotal = v * vlrUni;
            txtVlrTotal.Text = vlrTotal.ToString();
        }
        private void txtIdProduto_Leave(object sender, EventArgs e)
        {
            Model model = new Model();
            DtoProduto prod = model.GetProdutoId(int.Parse(txtIdProduto.Text));
            txtDescProduto.Text = prod.nome.ToString();
            txtVlrUnitario.Text = prod.valorcompra.ToString();
        }
    }
}
