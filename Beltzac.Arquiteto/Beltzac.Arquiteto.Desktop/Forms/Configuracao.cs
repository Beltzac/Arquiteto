using Beltzac.Arquiteto.Infraestrutura.Externo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Beltzac.Arquiteto.Desktop
{
    public partial class Configuracao : Form
    {
        private readonly IArquitetoAPI _arquitetoAPI;
        public Configuracao(IArquitetoAPI arquitetoAPI)
        {
            _arquitetoAPI = arquitetoAPI;
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
