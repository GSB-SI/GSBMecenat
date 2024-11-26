using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProGestionGSB.DAL
{
    public partial class Association
    {
        public string CountryName
        {
            get { return Country.name; }
        }
        public string MissionLibel
        {
            get { return Mission.libel; }
        }
        
    }
}
