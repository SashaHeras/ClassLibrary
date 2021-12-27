using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities.Trello
{
    public class Column : Base
    {       
        public List<Card> Cards { get; set; } = new List<Card>();
    }
}