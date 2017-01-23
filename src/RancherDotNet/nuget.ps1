nuget pack RancherDotNet.nuspec -Symbols -Exclude "*.pdb"

#nuget push RancherDotNet.nupkg -source nuget.org