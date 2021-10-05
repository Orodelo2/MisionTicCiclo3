using Persistencia;
using Dominio;
using System;

namespace AplicacionConsola
{
    class Program
    {
        private static IRepositorioCliente repoCliente = new RepositorioCliente(new Persistencia.AplicacionContext());
        private static IRepositorioEmpleado repoEmpleado = new RepositorioEmpleado(new Persistencia.AplicacionContext());
        private static IRepositorioDirectivo repoDirectivo = new RepositorioDirectivo(new Persistencia.AplicacionContext());
        private static IRepositorioEmpresa repoEmpresa = new RepositorioEmpresa(new Persistencia.AplicacionContext());
       
        static void Main(string[] args)
        {
            //AddCliente();
            //UpdateCliente();
            //DeleteCliente();
            GetAllCliente();
            //GetCliente();

            //AddEmpleado();
            //UpdateEmpleado();
            //DeleteEmpleado();            
            //GetAllEmpleado();
            //GetEmpleado();

            //AddDirectivo();
            //UpdateDirectivo();
            //DeleteDirectivo();
            //GetAllDirectivo();
            //GetDirectivo();

            //AddEmpresa();
            //UpdateEmpresa();
            //DeleteEmpresa();            
            //GetAllEmpresa();
            //GetEmpresa();

            Console.WriteLine("Acción Realizada");           
        }

        public static void AddCliente(){
            var cliente = new Cliente{
                IdCliente = 004,
                Nombre = "Kelly",
                Apellido = "Rodelo",
                Edad = "33",
                TipoDocumento = "CC",
                NumeroDocumento = 1052956644,
                Telefono = "3005411298",
                Correo = "carmen.rodelo@hotmail.com"

            };
            repoCliente.AddCliente(cliente);
        }

        public static void AddEmpleado(){
            var empleado = new Empleado{
                IdEmpleado = 001,
                Nombre = "Orlando",
                Apellido = "Rodelo Soto",
                Edad = "30",
                TipoDocumento = "CC",
                NumeroDocumento = 1052972010,
                Salario = 2400000

            };
            repoEmpleado.AddEmpleado(empleado);
        }

        public static void AddDirectivo(){
            var directivo = new Directivo{
                IdDirectivo = 001,
                Nombre = "Sebastian",
                Apellido = "Fernandez Rodelo",
                Edad = "45",
                TipoDocumento = "CC",
                NumeroDocumento = 1140123123,
                Salario = 2400000,
                Categoria = "Senior",
                CantidadEmpleados = 5

            };
            repoDirectivo.AddDirectivo(directivo);
        }

        public static void AddEmpresa (){
            var empresa = new Empresa{
                Nombre = "ROBOTICA SECAFERO",
                NIT = 8976457
            };
            repoEmpresa.AddEmpresa(empresa);
        }

        public static void UpdateCliente(){
            var cliente = new Cliente{
                IdCliente = 003,
                Nombre = "Carmen",
                Apellido = "Rodelo",
                Edad = "35",
                TipoDocumento = "CC",
                NumeroDocumento = 55233797,
                Telefono = "3005411298",
                Correo = "carmen.rodelo@hotmail.com"

            };
            repoCliente.UpdateCliente(cliente);
        }

        public static void UpdateEmpleado(){
            var empleado = new Empleado{
                IdEmpleado = 001,
                Nombre = "Orlando",
                Apellido = "Rodelo Soto",
                Edad = "30",
                TipoDocumento = "CC",
                NumeroDocumento = 1052972010,
                Salario = 2400000

            };
            repoEmpleado.UpdateEmpleado(empleado);
        }

        public static void UpdateDirectivo(){
            var directivo = new Directivo{
                IdDirectivo = 001,
                Nombre = "Orlando",
                Apellido = "Rodelo Soto",
                Edad = "30",
                TipoDocumento = "CC",
                NumeroDocumento = 1052972010,
                Salario = 2400000,
                Categoria = "Senior",
                CantidadEmpleados = 5

            };
            repoDirectivo.UpdateDirectivo(directivo);
        }

        public static void UpdateEmpresa (){
            var empresa = new Empresa{
                Nombre = "ROBOTICA SECAFERO",
                NIT = 8976457
            };
            repoEmpresa.UpdateEmpresa(empresa);
        }

        public static void DeleteCliente(){
            repoCliente.DeleteCliente(4);
        }

        public static void DeleteEmpleado(){
            repoEmpleado.DeleteEmpleado(4);
        }

        public static void DeleteDirectivo(){
            repoDirectivo.DeleteDirectivo(4);
        }

        public static void DeleteEmpresa(){
            repoEmpresa.DeleteEmpresa(4);
        }

        public static void GetAllCliente(){

        }

        public static void GetAllEmpleado(){
            
        }

        public static void GetAllDirectivo(){
            
        }

        public static void GetAllEmpresa(){
            
        }

        public static void GetCliente(){
            var getedCliente = repoCliente.GetCliente(10);

            if (getedCliente != null)
            {
            Console.WriteLine(getedCliente.Nombre);
            Console.WriteLine(getedCliente.Apellido);
            Console.WriteLine(getedCliente.Edad);
            Console.WriteLine(getedCliente.TipoDocumento);
            Console.WriteLine(getedCliente.NumeroDocumento);
            Console.WriteLine(getedCliente.Telefono);
            Console.WriteLine(getedCliente.Correo);
            }else{
                Console.WriteLine("Entidad Vacía");
            }
        }

        public static void GetEmpleado(){
            var getedEmpleado = repoEmpleado.GetEmpleado(10);

            if (getedEmpleado != null)
            {
            Console.WriteLine(getedEmpleado.Nombre);
            Console.WriteLine(getedEmpleado.Apellido);
            Console.WriteLine(getedEmpleado.Edad);
            Console.WriteLine(getedEmpleado.TipoDocumento);
            Console.WriteLine(getedEmpleado.NumeroDocumento);
            Console.WriteLine(getedEmpleado.Salario);

            }else{
                Console.WriteLine("Entidad Vacía");
            }
        }

        public static void GetDirectivo(){
            var getedDirectivo = repoDirectivo.GetDirectivo(1);

            if (getedDirectivo != null)
            {
            Console.WriteLine(getedDirectivo.Nombre);
            Console.WriteLine(getedDirectivo.Apellido);
            Console.WriteLine(getedDirectivo.Edad);
            Console.WriteLine(getedDirectivo.TipoDocumento);
            Console.WriteLine(getedDirectivo.NumeroDocumento);
            Console.WriteLine(getedDirectivo.Salario);
            Console.WriteLine(getedDirectivo.Categoria);
            Console.WriteLine(getedDirectivo.CantidadEmpleados);

            }else{
                Console.WriteLine("Entidad Vacía");
            }
        }

        public static void GetEmpresa(){
            var getedEmpresa = repoEmpresa.GetEmpresa(1);

            if (getedEmpresa != null)
            {
            Console.WriteLine(getedEmpresa.Nombre);
            Console.WriteLine(getedEmpresa.NIT);
            }else{
                Console.WriteLine("Entidad Vacía");
            }
        }


    }
}
