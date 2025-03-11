using AgencyPro.Domain.Entities;
using AgencyPro.Shared.Enums;
using AgencyPro.Shared.Models;
using AutoMapper;

namespace AgencyPro.Services.Mapping
{
    public class OrganizationRecruiterProjections : Profile
    {
        public OrganizationRecruiterProjections()
        {
            CreateMap<OrganizationRecruiter, OrganizationRecruiterOutput>()
                .ForMember(x => x.DisplayName, opt => opt.MapFrom(x => x.Recruiter.Person.FirstName))
                .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Recruiter.Person.User.Email))
                .ForMember(x => x.PhoneNumber, opt => opt.MapFrom(x => x.Recruiter.Person.User.PhoneNumber))
                .ForMember(x => x.ImageUrl, opt => opt.MapFrom(x => x.Recruiter.Person.ImageUrl))
                .ForMember(x => x.Status, opt => opt.MapFrom(x => x.OrganizationPerson.Status))
                .IncludeAllDerived();

            CreateMap<OrganizationRecruiter, OrganizationRecruiterStatistics>()
                .ForMember(x => x.TotalCandidates, opt => opt.MapFrom(x => x.Candidates.Count))
                .ForMember(x => x.TotalContractors, opt => opt.MapFrom(x => x.Contractors.Count))
                .ForMember(x => x.TotalContracts, opt => opt.MapFrom(x => x.Contracts.Count))
                .IncludeAllDerived();

            CreateMap<OrganizationRecruiter, AgencyOwnerOrganizationRecruiterOutput>();
            CreateMap<OrganizationRecruiter, AccountManagerOrganizationRecruiterOutput>();
            CreateMap<OrganizationRecruiter, RecruiterOrganizationRecruiterOutput>();
            CreateMap<OrganizationRecruiter, ContractorOrganizationRecruiterOutput>();

            CreateMap<OrganizationRecruiter, RecruiterCounts>()
                .ForMember(x => x.Candidates, opt => opt.MapFrom(x => x.Candidates.Count))
                .ForMember(x => x.Contracts, opt => opt.MapFrom(x => x.Contracts.Count))
                .ForMember(x => x.ChannelPartners, opt => opt.MapFrom(x => x.Organization.RecruitingOrganization.RecruitingAgreements.Count(y => y.Status == AgreementStatus.Approved)))
                .ForMember(x => x.Contractors, opt => opt.MapFrom(x => x.Contractors.Count));


            CreateMap<OrganizationRecruiter, RecruiterOrganizationOutput>()
                .IncludeMembers(x => x.Organization)
                .ForMember(x => x.RecruiterStream, o => o.MapFrom(x => x.RecruiterStream))
                .ForMember(x => x.RecruiterBonus, o => o.MapFrom(x => x.RecruiterBonus))
                .IncludeAllDerived();

        }
    }
}