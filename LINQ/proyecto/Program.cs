LinqQueries queries = new LinqQueries();

//toda la coleccion
//ImprimirValores(queries.TodaLaColeccion());


//libros despues del 2000
//ImprimirValores(queries.LibrosDespuesDel200());


//libros de mas de 250 paginas y titulo: in Action
//ImprimirValores(queries.Libros250PaginaAction());


//status no es null
//System.Console.WriteLine("todos los libros tienen status?: " + queries.LibrosStatuNotNull());

//libros del 2005
//Console.WriteLine("algun libro publicado en 2005? "+ queries.Libros2005());


//libros con categoria de python
//ImprimirValores(queries.LibrosCategoriaPython());


//libros con categoria de java y orden en nombre
//ImprimirValores(queries.LibrosJavaOrdenNombre());

//libros con mas de 450 paginas y orden descendente numero de paginas
//ImprimirValores(queries.Libros450PaginasOrdenDescendente());


//libros categoria java y los 3 ultimos publicados
//ImprimirValores(queries.Libros3UltimosJava());

//libros mas de 400 paginas y el3 y 4 libro
//ImprimirValores(queries.Libros400PaginasSoloTresCuatro());


//libros 3 primeros con select
//ImprimirValores(queries.LibroTituloPaginas3Primeros());


//libros entre 200 y 500 paginas
//System.Console.WriteLine(queries.Libro200500Paginas());

//libros fecha mas viejo
//System.Console.WriteLine(queries.LibroViejo());

//libros numero de paginas mas
//System.Console.WriteLine(queries.LibroMasPagina());


//libros con menor numero de paginas y diferente de 0
//System.Console.WriteLine(queries.LibroMenorPagina().Title + " paginas: " + queries.LibroMenorPagina().PageCount);

//libros numero de paginas mas
//System.Console.WriteLine(queries.LibroReciente().Title + " fecha: " + queries.LibroReciente().PublishedDate);


//libros sumas las paginas de los libros que tengan entre 0 500 paginas
//System.Console.WriteLine(queries.LibroSuma0500Paginas());

//libros sumas las paginas de los libros que tengan entre 0 500 paginas
//System.Console.WriteLine(queries.LibroTitulos2015Adelante());

//libros promedio caracteres titulo
//System.Console.WriteLine(queries.LibrosAverageCaracteresTitulos());

//libros desde el 2000 agrupados por año
//ImprimirGrupo(queries.LibrosDesde2000PorAno());

//libro con diccionarios agrupados por primera letra
//ImprimirDiccionario(queries.LibrosDiccionarioPorLetra(), "A"[0]);

//libro uniendo 2 colecciones con join
ImprimirValores(queries.LibrosJoin());



void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

void ImprimirGrupo(IEnumerable<IGrouping<int,Book>> ListadeLibros)
{
    foreach(var grupo in ListadeLibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: { grupo.Key }");
        Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
        foreach(var item in grupo)
        {
            Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
        }
    }
}


void ImprimirDiccionario(ILookup<char, Book> ListadeLibros, char letra)
{
   Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
   foreach(var item in ListadeLibros[letra])
   {
         Console.WriteLine("{0,-60} {1, 15} {2, 15}",item.Title,item.PageCount,item.PublishedDate.Date.ToShortDateString()); 
   }
}