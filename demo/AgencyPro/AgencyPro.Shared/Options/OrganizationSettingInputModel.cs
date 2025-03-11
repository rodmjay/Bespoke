using System.ComponentModel.DataAnnotations;
using AgencyPro.Shared.Models;

namespace AgencyPro.Shared.Options
{
    public class OrganizationSettingInputModel : OrganizationSettingOutput
    {
        [EnumDataType(typeof(SectionType))]
        public SectionType SectionType { get; set; }
    }
}
