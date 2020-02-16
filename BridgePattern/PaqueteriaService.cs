using BridgePattern.Empresas;
using System;

namespace BridgePattern
{
    public class PaqueteriaService : IPaqueteriaService
    {
        private readonly IEmpresa _empresa;
        public PaqueteriaService(IEmpresa empresa)
        {
            _empresa = empresa;
        }
        public void ProcesarPedido()
        {
            Console.WriteLine(_empresa.Recoger());
            Console.WriteLine(_empresa.Enviar());
            Console.WriteLine(_empresa.Entregar());
        }
    }
}
