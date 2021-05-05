using System;

namespace ContaCosas_Consola
{
    class Program
    {
        protected InterfazUsuario run = new InterfazUsuario();
        static void Main(string[] args)
        {
            new Program().run.Ejecutar();   
        }
    }
}
