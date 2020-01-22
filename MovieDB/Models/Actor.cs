using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDB
{
    public partial class Actor
    {
        public string full_name
        {
            get
            {
                return String.Format("{0} {1}", this.first_name, this.last_name);
            }
        }
    }
}
