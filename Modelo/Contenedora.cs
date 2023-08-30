namespace Modelo
{
    public class Contenedora
    {
        class Anidada
        {
            public void EscribirMensaje()
            {
                Console.WriteLine("Anidado.EscribirMensaje");
            }
        }

        public void EscribirMensaje()
        {
            Anidada a = new Anidada();
            a.EscribirMensaje();
        }
    }
}