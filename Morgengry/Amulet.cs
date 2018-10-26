using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Morgengry.Program;

namespace Morgengry
{
    public class Amulet
    {
        
        string ItemId { get; set; }
        string Design { get; set; }
         Level Quality { get; set; }
     

        public Amulet(string inItemId, Level inQuality, string inDesign)
        {
            ItemId = inItemId;
            Design = inDesign;
            Quality = inQuality;
        }
        public Amulet(string inItemId, Level inQuality):
        
            this( inItemId,inQuality,"")
        {}
        public Amulet(string inItemId) :
            this(inItemId,Level.medium,"")
        { }

       public override string ToString()
        {

            return "ItemId: "+ItemId +", Quality: "+Quality +", Design: "+Design;
        }
    }

}
