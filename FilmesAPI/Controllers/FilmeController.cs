using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace FilmesAPI.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FilmeController : ControllerBase
    {
        //instanciando uma variavel do tipo listaDeFilmes para fazer a lista em memória
        private static List<Filme> filmes = new List<Filme>();
        private static int idFilme = 0;

        [HttpPost]
        public IActionResult AdcionarFilme([FromBody] Filme filme)
        {
            filme.Id = idFilme++;
            filmes.Add(filme);//adcionando um filme a listaDeFilmes
            return CreatedAtAction(nameof(SelecionarFilmePorId), new { id = filme.Id }, filme);
        }

        [HttpGet]
        public IEnumerable<Filme> ListarFilmes( //posso retornar uma List<Filme> mas um IEnumerable é mais garantido que não precise mudar o código posteriormente
            [FromQuery] int skip = 0    //valor padrao do skip será 0,
            ,[FromQuery] int take = 50 // valor padrao do take será 50
            ) 
        {
            return filmes.Skip(skip).Take(take);
        }

        [HttpGet("{id}")]
        //public Filme? SelecionarFilmePorId(int id)// Aqui seria o retorno do próprio objeto de filme
        public IActionResult SelecionarFilmePorId(int id)// o retorno de IActionResult é o retorno de uma ação 
        {
            var filme = filmes.FirstOrDefault(filme => filme.Id == id);
            if (filme == null) return NotFound();
            return Ok(filme);
        }

    }
}
