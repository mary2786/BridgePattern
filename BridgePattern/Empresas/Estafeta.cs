using BridgePattern.MetodosEnvio;

namespace BridgePattern.Empresas
{
    public class Estafeta : IEmpresa
    {
        private readonly IEnvio _envio;
        public Estafeta(IEnvio envio)
        {
            _envio = envio;
        }

        public string Entregar()
        {
            string mensaje = _envio.Descargar();
            return string.Format("Paquete entregado por Estafeta, {0}", mensaje);
        }

        public string Enviar()
        {
            string mensaje = _envio.Enviar();
            return string.Format("Paquete enviado por Estafeta, {0}", mensaje);
        }

        public string Recoger()
        {
            string mensaje = _envio.Cargar();
            return string.Format("Paquete recogido por Estafeta, {0}", mensaje);
        }
    }
}
