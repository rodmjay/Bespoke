﻿using AutoMapper;

namespace AgencyPro.Services.Mapping;

public class BuyerAccountProjections : Profile
{
    public BuyerAccountProjections()
    {
        CreateMap<BuyerAccount, BuyerAccountOutput>()
            .ForMember(x => x.Balance, opt => opt.MapFrom(x => x.Balance))
            .ForMember(x => x.Delinquent, opt => opt.MapFrom(x => x.Delinquent))
            .IncludeAllDerived();

        CreateMap<OrganizationBuyerAccount, BuyerAccountOutput>()
            .IncludeMembers(x => x.BuyerAccount);

        CreateMap<IndividualBuyerAccount, BuyerAccountOutput>()
            .IncludeMembers(x => x.BuyerAccount);
    }
}