using MongoDB.Bson.Serialization.Attributes;
using System;




/// <summary>
/// This file was generated by the yeoman generator "generator-micros"
/// @author: Ambert Jean-Christophe
/// @email: jc.ambert@free.fr
/// @created_on: Wed May 13 2020 12:07:33 GMT+0200 (GMT+02:00)
/// </summary>
namespace WeCotation.domain.Operations.Domain
{

    public partial class Operation
    {
        #region private variables

        #endregion


        #region public properties
        [BsonElement("code")]
        public Guid Code { get; set; }
        [BsonElement("ordre")]
        public int Ordre { get; set; }
        [BsonElement("nombre")]
        public float Nombre { get; set; }
        [BsonElement("txprep")]
        public int TxPrep { get; set; }
        [BsonElement("txope")]
        public int TxOpe { get; set; }
        [BsonElement("tpprep")]
        public float TpPrep { get; set; }
        [BsonElement("tpope")]
        public float TpOpe { get; set; }
        [BsonElement("baseope")]
        public float BaseOpe { get; set; }
        [BsonElement("commentaire")]
        public string Commentaire { get; set; }


        #endregion

        #region Constructeur
        public Operation() : base() { }

        public Operation(Guid code, int ordre, float nombre, int txprep, int txope, float tpprep, float tpope, float baseope, string commentaire)
        : base()
        {
            Code = code;
            Ordre = ordre;
            Nombre = nombre;
            TxPrep = txprep;
            TxOpe = txope;
            TpPrep = tpprep;
            TpOpe = tpope;
            BaseOpe = baseope;
            Commentaire = commentaire;
        }

        #endregion
        #region public functions
        #endregion

    }
}
