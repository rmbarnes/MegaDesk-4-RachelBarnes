using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_RachelBarnes
{
    public class Desk
    {
        public enum SurfaceType
        {
            Oak,
            Laminate,
            Pine,
            Rosewood,
            Veneer
        }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal Drawers { get; set; }
        public SurfaceType SurfaceMaterial { get; set; }
        

    }

}
