using AutoMapper;
using ServiceManager.BusinessLogic.DAO;
using ServiceManager.DataAccess.Model;
using System.Globalization;

namespace ServiceManager.BusinessLogic.Mapping.Profiles
{
  public class RepairProfile : Profile
  {
    public RepairProfile()
    {
      CreateMap<Repairs, RepairView>()
        .ForMember(d => d.Number, o => o.MapFrom(s => s.RepairNumber))
        .ForMember(d => d.AddedDate, o => o.MapFrom(s => s.CreatedDate.ToString("g",
          DateTimeFormatInfo.InvariantInfo)))
        .ForMember(d => d.ExpectedComplentionDate, o => o.MapFrom(s => s.ExpectedComplentionDate.ToString("d", DateTimeFormatInfo.InvariantInfo)))
        .ForMember(d => d.DeviceStatus, o => o.MapFrom(s => s.Device.DeviceStatus.Name))
        .ForMember(d => d.Status, o => o.MapFrom(s => s.RepairStatus.Name))
        .ForMember(d => d.RepairActions, o => o.Ignore());
    }
  }
}
