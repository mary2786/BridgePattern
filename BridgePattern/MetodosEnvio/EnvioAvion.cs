namespace BridgePattern.MetodosEnvio
{
    public class EnvioAvion : IEnvio
    {
        public string Cargar()
        {
            return "cargado en Avión";
        }

        public string Descargar()
        {
            return "descargado del Avión";
        }

        public string Enviar()
        {
            return "enviado por Avión";
        }
    }
}
