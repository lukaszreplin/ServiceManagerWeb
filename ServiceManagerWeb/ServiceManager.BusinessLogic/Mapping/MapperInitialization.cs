using AutoMapper;
using ServiceManager.BusinessLogic.Mapping.Profiles;

namespace ServiceManager.BusinessLogic.Mapping
{
  public class MapperInitialization
  {
    public static void Init()
    {
      Mapper.Initialize(cfg =>
      {
        cfg.AddProfile<RepairProfile>();
      });
    }
  }
}
