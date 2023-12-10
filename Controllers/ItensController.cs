using HollowKnightAPI.Data;
using HollowKnightAPI.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HollowKnightAPI.Controllers
{

    [Controller]
    [Route("[Controller]")]
    public class ItensController : ControllerBase
    {
        private readonly DataContext _context;

        public ItensController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{Id}")]
        public async Task<IActionResult> GetItem(int id)
        {
            try
            {
                Item item = await _context.TB_ITENS.FirstOrDefaultAsync(x => x.Id == id);

                return Ok(item);  
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarItemAsync(Item novoItem)
        {

            try
            {
                var entry = await _context.TB_ITENS.AddAsync(novoItem);
                var personagem = entry.Entity;

                await _context.SaveChangesAsync();

                return new ObjectResult(novoItem) { StatusCode = 201 };
            }
            catch (Exception ex)
            {
                return BadRequest($"Erro ao adicionar novo Item: {ex.Message}");
            }

        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> Get()
        {
            try
            {
                List<Item> lista = await _context.TB_ITENS.ToListAsync();
                return Ok(lista);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Update(Item novoItem)
        {
            try
            {
                _context.TB_ITENS.Update(novoItem);
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
                Item iRemover = await _context.TB_ITENS.FirstOrDefaultAsync(i => i.Id == id);

                _context.TB_ITENS.Remove(iRemover);
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