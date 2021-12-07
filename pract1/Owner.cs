using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract1
{
    [Serializable]
    public class Owner
    {

        private String ownerName;
        public string OwnerName { get => ownerName; set => ownerName = value; }

        public Owner()
        {
            OwnerName = "";
        }
        public Owner(String name)
        {
            OwnerName = name;
        }
    }
  
}
