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
    public async Task<RepairView> GetRepairAsync(int repairId, string email)
    {
      using (var db = new SmContext())
      {
        var repair = await db.Repairs.Include(r => r.RepairStatus)
          .Include(r => r.Client)
          .SingleOrDefaultAsync(r => r.Id == repairId && r.Client.Email == email);
        var repairView = Mapper.Map<Repairs, RepairView>(repair);
        return repairView;
      }
    }
  }
}
