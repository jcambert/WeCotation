using MicroS_Common.Mongo;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeCotation.domain.Matieres.Domain;
using WeCotation.domain.TypeMatieres.Domain;

namespace WeCotation.Services.Cotation
{
    public class DatabaseSeeder : MongoDbSeeder, IMongoDbSeeder
    {
        public DatabaseSeeder(IMongoDatabase database) : base(database)
        {
        }
        protected override async Task CustomSeedAsync()
        {

            await Database.DropCollectionAsync("typematiere");
            await Database.CreateCollectionAsync("typematiere");
            var tmpcol = Database.GetCollection<TypeMatiere>("typematiere");
            List<TypeMatiere> typeMatieres = new List<TypeMatiere>()
            {
                 new TypeMatiere() {Nom="acier",Densite=8f,Matieres=new Matiere[]{ new Matiere() { Designation="XC10 <3",PrixKg=0.75f},new Matiere() { Designation="XC10 >=3",PrixKg=0.68f} } },
                 new TypeMatiere() {Nom="inox",Densite=8f },
                 new TypeMatiere() {Nom="aluminium",Densite=2.8f },
                 new TypeMatiere() {Nom="laiton",Densite=8.5f },
                 new TypeMatiere() {Nom="cuivre",Densite=9.0f },
                 new TypeMatiere() {Nom="bronze",Densite=9.0f },
                 new TypeMatiere() {Nom="plastique",Densite=1.2f },

            };

            await tmpcol.InsertManyAsync(typeMatieres);
            await base.CustomSeedAsync();
        }
    }
}
