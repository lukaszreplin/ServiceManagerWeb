using Microsoft.AspNetCore.Mvc;
using ServiceManager.BusinessLogic.Interfaces;
using ServiceManager.BusinessLogic.ModelServices;
using System.Threading.Tasks;

namespace ServiceManagerWeb.Controllers
{
  [Route("api/[controller]")]
  public class RepairController : Controller
  {
    private readonly IRepairService repairService;

    public RepairController()
    {
      this.repairService = new RepairService();
    }


    [HttpGet("{id}/{email}")]
    public async Task<IActionResult> GetRepair([FromRoute] int id, string email)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      var repair = await repairService.GetRepairAsync(id, email);

      if (repair == null)
      {
        return NotFound();
      }

      return Ok(repair);
    }
  }
}
