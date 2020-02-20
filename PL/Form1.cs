using Entity;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Form1 : Form
    {
        [Flags]
        public enum TipoClienteEnum
        {
            ATIVO,
            DESATIVO,
            PENDENTE

        }
       
        public Form1()
        {
            InitializeComponent();
            CnbTipoCliente.DataSource = Enum.GetValues(typeof(TipoClienteEnum));
            

        }
        
        
        private  void CnbTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CnbTipoCliente.SelectedItem = TipoClienteEnum.ATIVO;
           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ClienteService().Insert(new Cliente());
            Cliente cliente = new Cliente();
            cliente.Name = txtNomeCliente.Text;
            cliente.CPF = txtCPF.Text;
            cliente.Email = txtEmailCliente.Text;
            cliente.DataNascimento = DtmDataNascimento.Value;



            


           

        }

        private void btnMOSTRAR_Click(object sender, EventArgs e)
        {
            
        }
    }
}
