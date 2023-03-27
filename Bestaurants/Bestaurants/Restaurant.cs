using ESRI.ArcGIS.Geodatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestaurants
{
    class Restaurant
    {
        public int objectId { get; set; }
        public string name { get; set; }
        public string website { get; set; }
        public string description{ get; set; }

        public Restaurant(IFeature pFeature)
        {
            var pname = pFeature.get_Value(pFeature.Fields.FindField("NAME")).ToString();
            this.name = pname;
            this.description = pFeature.Value[pFeature.Fields.FindField("DESCRIPTION")].ToString();
            this.website = pFeature.Value[pFeature.Fields.FindField("WEBSITE")].ToString();
            this.objectId = pFeature.OID;
        }

   

        public override string ToString()
        {
            return name;
        }
    }
}
