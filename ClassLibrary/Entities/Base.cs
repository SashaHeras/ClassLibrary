using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Entities
{
    /// <summary>
    /// Базовый класс для взаимодействия с данными
    /// </summary>
    public class Base
    {
        public Guid Id { get; set; }

        public String Name { get; set; }

        public String Surname { get; set; }

        public Base()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
