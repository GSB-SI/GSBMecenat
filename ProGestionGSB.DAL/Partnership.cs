//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProGestionGSB.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partnership
    {
        public int id { get; set; }
        public System.DateTime date { get; set; }
        public Nullable<double> forecastBudget { get; set; }
        public Nullable<double> realBudget { get; set; }
        public int action_id { get; set; }
        public int association_id { get; set; }
        public int country_id { get; set; }
    
        public virtual Action Action { get; set; }
        public virtual Association Association { get; set; }
        public virtual Country Country { get; set; }
    }
}
