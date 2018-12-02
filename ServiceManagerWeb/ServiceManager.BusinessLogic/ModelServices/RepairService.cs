using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ServiceManager.BusinessLogic.DAO;
using ServiceManager.BusinessLogic.Interfaces;
using ServiceManager.DataAccess.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ServiceManager.BusinessLogic.ModelServices
{
  public class RepairService : IRepairService
  {
    public async Task<RepairView> GetRepairAsync(string repairId, string email)
    {
      using (var db = new SmContext())
      {
        var repair = await db.Repairs.Include(r => r.RepairStatus)
          .Include(r => r.Device.DeviceStatus)
          .SingleOrDefaultAsync(r => r.RepairNumber == repairId && r.Client.Email == email);
        var repairView = Mapper.Map<Repairs, RepairView>(repair);
        repairView.RepairActions = new List<RepairActionView>();
        var repairActions = db.RepairActions.Where(ra => ra.RepairId == repair.Id)
          .ToList();
        foreach (var repairAction in repairActions)
        {
          var repairActionView = Mapper.Map<RepairActions, RepairActionView>(repairAction);
          repairActionView.RepairActionDefinition = db.RepairActionDefinitions
            .SingleOrDefault(d => d.Id == repairAction.RepairActionDefinitionId)
            ?.Name;
          repairView.RepairActions.Add(repairActionView);
        }
        return repairView;
      }
    }
  }
}
