namespace AgencyPro.Services.Mapping
{
    public partial class OrganizationProjections
    {
        private void AgreementProjections()
        {
            CreateMap<Organization, RecruitingAgreementOutput>()
                .ForMember(x => x.RecruitingOrganizationName, y => y.MapFrom(x => x.Name))
                .ForMember(x => x.RecruiterOrganizationImageUrl, y => y.MapFrom(x => x.ImageUrl))
                .IncludeAllDerived();
        }
    }
}