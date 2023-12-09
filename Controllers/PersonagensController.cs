
using HollowKnightAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RpgApi.Models;

namespace HollowKnightAPI.Controllers
{

    [Controller]
    [Route("[Controller]")]
    public class PersonagensController : ControllerBase
    {
        private readonly DataContext _context;

        public PersonagensController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{usuarioId}")]
        public async Task<IActionResult> GetUsuario(int id)
        {
            try
            {
                Personagem personagem = await _context.TB_PERSONAGENS.FirstOrDefaultAsync(x => x.Id == id);

                return Ok(personagem);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        public async Task<IActionResult> AdicionarPersonagemAsync(Personagem novoPersonagem)
        {

            try
            {
                var entry = await _context.TB_PERSONAGENS.AddAsync(novoPersonagem);
                var personagem = entry.Entity;

                await _context.SaveChangesAsync();

                return new ObjectResult(personagem) { StatusCode = 201 };
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar personagem: {ex.Message}");
            }

        }

    }
}