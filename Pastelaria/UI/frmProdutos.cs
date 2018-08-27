using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pastelaria.UI
{
    public partial class frmProdutos : Form
    {
        BLL.Produto prod = new BLL.Produto();
        DAL.ProdutoDAL prodDAL = new DAL.ProdutoDAL();

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void txtSalarioFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarProd_Click(object sender, EventArgs e)
        {
            prod.Nomeproduto = txtNomeProd.Text;
            prod.Quantidade = Convert.ToInt32(txtQuantidadeProd.Text);
            prod.Preco = Convert.ToDouble(txtPrecoProd.Text);
            prod.Obs = txtObsProd.Text;

            prodDAL.Cadastrar(prod);

            MessageBox.Show("Dados Gravados com Sucesso!");

            dgvConsultaProd.DataSource = prodDAL.ConsultarTodos();            
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            //Para chegar aqui cliquei duas vezes no fomulario
            //Será executado ao abrir o formulario
            dgvConsultaProd.DataSource = prodDAL.ConsultarTodos();  
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            prod.Nomeproduto = txtFiltrar.Text;
            dgvConsultaProd.DataSource = prodDAL.ConsultarPorNome(prod);
        }
    }
}
