using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace ClassLibrary.Helpers.Checked
{
    public static class InputData
    {
        private static string _patternEmail = @"^([a-z0-9_-]+\.)*[a-z0-9_-]+@[a-z0-9_-]+(\.[a-z0-9_-]+)*\.[a-z]{2,6}$";
        
        /// <summary>
        /// Проверка корректности ввода email
        /// </summary>
        /// <param name="email">Email</param>
        /// <returns>true - если введен верно</returns>
        public static bool CheckEmail(string email)
        {
            if (Regex.IsMatch(email, _patternEmail, RegexOptions.IgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Проверка номер телефона введенного клиентом ввода email
        /// </summary>
        /// <param name="sms_send">SMS отправленная клиенту</param>
        /// <param name="sms_input">SMS введенная клиентом</param>
        /// <returns>true - если sms_send = sms_input</returns>
        public static bool CheckPhone(string sms_send, string sms_input)
        {
            if (sms_send == sms_input)
            {
                return true;                
            }
            else
            {
                return false;
            }
        }
    }
}
