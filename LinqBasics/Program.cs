// See https://aka.ms/new-console-template for more information
using LinqBasics;
using System.Collections.Generic;
using System.Text;
using vm.Aspects.Diagnostics;

Console.WriteLine("Basics of Linq!");

/*
    Para ver como funciona cada ejemplo descomenta cada ejemplo, lo hice ya que se me hace tedioso ver muchas cosas en la consola

 */

//ejemplo 1
//TestArray.Ejemplo1();

//ejemplo 2
//var oTestArrayBooks = new TestArrayBooks();
//oTestArrayBooks.crearLibros();

//ejemplo 3
//var oSpanishNumbers = new TestDictionary();
//oSpanishNumbers.crearDiccionario();
//oSpanishNumbers.numerosPares();



//ejemplo 4 y el mas "complejo"
//var oSemana = new Semana();

//var dia1 = new Dia
//{
//    MoneyOwned = 500,
//    MoneyUsed = 200,
//    day = "Lunes"
//};
//var dia2 = new Dia
//{
//    MoneyOwned = 100,
//    MoneyUsed = 500,
//    day = "Martes"
//};
//var dia3 = new Dia
//{
//    MoneyOwned = 0,
//    MoneyUsed = 200,
//    day = "Miercoles"
//};
//oSemana.agregarDia(dia1);
//oSemana.agregarDia(dia2);
//oSemana.agregarDia(dia3);

//var semana = oSemana.devolverSemana();

//var diasGanado =
//    from dia in semana
//    where(dia.MoneyOwned) > 0
//    select dia;
//var dineroGanado =
//    diasGanado.Sum(dia=>dia.MoneyOwned);
//Console.Write(dineroGanado.ToString()); 
   


Console.ReadLine();
static class TestArray
{
    public static void Ejemplo1()
    {
        Object[] array = { 1, 2, 3,"Hi Mom!",2.3 };

        var types =
            array
                .Select(item => item.GetType().Name)
                .OrderBy(type => type);

        foreach (var item in types)
        {
            Console.WriteLine   (item);
        }
       
    }


}
class Book
{

    public string Title { get; set; }
    public string  Author { get; set; }
}
 class TestArrayBooks
{
    
    public void crearLibros()
    {
        Book[] books = {
            new Book{Title="La melancolica muerte del chico Ostra", Author="Tim Burton" },
            new Book{Title="Linq in Action", Author="Fabrice Marguerie"},
            new Book{Title="Software Engineering", Author="Ian Sommerville"}

        };

        var titles =
            books
                .Where(book => book.Title.Contains("muerte"))
                .Select(book => book.Title);
        foreach (var item in titles) Console.WriteLine(item);
       
    }
}

class TestDictionary
{
    Dictionary<int, string> spanishNumbers = new Dictionary<int, string>();
    public void crearDiccionario()
    {
        spanishNumbers.Add(1, "uno");
        spanishNumbers.Add(2, "dos");
        spanishNumbers.Add(3, "tres");
        spanishNumbers.Add(4, "cuatro");
        spanishNumbers.Add(20, "veinte");

    }
    public void numerosPares()
    {
        var listaNumerosPares =
            from entry in spanishNumbers
            where (entry.Key % 2) == 0
            select entry.Value;

        foreach (var item in listaNumerosPares) Console.WriteLine(item);
        {

        }
    }
}