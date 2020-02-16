namespace BridgePattern.MetodosEnvio
{
    public class EnvioBarco : IEnvio
    {
        public string Cargar()
        {
            return "cargado en Barco";
        }

        public string Descargar()
        {
            return "descargado del Barco";
        }

        public string Enviar()
        {
            return "enviado por Barco";
        }
    }
}
