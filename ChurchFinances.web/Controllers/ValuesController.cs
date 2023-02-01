using ChurchFinances.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChurchFinances.web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
     [HttpGet]
     public ActionResult<List<DizimoModel>> BuscarTodosLancamentos()
        {
            return Ok();
        }
    }
}
