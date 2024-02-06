using Microsoft.VisualBasic;

public class LinqQueries
{
    private List<Book> librosCollection = new List<Book>();

    public LinqQueries()
    {
        using (StreamReader reader = new StreamReader("books.json"))
        {
            string json = reader.ReadToEnd();
            this.librosCollection = System.Text.Json.JsonSerializer.Deserialize<List<Book>>(json, new System.Text.Json.JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
    }

    public IEnumerable<Book> TodaLaColeccion()
    {
        return librosCollection;
    }

    public IEnumerable<Book> LibrosDespuesDel200()
    {
        //extension method
        //return librosCollection.Where(p=> p.PublishedDate.Year > 2000);

        //query expression
        return from l in librosCollection where l.PublishedDate.Year > 2000 select l;
    }

    public IEnumerable<Book> Libros250PaginaAction()
    {
        //extension method
        //return librosCollection.Where(p=> p.PageCount > 250 && p.Title.Contains("in Action"));

        //query expression
        return from l in librosCollection where l.PageCount > 250 && l.Title.Contains("in Action") select l;
    }


    public bool LibrosStatuNotNull()
    {
        //extension method
        return librosCollection.All(p => p.Status != string.Empty);

    }

    public bool Libros2005()
    {
        return librosCollection.Any(p => p.PublishedDate.Year == 2005);
    }


    public IEnumerable<Book> LibrosCategoriaPython()
    {
        return librosCollection.Where(p => p.Categories.Contains("Python"));
    }


    public IEnumerable<Book> LibrosJavaOrdenNombre()
    {
        return librosCollection.Where(p => p.Categories.Contains("Java")).OrderBy(p => p.Title);
    }


    public IEnumerable<Book> Libros450PaginasOrdenDescendente()
    {
        return librosCollection.Where(p => p.PageCount > 450).OrderByDescending(p => p.PageCount);
    }


    public IEnumerable<Book> Libros3UltimosJava()
    {
        return librosCollection
        .Where(p => p.Categories.Contains("Java"))
        .OrderByDescending(p => p.PublishedDate)
        .Take(3);
    }


    public IEnumerable<Book> Libros400PaginasSoloTresCuatro()
    {
        return librosCollection
        .Where(p => p.PageCount > 400)
        .Skip(2)
        .Take(2);
    }


    public IEnumerable<Book> LibroTituloPaginas3Primeros()
    {
        return librosCollection.Take(3).Select(p => new Book { Title = p.Title, PageCount = p.PageCount });
        //return librosCollection.Take(3).Select(p=> new {p.Title, p.PageCount});
    }


    public int Libro200500Paginas()
    {
        return librosCollection.Count(p => p.PageCount >= 200 && p.PageCount <= 500);
    }


    public DateTime LibroViejo()
    {
        return librosCollection.Min(p => p.PublishedDate);
    }


    public int LibroMasPagina()
    {
        return librosCollection.Max(p => p.PageCount);
    }


    public Book LibroMenorPagina()
    {

        return librosCollection.Where(p => p.PageCount != 0).MinBy(p => p.PageCount);
    }


    public Book LibroReciente()
    {
        return librosCollection.MaxBy(p => p.PublishedDate);
    }


    public int LibroSuma0500Paginas()
    {
        return librosCollection.Where(p => p.PageCount >= 0 && p.PageCount <= 500).Sum(p => p.PageCount);
    }


    public string LibroTitulos2015Adelante()
    {
        return librosCollection
                        .Where(p => p.PublishedDate.Year > 2015)
                        .Aggregate("", (TitulosLibros, next) =>
                        {
                            if (TitulosLibros != string.Empty)
                                TitulosLibros += " - " + next.Title;
                            else
                                TitulosLibros += next.Title;

                            return TitulosLibros;
                        });
    }


    public double LibrosAverageCaracteresTitulos()
    {
        return librosCollection.Average(p => p.Title.Length);
    }


    public IEnumerable<IGrouping<int, Book>> LibrosDesde2000PorAno()
    {
        return librosCollection.Where(p => p.PublishedDate.Year > 2000).GroupBy(p => p.PublishedDate.Year);
    }


    public ILookup<char, Book> LibrosDiccionarioPorLetra()
    {
        return librosCollection.ToLookup(p => p.Title[0], p => p);
    }


    public IEnumerable<Book> LibrosJoin()
    {
        var l500 = librosCollection.Where(p=> p.PageCount > 500);
        var l2005 = librosCollection.Where(p=> p.PublishedDate.Year > 2005);

        return l500.Join(l2005, p=> p.Title, x=> x.Title, (p,x) => p);
    }



}