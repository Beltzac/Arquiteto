using Beltzac.Arquiteto.Modelos;
using System;
using System.Linq;
using System.Security.Cryptography;

namespace Beltzac.Arquiteto.Dominio
{
    public class RetaPilaresFactory : IRetaPilaresFactory
    {
        private readonly Configuracao _configuracao;
        public RetaPilaresFactory(IConfiguracaoRepository configuracaoRepository)
        {
            _configuracao = configuracaoRepository.GetConfiguracao();
        }

        public RetaPilares Gerar(double tamanhoMetros)
        {
            RetaPilares barracao = new RetaPilares(tamanhoMetros);

            InserirPilares(barracao);
            ReforcarPilares(barracao);

            return barracao;
        }

        /// <summary>
        /// Esse cálculo serve para indicar o melhor local para colocação de pilares de sustentação. Dada
        /// a distância total de uma reta, o sistema deverá calcular a cada quantos metros deverá ter um pilar,
        /// com base na configuração de distância máxima de vãos, de forma que os pilares fiquem equidistantes
        /// na reta.
        /// Exemplo: Imagine que o arquiteto irá desenvolver o projeto de um barracão que tenha a
        /// distância total de 11 metros, se a distância máxima para pilares seja de 3 metros, para que os pilares
        /// fiquem equidistantes o projetista deverá colocar um pilar a cada 2,75 metros.
        /// </summary>
        private void InserirPilares(RetaPilares barracao)
        {
            int qtdVaos = (int)Math.Ceiling(barracao.TamanhoMetros / _configuracao.DistanciaMaximaEntrePilaresMetros);

            int qtdPilares = qtdVaos + 1;

            double tamanhoVao = barracao.TamanhoMetros / qtdVaos;

            barracao.TamanhoVaoMetros = tamanhoVao;

            for (int i = 0; i < qtdPilares; i++)
            {
                Pilar pilar = new Pilar(i * tamanhoVao);
                barracao.Pilares.Add(pilar);
            }
        }

        /// <summary>
        /// Esse cálculo serve para indicar a necessidade da inclusão de uma base reforçada no pilar incluído no
        /// projeto. Sempre será incluída uma base reforçada nos pilares de início e fim da reta. Além disso será
        /// incluída uma nova base reforçada cada vez que a distância da reta ultrapassar o limite de distância
        /// máxima de bases reforçadas, para isso deverá ser levado em conta os pilares já incluídos no projeto,
        /// incluindo a base no pilar anterior do limite e então recomeçando a contagem da distância.
        /// </summary>
        private void ReforcarPilares(RetaPilares barracao)
        {
            barracao.Pilares.First().BaseReforcada = true;
            barracao.Pilares.Last().BaseReforcada = true;

            foreach (Pilar p in barracao.Pilares)
                if (p.DistanciaOrigem > _configuracao.DistanciaMaximaParaBaseReforcadaMetros)
                    p.BaseReforcada = true;
        }
    }
}
