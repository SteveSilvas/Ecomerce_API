using AutoMapper;
using Ecomerce.DTO;
using Ecomerce.Model;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Address, AddressDTO>();
        CreateMap<AddressDTO, Address>();
        CreateMap<Department, DepartmentDTO>();
        CreateMap<DepartmentDTO, Department>();

        CreateMap<Employee, EmployeeDTO>()
            .ForMember(dest => dest.Admission, opt => opt.MapFrom(src => src.Admission.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")));
            //.ForMember(dest => dest.Resignation, opt => opt.MapFrom(src => src.Resignation.ToString("yyyy-MM-ddTHH:mm:ss.fffZ")));

        CreateMap<EmployeeDTO, Employee>();
    }
}
