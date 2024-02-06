using Microsoft.EntityFrameworkCore;
using projectoef.Models;

namespace projectoef;

public class TareasContext : DbContext
{
    public DbSet<Categoria> Categorias { get; set; }
    public DbSet<Tarea> Tareas { get; set; }


    public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

    //aplicando FluentAPI. esto sirve para especificar las columnas y nombre de la tabla
    //                      sin usar data annotations
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Categoria> categoriasInit = new List<Categoria>();
        categoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("c4e0d0e7-5f06-48c7-9246-11fe12f2c657"), Nombre = "Actividades Pendientes", Peso = 20 });
        categoriasInit.Add(new Categoria() { CategoriaId = Guid.Parse("c4e0d0e7-5f06-48c7-9246-11fe12f2c602"), Nombre = "Actividades Personales", Peso = 50 });



        modelBuilder.Entity<Categoria>(categoria =>
        {
            categoria.ToTable("Categoria");
            categoria.HasKey(p => p.CategoriaId);
            categoria.Property(p => p.Nombre).IsRequired().HasMaxLength(150);
            categoria.Property(p => p.Descripcion).IsRequired(false);
            categoria.Property(p => p.Peso);

            categoria.HasData(categoriasInit);
        });

        List<Tarea> tareasInit = new List<Tarea>();
        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("c4e0d0e7-5f06-48c7-9246-11fe12f2c100"), CategoriaId = Guid.Parse("c4e0d0e7-5f06-48c7-9246-11fe12f2c657"), PrioridadTarea = Prioridad.Media, Titulo = "Pago de servicios publicos", FechaCreacion = DateTime.Now });
        tareasInit.Add(new Tarea() { TareaId = Guid.Parse("c4e0d0e7-5f06-48c7-9246-11fe12f2c110"), CategoriaId = Guid.Parse("c4e0d0e7-5f06-48c7-9246-11fe12f2c602"), PrioridadTarea = Prioridad.Baja, Titulo = "Terminar pelicula", FechaCreacion = DateTime.Now });

        modelBuilder.Entity<Tarea>(tarea =>
        {
            tarea.ToTable("Tarea");
            tarea.HasKey(t => t.TareaId);
            tarea.HasOne(t => t.Categoria).WithMany(t => t.Tareas).HasForeignKey(t => t.CategoriaId);
            tarea.Property(t => t.Titulo).IsRequired().HasMaxLength(200);
            tarea.Property(t => t.Descripcion).IsRequired(false);
            tarea.Property(t => t.PrioridadTarea);
            tarea.Property(t => t.FechaCreacion);
            //tarea.Property(t => t.Categoria);
            tarea.Ignore(t => t.Resumen);

            tarea.HasData(tareasInit);

        });
    }

}