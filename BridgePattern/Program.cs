using BridgePattern.Empresas;
using BridgePattern.MetodosEnvio;
using System;

namespace BridgePattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            IEnvio envioTren = new EnvioTren();
            IEnvio envioBarco = new EnvioBarco();
            IEnvio envioAvion = new EnvioAvion();

            IEmpresa fedexBarco = new Fedex(envioBarco);
            IEmpresa dhlTren = new Dhl(envioAvion);
            IEmpresa dhlBarco = new Dhl(envioBarco);
            IEmpresa estafetaTren = new Estafeta(envioTren);

            IPaqueteriaService paqueteriaService;

            Console.WriteLine("------ Empresa Fedex que enviara un pedido por mar ------");
            paqueteriaService = new PaqueteriaService(fedexBarco);
            paqueteriaService.ProcesarPedido();
            Console.WriteLine("\t");

            Console.WriteLine("------ Empresa Dhl que enviara un pedido por aire ------");
            paqueteriaService = new PaqueteriaService(dhlTren);
            paqueteriaService.ProcesarPedido();
            Console.WriteLine("\t");

            Console.WriteLine("------ Empresa Dhl que enviara un pedido por barco ------");
            paqueteriaService = new PaqueteriaService(dhlBarco);
            paqueteriaService.ProcesarPedido();
            Console.WriteLine("\t");

            Console.WriteLine("------ Empresa Estafeta que enviara un pedido por tren ------");
            paqueteriaService = new PaqueteriaService(estafetaTren);
            paqueteriaService.ProcesarPedido();
            Console.WriteLine("\t");
        }
    }
}
