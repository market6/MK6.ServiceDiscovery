#load "tools/MK6.Tools.CakeBuild.Core/core.params.cake"

#tool nuget:?package=Grpc.Tools&version=1.0.0-pre1
#tool nuget:?package=OctopusTools

BuildParams buildParams = BuildParams.GetParams(Context);

// Install addins.
#addin nuget:?package=MK6.Tools.CakeBuild.Grpc

// Include Additional Cake files
#load "tools/MK6.Tools.CakeBuild.Core/core.dnx.cake" 

Task("Clean")
    .IsDependentOn("CoreClean")
    .Does(() => {

});

Task("RestoreNuGetPackages")
    .IsDependentOn("CoreRestoreNuGetPackages")
    .Does(() =>
{
   
});

Task("Build")
    .IsDependentOn("CoreBuild")
    .Does(() =>
{
    
});

Task("Package")
    .IsDependentOn("CoreDNXPackage")
    .Does(() =>
{

});

Task("Publish")
    .IsDependentOn("CorePublish")
    .Does(() =>
{
      
});

Task("UpdateAssemblyInfo")
    .IsDependentOn("CoreUpdateAssemblyInfo")
    .Does(() =>
{
      
});

Task("ProtoCompile")
    .Does(() => 
{
    var protoCompileSettings = new ProtoCompileSettings 
                                    { 
                                        ProtoInputFile = "protos/pubsubstatusservice.proto", 
                                        ProtoImportPath = "protos",
                                        CSharpOutputPath = "MK6.ServiceDiscovery.Server.Host"
                                    };
    
    ProtoCompile(protoCompileSettings);
});

Task("CreateOctoRelease")
    .IsDependentOn("ProtoCompile")
    .IsDependentOn("Package")
    .Does(() =>
{
    var projectName = Argument<string>("octopusProjectName");

    OctoCreateRelease(projectName, new CreateReleaseSettings {
        Server = EnvironmentVariable("octopus_url"),
        ApiKey = EnvironmentVariable("octopus_api_key"),
        EnableServiceMessages = true,
        ReleaseNumber = buildParams.Version,
        DefaultPackageVersion = buildParams.Version,
    });
});

Task("Default")
  .IsDependentOn("ProtoCompile")
  .IsDependentOn("Build")
  .Does(() =>
{

});

RunTarget(buildParams.Target);
