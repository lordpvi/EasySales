using System.CodeDom.Compiler;
using System.Data.Entity.Migrations;
using System.Data.Entity.Migrations.Infrastructure;
using System.Resources;

// <auto-generated />
namespace EasySales.Infrastructure.Repositories.Migrations
{
   
    [GeneratedCode("EntityFramework.Migrations", "6.1.3-40302")]
    public sealed partial class version_1 : IMigrationMetadata
    {
        private readonly ResourceManager Resources = new ResourceManager(typeof(version_1));
        
        string IMigrationMetadata.Id
        {
            get { return "201609071709006_version_1"; }
        }
        
        string IMigrationMetadata.Source
        {
            get { return null; }
        }
        
        string IMigrationMetadata.Target
        {
            get { return Resources.GetString("Target"); }
        }
    }
}