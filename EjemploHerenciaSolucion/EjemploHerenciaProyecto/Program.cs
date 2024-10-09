// See https://aka.ms/new-console-template for more information
using ClasesAnimales;
using ClasesBook;
using ClasesEmpleado;



// Crear una serie de animales, basados en las clases Retriever, Terrier, HouseCat y Tiger
var animals = new List<Animal>
{
    new Retriever("Buddy", 5),
    new Terrier("Max", 3),
    new HouseCat("Whiskers", 2),
    new Tiger("Tony", 7)
};
// Mostrar informacion de los animales mediante un bucle foreach y Console.WriteLine
foreach (Animal animal in animals)
{
    Console.WriteLine($"Nombre: {animal.Nombre}, Edad: {animal.Edad}");
}

// Crear una lista de Empleados , basados en las clases Administrative, Factory, MiddleMgmt y SeniorMgMt
var employees = new List<Empleado>
{
    new Administrative("John", 5),
    new Factory("Jane", 3),
    new MiddleMgmt("Jim", 2),
    new SeniorMgmt("Jill", 7)
};
// Mostrar la información de los empleados mediante un bucle foreach 
// y el metodo ToString que se ha sobrescrito en cada clase
foreach (Empleado employee in employees)
{
    Console.WriteLine(employee.ToString());
}

// Crear una serie de libros basados en las clases Literature, Popular, History y Science
var books = new List<Book>
{
    new Literature("The Great Gatsby", "F. Scott Fitzgerald",250),
    new Popular("The Da Vinci Code", "Dan Brown",300),
    new History("The Guns of August", "Barbara Tuchman",400),
    new Science("A Brief History of Time", "Stephen Hawking",500)
};

// Mostrar la información de los libros mediante un bucle foreach y el método DisplayInfo
foreach (Book book in books)
{
    book.DisplayInfo();
}
