using Hacken;

namespace Hacken
{

    public class Personas
    {
        public string Nombre { get; set; }


        private void myMethod(Personas value)
        {
            System.Console.WriteLine("La persona se llama {0}", value.Nombre);
        }

        static public void myMethod2(Personas value)
        {
            System.Console.WriteLine("La persona se llama {0}", value.Nombre);
        }

    }
}

namespace Invocar
{
    public class Print
    {
        public static void Main()
        {
            var persona = new Personas { Nombre = "Jorge" };
            
            Hacken.Personas.myMethod2(persona);

            Hacken.Personas.myMethod(persona);
        }
    }
}



