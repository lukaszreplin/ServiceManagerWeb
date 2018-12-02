using ServiceManager.BusinessLogic.DAO;
using System.Threading.Tasks;

namespace ServiceManager.BusinessLogic.Interfaces
{
  public interface IRepairService
  {
    Task<RepairView> GetRepairAsync(string repairId, string email);
  }
}
