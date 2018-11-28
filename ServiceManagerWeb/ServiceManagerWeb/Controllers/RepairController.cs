using Microsoft.AspNetCore.Mvc;
using ServiceManager.BusinessLogic.DAO;
using ServiceManager.BusinessLogic.Interfaces;

namespace ServiceManagerWeb.Controllers
{
  [Route("api/[controller]")]
  public class RepairController : Controller
  {
    private readonly IRepairService repairService;

    public RepairController(IRepairService repairService)
    {
      this.repairService = repairService;
    }


    [HttpGet("{id}")]
    public IActionResult GetRepair([FromRoute] int id)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      var repair = new RepairView();

      if (repair == null)
      {
        return NotFound();
      }

      return Ok(repair);
    }
  }
}
