using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data; //trocando para escopo de arquivo

public class FilmeContext : DbContext
{
    public FilmeContext(DbContextOptions<FilmeContext> opts)
        : base(opts) 
    {

    }

    public DbSet<Filme> Filmes { get; set; }
}
