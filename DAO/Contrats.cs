//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAO
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contrats
    {
        internal int NumeroContrat { get; set; }
        internal string Qualification { get; set; }
        internal string Statut { get; set; }
        internal decimal SalaireBrut { get; set; }
        internal System.DateTime DateDebut { get; set; }
        internal Nullable<System.DateTime> DateFinReel { get; set; }
        public int CollaborateurMatricule { internal get; set; }
    
        public virtual Collaborateur Collaborateur { get; set; }
    }
}
