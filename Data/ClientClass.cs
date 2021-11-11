using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOOPolomkaISP9_3.Data
{
    public partial class Client
    {
        public int CountVisit
        {
            get
            {
                return ClientService.Count();
            }
        }

        public DateTime? LastVisit
        {
            get
            {

                return ClientService.LastOrDefault()?.StartTime;
            }
        }

        public List<Tag> Tags
        {
            get
            {
                return Tag.ToList();
            }
        }

    }
}
