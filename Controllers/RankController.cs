using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Storage;
using TopRankAPI.DataBaseInstructions;
using TopRankAPI.Entities;

namespace TopRankAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RankController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<RankItem>>> GeAllResults()
        {
            return Ok(DataBase.GetItems());
        }
        [HttpGet]
        [Route("best")]
        public async Task<ActionResult<List<RankItem>>> BestResult()
        {
            return Ok(DataBase.BestResult());
        }
        [HttpPost]
        public async Task<ActionResult<List<RankItem>>> AddItem(RankItem rankItem)
        {
            DataBase.AddItem(rankItem);
            return Ok(rankItem);
        }
    }
}