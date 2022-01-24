using Desafio.Data;
using Desafio.Model;
using Desafio.view;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace Desafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("todos/{id}")]
        public async Task<IActionResult> GetByIdAsync(
            [FromServices] AppDbContext context,
            [FromRoute] int id)
        {
            var todo = await context
                .Despesas
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.idDespesa == id);

            return todo == null
                ? NotFound()
                : Ok(todo);
        }

        [HttpPost("todos")]
        public async Task<IActionResult> PostAsync(
            [FromServices] AppDbContext context,
            [FromBody] DespesaViewModel model)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var despesa = new Despesa
            {
                unidade = model.unidade,
                descricao = model.descricao,
                tipoDespesa = model.tipoDespesa,
                valor = model.valor,
                vencimentoFatura = model.vencimentoFatura,
                statusPagamento = model.statusPagamento
            };

            try
            {
                await context.Despesas.AddAsync(despesa);
                await context.SaveChangesAsync();
                return Created($"v1/todos/{despesa.idDespesa}", despesa);
            }
            catch (Exception e)
            {
                return BadRequest();
            }
        }
    }
}
