using AutoMapper;
using ServiceManager.BusinessLogic.DAO;
using ServiceManager.DataAccess.Model;
using System.Globalization;

namespace ServiceManager.BusinessLogic.Mapping.Profiles
{
  public class RepairActionProfile : Profile
  {
    public RepairActionProfile()
    {
      CreateMap<RepairActions, RepairActionView>()
        .ForMember(d => d.RepairActionDefinition, o => o.Ignore())
        .ForMember(d => d.ActionDate, o => o.MapFrom(s => s.ActionDate.ToString("g",
          DateTimeFormatInfo.InvariantInfo)));
    }
  }
}
