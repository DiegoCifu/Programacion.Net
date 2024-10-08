using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjemploClases;
using EjemploEmpleados;

//Creamos la variable que almacena la lista de empleados
List<Empleado> listaEmpleados = new List<Empleado>();

// instancias de los empleados PEdro, Maria y Juan

// Crear empleado mediante inicializacion de propiedades

Empleado empleado1 = new Empleado();
empleado1.Nombre = "Pedro";
empleado1.Departamento = "IT";
empleado1.Telefono = "1234567";
empleado1.IBAN = "23455";
empleado1.NumeroEmpleado = "1";
empleado1.NSS = "9876";

//Añadir empleado a la lista
listaEmpleados.Add(empleado1);

// Crear empleado mediante inicializacion de propiedades en la misma linea
Empleado empleado2 = new Empleado();
empleado2.Nombre = "Maria";
empleado2.Departamento = "Desarrollo de apps";
empleado2.Telefono = "76543";
empleado2.IBAN = "235655";
empleado2.NumeroEmpleado = "2";
empleado2.NSS = "987667";

//Añadir empleado a la lista
listaEmpleados.Add(empleado2);


// Crear empleado mediante constructor
Empleado empleado3 = new Empleado("Juan", "Recursos Humanos", "787543", "987665", "3");
//Añadir empleado a la lista
listaEmpleados.Add(empleado3);

Empleado empleado4 = new Empleado("Claudia", "Ventas", "23543", "235565", "4");
//Añadir empleado a la lista
listaEmpleados.Add(empleado4);


Empleado empleado5 = new Empleado("Olga", "Marketing", "72223", "2355685", "5");
//Añadir empleado a la lista
listaEmpleados.Add(empleado5);

Empleado empleado6 = new Empleado("Antoneta", "Directora", "123456", "2355666", "6");
//Añadir empleado a la lista
listaEmpleados.Add(empleado6);

//Mostrar los datos de los empleados de la lista
foreach (Empleado empleado in listaEmpleados )
{
    empleado.MostrarDatosEmpleado();
}