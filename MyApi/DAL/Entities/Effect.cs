using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Effect
    {
        long Id { get; set; }
        long ImageId { get; set; }
        Image Image { get; set; }
        long Radius { get; set; }
        String Name { get; set; }

    }
}
