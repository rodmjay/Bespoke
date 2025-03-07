using System.Reflection;
using Bespoke.Data.Attributes;

namespace Bespoke.Data.Helpers;

public class AssemblyFinder
{
    public static Assembly FindSeedAssembly()
    {
        var currentDomain = AppDomain.CurrentDomain;
        var assemblies = currentDomain.GetAssemblies();

        // Find the first assembly with the SeedAssemblyAttribute
        var seedAssembly = assemblies.FirstOrDefault(assembly =>
            assembly.GetCustomAttributes(typeof(SeedAssemblyAttribute), false).Any());

        return seedAssembly;
    }
}