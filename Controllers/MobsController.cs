using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using HollowKnightAPI.Models.Enuns;
using HollowKnightAPI.models;
using HollowKnightAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace HollowKnightAPI.Controllers
{

    [ApiController]
    [Route("[Controller]")]
    public class MobsController : ControllerBase
    {
        private readonly DataContext _context;

        public MobsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetMob(int id)
        {
            try
            {
                Mob mob = await _context.TB_MOBS.FirstOrDefaultAsync(x => x.Id == id);

                return Ok(mob);  
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Mob> lista = await _context.TB_MOBS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarPersonagemAsync(Mob novoMob)
        {

            try
            {
                var entry = await _context.TB_MOBS.AddAsync(novoMob);
                var personagem = entry.Entity;

                await _context.SaveChangesAsync();

                return new ObjectResult(novoMob) { StatusCode = 201 };
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar novo boss: {ex.Message}");
            }

        }

        [HttpPut]
        public async Task<IActionResult> Update(Mob novoMob)
        {
            try
            {
                _context.TB_MOBS.Update(novoMob);
                int linhaAfetadas = await _context.SaveChangesAsync();

                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                Mob mRemover = await _context.TB_MOBS.FirstOrDefaultAsync(m => m.Id == id);

                _context.TB_MOBS.Remove(mRemover);
                int linhaAfetadas = await _context.SaveChangesAsync();

                return Ok(linhaAfetadas);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}