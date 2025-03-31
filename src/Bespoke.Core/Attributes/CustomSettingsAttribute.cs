namespace Bespoke.Core.Attributes
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public sealed class CustomSettingsAttribute : Attribute
    {
        public string SectionName { get; }
        public CustomSettingsAttribute(string sectionName)
        {
            SectionName = sectionName;
        }
    }
}
