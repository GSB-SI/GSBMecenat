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
    
    public partial class User
    {
        public int id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public int role_id { get; set; }
    
        public virtual Role Role { get; set; }
    }
}
