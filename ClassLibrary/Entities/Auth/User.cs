using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using ClassLibrary.Exceptions.InputData;
using ClassLibrary.Helpers.Checked;

namespace ClassLibrary.Entities.Auth
{
    public class User : Base
    {       
        public string CreatedUserAt { get; set; } = DateTime.UtcNow.ToString("dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

        public List<Group> Groups { get; set; } = new List<Group>();

        // Проверяет. может ли пользователь выполнить данную операцию
        public bool checkPolities(List<Group> PoliciesGroup)
        {
            if (PoliciesGroup == null)
            {
                return true;
            }

            foreach (Group group in PoliciesGroup)
            {
                if (Groups.Contains(group)) 
                { 
                    return true; 
                }
            }

            return false;
        }

        [XmlIgnore]
        [JsonIgnore]
        private string _email;

        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                if (InputData.CheckEmail(value))
                {
                    _email = value;
                    return;
                }
                throw new ExceptionInputDataEmail();
            }
        }        

        public bool isEmailVerificated { get; set; } = false;

        public string Phone { get; set; }

        public bool isPhoneVerificated { get; set; } = false;

        public string Password { get; set; }
    }
}
