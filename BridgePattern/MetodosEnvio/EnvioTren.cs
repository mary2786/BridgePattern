namespace BridgePattern.MetodosEnvio
{
    public class EnvioTren : IEnvio
    {
        public string Cargar()
        {
            return "cargado en Tren";
        }

        public string Descargar()
        {
            return "descargado del Tren";
        }

        public string Enviar()
        {
            return "enviado por Tren";
        }
    }
}
