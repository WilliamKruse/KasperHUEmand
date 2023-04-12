using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasperHUEmand.Models
{
    public class Country
    {
        public string DisplayName { get; set; }
        public string Value { get; set; }
        public int Index { get; set; }
        public Country(string displayname, string value, int index)
        {
            this.DisplayName = displayname;
            this.Value = value;
            this.Index = index;
        }
        public override string ToString()
        {
            return this.DisplayName;
        }
    }
}
