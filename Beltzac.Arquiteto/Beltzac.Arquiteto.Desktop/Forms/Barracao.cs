using Beltzac.Arquiteto.Infraestrutura.Externo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Beltzac.Arquiteto.Desktop
{
    public partial class Barracao : Form
    {
        private readonly IArquitetoAPI _arquitetoAPI;
        public Barracao(IArquitetoAPI arquitetoAPI)
        {
            _arquitetoAPI = arquitetoAPI;
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var config = new Configuracao(_arquitetoAPI);
            config.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
           var reta = await _arquitetoAPI.CalcularRetaPilares(double.Parse(textBox1.Text));
            qtdPilares.Text = reta.Pilares.Count().ToString();
            distanciaPilares.Text = reta.TamanhoVaoMetros.ToString();
            qtdBasesReforcadas.Text = reta.Pilares.Count(p => p.BaseReforcada).ToString();
            pilaresBaseReforcada.Text = string.Join(", ", reta.Pilares.Where(p => p.BaseReforcada).Select(p => p.CodPilar.ToString()));
        }
    }
}
