using System;
using System.Text.RegularExpressions;

namespace E_Commerce_Volterra
{
    public class Utente
    {
        public string Username { get; set; }
        private string Password { get; set; }

        public Utente(string _username, string _password)
        {
            Username = _username;
            Password = _password;

            if (ControlloPassword(_password))
            {
                Password = _password;
            }
            else
            {
                throw new ArgumentException("La password non rispetta i requisiti");
            }
        }
        private bool ControlloPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]).{8,}$";
            return Regex.IsMatch(password, pattern);
        }
    }
}
