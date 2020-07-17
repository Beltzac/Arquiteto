using Beltzac.Arquiteto.Modelos;

namespace Beltzac.Arquiteto.Dominio
{
    public interface IRetaPilaresFactory
    {
        RetaPilares Gerar(double tamanhoMetros);
    }
}