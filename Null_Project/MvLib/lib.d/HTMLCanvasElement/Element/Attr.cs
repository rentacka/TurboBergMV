using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class Attr
    {
        protected Attr() : base()
        {

        }
        public string name;
        public Element ownerElement;
        public string prefix;
        public bool specified;
        public string value;
    }
