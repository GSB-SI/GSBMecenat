using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.DAL
{
    public partial class Partnership
    {
        public string CountryName
        {
            get { return Country.name; }
        }
        public string AssociationName
        {
            get { return Association.name; }
        }
        public string ActionLibel
        {
            get { return Action.libel; }
        }
        public string CountryNameDate
        {
            get { return Country.name + " - "  + date.ToShortDateString(); }
        }
    }
}
