using BridgePattern.MetodosEnvio;

namespace BridgePattern.Empresas
{
    public class Fedex : IEmpresa
    {
        private readonly IEnvio _envio;
        public Fedex(IEnvio envio)
        {
            _envio = envio;
        }

        public string Entregar()
        {
            string mensaje = _envio.Descargar();
            return string.Format("Paquete entregado por Fedex, {0}", mensaje);
        }

        public string Enviar()
        {
            string mensaje = _envio.Enviar();
            return string.Format("Paquete enviado por Fedex, {0}", mensaje);
        }

        public string Recoger()
        {
            string mensaje = _envio.Cargar();
            return string.Format("Paquete recogido por Fedex, {0}", mensaje);
        }
    }
}
