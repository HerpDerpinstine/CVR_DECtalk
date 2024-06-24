using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(CVR_DECtalk.BuildInfo.Description)]
[assembly: AssemblyDescription(CVR_DECtalk.BuildInfo.Description)]
[assembly: AssemblyCompany(CVR_DECtalk.BuildInfo.Company)]
[assembly: AssemblyProduct(CVR_DECtalk.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + CVR_DECtalk.BuildInfo.Author)]
[assembly: AssemblyTrademark(CVR_DECtalk.BuildInfo.Company)]
[assembly: AssemblyVersion(CVR_DECtalk.BuildInfo.Version)]
[assembly: AssemblyFileVersion(CVR_DECtalk.BuildInfo.Version)]
[assembly: MelonInfo(typeof(CVR_DECtalk.CVR_DECtalk), CVR_DECtalk.BuildInfo.Name, CVR_DECtalk.BuildInfo.Version, CVR_DECtalk.BuildInfo.Author, CVR_DECtalk.BuildInfo.DownloadLink)]
[assembly: MelonGame("Alpha Blend Interactive", "ChilloutVR")]
[assembly: MelonPlatform(MelonPlatformAttribute.CompatiblePlatforms.WINDOWS_X64)]