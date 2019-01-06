using System.Collections.Generic;

namespace ServiceManager.BusinessLogic.DAO
{
  public class RepairView
  {
    public string Number { get; set; }
    public string AddedDate { get; set; }
    public string Status { get; set; }
    public string DeviceStatus { get; set; }
    public string ExpectedComplentionDate { get; set; }

    public List<RepairActionView> RepairActions { get; set; }
  }
}
