using AutoMapper;

namespace AgencyPro.Services.Mapping;

internal class CommentProjections : Profile
{
    public CommentProjections()
    {
        CreateMap<Comment, CommentOutput>()
            .ForMember(x => x.PersonName, opt => opt.MapFrom(x => x.Creator.Person.FirstName))
            .ForMember(x => x.PersonId, opt => opt.MapFrom(x => x.CreatedById))
            .ForMember(x => x.PersonImageUrl, opt => opt.MapFrom(x => x.Creator.Person.ImageUrl))
            .ForMember(x => x.OrganizationName, opt => opt.MapFrom(x => x.Creator.Organization.Name))
            .ForMember(x => x.OrganizationImageUrl, opt => opt.MapFrom(x => x.Creator.Organization.ImageUrl))
            .ForMember(x => x.OrganizationId, opt => opt.MapFrom(x => x.OrganizationId))
            .ForMember(x => x.Created, opt => opt.MapFrom(x => x.Created))
            .ForMember(x => x.Body, opt => opt.MapFrom(x => x.Body));
    }
}