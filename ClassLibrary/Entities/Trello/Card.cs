using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities.Trello
{
    public class Card : Base
    {
        public static int Number { get; set; } = 1;

        public int TaskNumber { get; set; } = 0;
        
        public bool TaskState { get; set; } = false;

        public List<string> list { get; set; } = new List<string>();
    }
}