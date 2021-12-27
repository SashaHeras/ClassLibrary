using ClassLibrary.Entities.Auth;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities.Trello
{
    public class Base : ClassLibrary.Entities.Base
    {
        public User Author { get; set; }
        public Group Group { get; set; }

        public string CreatedAt { get; set; } = DateTime.UtcNow.ToString("dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);
    }
}
