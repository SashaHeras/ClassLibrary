using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities.Trello
{
    public class Desk : Base
    {
        public List<Column> Columns { get; set; } = new List<Column>();       
    }
}