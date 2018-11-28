using AutoMapper;
using ServiceManager.BusinessLogic.DAO;
using ServiceManager.DataAccess.Model;

namespace ServiceManager.BusinessLogic.Mapping.Profiles
{
  public class RepairProfile : Profile
  {
    public RepairProfile()
    {
      CreateMap<Repairs, RepairView>()
        .ForMember(d => d.Number, o => o.MapFrom(s => s.RepairNumber))
        .ForMember(d => d.AddedDate, o => o.MapFrom(s => s.CreatedDate.ToShortDateString()))
        .ForMember(d => d.Status, o => o.MapFrom(s => s.RepairStatus.Name));
    }
  }
}
