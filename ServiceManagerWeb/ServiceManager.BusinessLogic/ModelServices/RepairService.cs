using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ServiceManager.BusinessLogic.DAO;
using ServiceManager.BusinessLogic.Interfaces;
using ServiceManager.DataAccess.Model;
using System.Threading.Tasks;

namespace ServiceManager.BusinessLogic.ModelServices
{
  public class RepairService : IRepairService
  {
    public async Task<RepairView> GetRepairAsync(int repairId)
    {
      using (var db = new SmContext())
      {
        var repair = await db.Repairs.Include(r => r.RepairStatus).SingleOrDefaultAsync(r => r.Id == repairId);
        var repairView = Mapper.Map<Repairs, RepairView>(repair);
        return repairView;
      }
    }
  }
}
