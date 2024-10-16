using ClasesEmpleado;
using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploHerenciaProyecto
{
    public class Menu
    {
        // Lista de empresas
        public List<Company> companies = new List<Company>();
        // Lista de empleados
        public List<Employee> empleados = new List<Employee>();

        private string archivo = @"C:\w\repos\240919-Programacion-Net\Archivos\companies.csv";

        public void MostrarMenu()
        {
            while (true)
            {
                // Limpiar la consola y mostrar las opciones
                Console.Clear();
                MostrarOpciones();

                // Leer la opción ingresada
                var opcion = Console.ReadLine();

                // Validar la opción seleccionada
                switch (opcion)
                {
                    case "1":
                        CrearCompany();
                        break;
                    case "2":
                        ListarCompanies();
                        break;
                    case "3":
                        CrearEmpleado();
                        break;
                    case "4":
                        ListarEmpleados();
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }

                // Pausar la consola para mostrar el resultado y permitir al usuario ver el mensaje
                Console.WriteLine("\nPresione una tecla para continuar...");
                Console.ReadKey();
            }
        }

        public void ListarEmpleados()
        {
            Console.Clear(); // Limpiar la consola antes de listar los empleados
            if (empleados.Count == 0)
            {
                Console.WriteLine("No hay empleados en la lista.");
            }
            else
            {
                Console.WriteLine("Listado de empleados");
                Console.WriteLine("====================");

                foreach (var empleado in empleados)
                {
                    Console.WriteLine($"Nombre: {empleado.Nombre}, Años: {empleado.Años}, Empresa: {empleado.CompanyId}");
                }
            }
        }

        private void CrearEmpleado()
        {
            Console.Clear(); // Limpiar la consola antes de crear un empleado

            // Pedir los datos del empleado por pantalla
            Console.Write("Ingrese el nombre del empleado: ");
            var nombre = Console.ReadLine();

            Console.Write("Ingrese los años de experiencia: ");
            //if (!int.TryParse(Console.ReadLine(), out int años))
            //{
            //    Console.WriteLine("Error: Años de experiencia no válidos.");
            //    return;
            //}

            var añoscadena = Console.ReadLine();
            var años = 0;
            try
            {
                años = Convert.ToInt32(añoscadena);
            }
            catch (System.FormatException ex)
            {
                años = 0;
                //throw;
            }


            // Mostrar la lista de empresas para seleccionar una
            ListarCompanies();
            Console.WriteLine();
            Console.Write("Ingrese el id de la empresa: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Error: ID de empresa no válido.");
                return;
            }

            var empleado = new Empleado(nombre, años);
            var company = companies.Find(c => c.Id == id);

            if (company != null)
            {
                empleado.CompanyId = company.Id;
                empleados.Add(empleado);
                Console.WriteLine("Empleado creado exitosamente.");
            }
            else
            {
                Console.WriteLine("Error: Empresa no encontrada.");
            }
        }

        public void MostrarOpciones()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menú de opciones");
            Console.WriteLine("================");
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1 - Crear Company");
            Console.WriteLine("2 - Listar Companies");
            Console.WriteLine("3 - Agregar Empleado");
            Console.WriteLine("4 - Listar Empleados");
            Console.ResetColor();
        }

        public void CrearCompany()
        {
            // Leer los datos del archivo CSV
            LeerCsv();

            Console.Clear(); // Limpiar la consola antes de crear la empresa
            var id = companies.Count + 1;

            Console.Write("Ingrese el nombre de la empresa: ");
            var nombre = Console.ReadLine();

            var company = new Company(nombre, id);





            // Agregar la empresa a la lista
            companies.Add(company);

            EscribirCsv();


        }

        private void EscribirCsv()
        {
            try
            {
                // Escribir los datos en el archivo CSV
                using (var writer = new StreamWriter(archivo))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    // Opcional: configura si necesitas algunas opciones adicionales
                }))
                {
                    // Escribir cabeceras manualmente en minúsculas
                    csv.WriteField("name");
                    csv.WriteField("id");
                    csv.NextRecord(); // Mueve a la siguiente línea después de escribir las cabeceras

                    // Escribir los registros
                    foreach (var company in companies)
                    {
                        csv.WriteField(company.Name);
                        csv.WriteField(company.Id);
                        csv.NextRecord(); // Mueve a la siguiente línea después de escribir un registro
                    }
                }
                Console.WriteLine("Empresa creada exitosamente.");
            }
            catch (System.UnauthorizedAccessException ex)
            {
                Console.WriteLine("No se ha podido grabar la empresa en el csv");
                Console.WriteLine(ex.Message);
                //throw;
            }
        }

        private void LeerCsv()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {

                PrepareHeaderForMatch = args => args.Header.ToLower(),
            };

            if (!File.Exists(archivo))
            {
                using (var writer = new StreamWriter(archivo))
                using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
                {
                    // Escribir cabeceras iniciales
                    csv.WriteField("name");
                    csv.WriteField("id");
                    csv.NextRecord();
                }
            }

            // System.IO.FileNotFoundException

            try
            {
                using (var reader = new StreamReader(archivo))
                using (var csv = new CsvReader(reader, config))
                {
                    var records = csv.GetRecords<Company>();
                    companies.Clear();
                    foreach (var company in records)
                    {
                        companies.Add(new Company(company.Name, company.Id));
                    }
                }
            }
            catch (System.IO.FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
        }

        public void ListarCompanies()
        {
            LeerCsv();

            Console.Clear(); // Limpiar la consola antes de listar las empresas
            if (companies.Count == 0)
            {
                Console.WriteLine("No hay empresas en la lista.");
            }
            else
            {
                Console.WriteLine("Listado de empresas");
                Console.WriteLine("===================");

                foreach (var company in companies)
                {
                    Console.WriteLine(company.ToString());
                }
            }
        }
    }
}
