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
            // Nel costruttore inizializzo lo username e la password
            Username = _username;
            Password = _password;

            if (ControlloPassword(_password))
            {
                Password = _password; // Se la password rispetta i requisiti viene memorizzata
            }
            else
            {
                throw new ArgumentException("La password non rispetta i requisiti"); // Se la password non rispetta i requisiti da errore
            }
        }
        private bool ControlloPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}\[\]:;<>,.?~\\/-]).{8,}$";
            // Utilizzando un'espressione regolare faccio i controlli sulla password 
            return Regex.IsMatch(password, pattern);
        }
    }
}
