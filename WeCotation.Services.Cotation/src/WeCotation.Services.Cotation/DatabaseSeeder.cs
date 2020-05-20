using MicroS_Common.Mongo;
using MicroS_Common.RabbitMq;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Threading.Tasks;
using WeCotation.domain.Articles.Domain;
using WeCotation.domain.Nomenclatures.Domain;
using WeCotation.domain.Operations.Domain;
using WeCotation.domain.Parametres.Domain;
using WeCotation.Services.Repositories;

namespace WeCotation.Services.Cotation
{
    public class DatabaseSeeder : MongoDbSeeder, IMongoDbSeeder
    {
        public IBrowseArticleRepository ArticleRepo { get; }
        public IBusPublisher Bus { get; }

        public DatabaseSeeder(IMongoDatabase database, IBrowseArticleRepository articleRepo,IBusPublisher bus) : base(database)
        {
            this.ArticleRepo = articleRepo;
            this.Bus = bus;
        }

        private async Task<IMongoCollection<T>> InitCollection<T>(string name)
        {
            await Database.DropCollectionAsync(name);
            await Database.CreateCollectionAsync(name);
            return Database.GetCollection<T>(name);
        }
        protected override async Task CustomSeedAsync()
        {
            /*await SeedMatiere();
            await SeedOperation();*/
            await SeedArticle();
            await base.CustomSeedAsync();
        }

       /* private async Task SeedMatiere()
        {

            var tmpcol = await InitCollection<TypeMatiere>("typematiere");
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
            
        }*/
        private async Task SeedParametres()
        {
            var col = await InitCollection<Parametre>("parametre");
            var parametres = new List<Parametre>()
            {
                new Parametre(){Code="001",Nom="Raison Sociale",Type="A" },
                new Parametre(){Code="270",Nom="Type Article",Type="A" },
            };
        }
        private async Task SeedArticle()
        {
            var col = await InitCollection<Article>("article");
           
            var articles = new List<Article>()
            {
                new Article(){Code="XC10<3",Type="TO",Densite=8.0f,Prix=0.75f},
                new Article(){Code="XC10>=3",Type="TO",Densite=8.0f,Prix=0.68f},
                new Article(){Code="215",Type="MO", Designation="Laser Bystronic",TxPrep=70,TxOpe=110,TpPrep=0.0f,TpBase=0.0f},
                new Article(){Code="300",Type="MO", Designation="Pliage",TxPrep=60,TxOpe=80,TpPrep=0.0f,TpBase=0.0f},
                new Article(){Code="ARTICLE TEST",Designation="Designation test",Type="CH"}
                
            };
            await col.InsertManyAsync(articles);
            var art = await ArticleRepo.GetAsync(art =>  art.Code == "ARTICLE TEST" );
            var nome = await ArticleRepo.GetAsync(art => art.Code == "XC10>=3");
            var ope = await ArticleRepo.GetAsync(art => art.Code == "215");
            var ope1 = await ArticleRepo.GetAsync(art => art.Code == "300");
            art.Nomenclatures = new List<Nomenclature>()
            {
                new Nomenclature(){Code=nome.Id,Operation=10,Quantite=0.5f}
            };
            art.Operations = new List<Operation>() { 
                new Operation(){Code=ope.Id,Ordre=10,Nombre=2,TxPrep=ope.TxPrep,TxOpe=ope.TxOpe,TpPrep=ope.TpPrep,TpOpe=ope.TpOpe,BaseOpe=0.5f},
                new Operation(){Code=ope1.Id,Ordre=20,Nombre=5,TxPrep=ope1.TxPrep,TxOpe=ope1.TxOpe,TpPrep=ope1.TpPrep,TpOpe=ope1.TpOpe,BaseOpe=0.003f}
            };
            await ArticleRepo.UpdateAsync(art);
        }

      /*  private async Task SeedOperation()
        {
            var tmpcol = await InitCollection<Operation>("operation");
            List<Operation> operations = new List<Operation>()
            {
                new Operation(){Nom="Laser Bystronic",TxPrep=70,TxOp=110,TpPrep=0.3f,Aide="Voir calcul",TpBase=0.0f },
                new Operation(){Nom="TR500 2",TxPrep=80,TxOp=95,TpPrep=0.5f,Aide="Voir calcul",TpBase=0.0f },
                new Operation(){Nom="Pliage < 200",TxPrep=70,TxOp=75,TpPrep=0.2f,Aide="Nombre de plis",TpBase=0.0056f },
            };
            await tmpcol.InsertManyAsync(operations);
        }*/
    }
}
