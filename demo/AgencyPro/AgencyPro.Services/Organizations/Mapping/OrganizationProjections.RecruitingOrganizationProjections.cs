namespace AgencyPro.Services.Mapping;

public partial class OrganizationProjections
{
    private void RecruitingOrganizationProjections()
    {
        CreateMap<Organization, RecruitingOrganizationOutput>()
            .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.ImageUrl, opt => opt.MapFrom(src => src.ImageUrl))
            .ForMember(dest => dest.OrganizationType, opt => opt.MapFrom(src => src.OrganizationType))
            .ForMember(dest => dest.Recruiters, opt => opt.MapFrom(src => src.Recruiters.Count))
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
            .ForMember(dest => dest.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
            .ForMember(dest => dest.CategoryName, opt => opt.MapFrom(src => src.Category.Name))
            .ForMember(dest => dest.PrimaryColor, opt => opt.MapFrom(src => src.PrimaryColor))
            .ForMember(dest => dest.SecondaryColor, opt => opt.MapFrom(src => src.SecondaryColor))
            .ForMember(dest => dest.TertiaryColor, opt => opt.MapFrom(src => src.TertiaryColor));

        CreateMap<Organization, RecruiterOrganizationOutput>()
            .IncludeBase<Organization, RecruitingOrganizationOutput>();

        CreateMap<Organization, RecruitingAgencyOwnerOrganizationOutput>();
        CreateMap<Organization, AgencyOwnerRecruitingOrganizationDetailsOutput>();
        CreateMap<Organization, ProviderAgencyOwnerRecruitingOrganizationOutput>();
    }
}