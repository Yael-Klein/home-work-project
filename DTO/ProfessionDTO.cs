using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProfessionDTO
    {
        public int professionId { get; set; }
        public string professionDescription { get; set; }
        public ProfessionDTO()
        {

        }
        public ProfessionDTO(int professionId, string professionDescription)
        {
            this.professionId = professionId;
            this.professionDescription = professionDescription;
        }
    }
}
