using Beltzac.Arquiteto.Infraestrutura.Externo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
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

            var config = _arquitetoAPI.GetConfiguracao().Result;
            distanciaBaseReforcada.Text = config.DistanciaMaximaParaBaseReforcadaMetros.ToString();
            distanciaMaxima.Text = config.DistanciaMaximaEntrePilaresMetros.ToString();
            distanciaTotalMinima.Text = config.DistanciaTotalMinimaMetros.ToString();            
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var config = new Modelos.Configuracao
            {
                DistanciaMaximaParaBaseReforcadaMetros = double.Parse(distanciaBaseReforcada.Text),
                DistanciaMaximaEntrePilaresMetros = double.Parse(distanciaMaxima.Text),
                DistanciaTotalMinimaMetros = double.Parse(distanciaTotalMinima.Text)
            };

            await _arquitetoAPI.SetConfiguracao(config);
        }
    }
}
