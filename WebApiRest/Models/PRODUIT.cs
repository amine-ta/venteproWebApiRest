//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApiRest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PRODUIT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PRODUIT()
        {
            this.LIGNE_COMMANDE = new HashSet<LIGNE_COMMANDE>();
        }
    
        public decimal IDPRODUIT { get; set; }
        public Nullable<decimal> IDMARQUE { get; set; }
        public string NOMPRODUIT { get; set; }
        public string DESCRIPTION_FR { get; set; }
        public Nullable<decimal> PRIX { get; set; }
        public string FORMATPRO { get; set; }
        public Nullable<decimal> QUANTITEENSTOCK { get; set; }
        public string IMAGE { get; set; }
        public Nullable<decimal> IDCATEGORIE { get; set; }
    
        public virtual CATEGORIE CATEGORIE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LIGNE_COMMANDE> LIGNE_COMMANDE { get; set; }
        public virtual MARQUE MARQUE { get; set; }
    }
}