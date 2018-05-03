using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    [Serializable]
    
    public class Customer
    {
        public string FirstName { get; set; }
        public string  LastName { get; set; }
        private string email;
        public string EMail
        {
            get { return email; }
            set
            {
                if (CheckEmail(value))
                {
                    this.email = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Die eingegeben Email-Adresse entspricht nicht den Richtlinien!");
                }
            }
        }
        public int Balance { get; set; }
        public DateTime LastChange { get; set; }
        public int ID { get; set; }

        public Customer()
        {

        }
        public Customer(string firstName, string lastName, string email, int balance, int ID )
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = email;
            this.Balance = balance;
            this.LastChange = DateTime.Now;;
            this.ID = ID;
        }

        public void DoATransition(int amount)
        {
            this.Balance += amount;
        }

        public override string ToString()
        {
            string s =this.ID+" "+ this.FirstName + " " + this.LastName + " " + this.EMail + " " + this.Balance;
            return s;
        }
        /// <summary>
        /// checks if Email matches the given standarts
        /// </summary>
        /// <param name="eMail">Email of an Customer</param>
        /// <returns>true if ok, false if incorrect</returns>
        public bool CheckEmail(string eMail)
        {
            // Prüfe, ob der String ein @ enthält bzw. nicht mehr als ein @ und Teile ihn dort in zwei
            if (!eMail.Contains('@') || (eMail.Split('@').Count() - 1) >= 2) return false;
            string[] array = eMail.Split('@');
            //Prüfe, ob der zweite Teil nach dem @ mehr als einen Punkt enthält
            if ((array[1].Split('.').Count() - 1) < 1) return false;
            //Prüfe, ob sich nach dem letzten '.' 2-4 Zeichen mit lediglich Buchstaben befinden
            string[] second = array[1].Split('.');
            if (((second[second.Length - 1].Length < 2) || (second[second.Length - 1].Length > 4)) || (!isAlpha(second[second.Length - 1]))) return false;
            //Prüfe, ob sich nach/vor dem @ oder ganz am Anfang ein Punkt befindet
            if (array[1].Substring(0, 1) == "." || array[0].Substring(array[0].Length - 1, 1) == "." || array[0].Substring(0, 1) == ".") return false;
            //Prüfe, ob der string sonstige ungültigen Zeichen enthält
            if (!isAllowed(eMail) && !isAlpha(eMail)) return false;
            return true;
        }
        /// <summary>
        /// checks if the given text contains only letters
        /// </summary>
        /// <param name="text">text to check</param>
        /// <returns>treu if only letters</returns>
        public static bool isAlpha(string text)
        {
            char[] c = text.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                // a - z
                if (c[i] >= 'a' && c[i] <= 'z')
                    continue;
                // A - Z
                if (c[i] >= 'A' && c[i] <= 'Z')
                    continue;
                return false;
            }
            return true;
        }
        /// <summary>
        /// checks if the given text uses only allowed chars
        /// </summary>
        /// <param name="text">text to check</param>
        /// <returns>true if ok, false if contains forbitten chars</returns>
        public static bool isAllowed(string text)
        {
            char[] c = text.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                // a - z
                if (c[i] >= 'a' && c[i] <= 'z')
                    continue;
                // A - Z
                if (c[i] >= 'A' && c[i] <= 'Z')
                    continue;
                // 0-9
                if (c[i] >= '0' && c[i] <= '9')
                    continue;
                //!#$%&'*+-/=?^_`{|}~_@
                if (c[i] == '.' || c[i] == '!' || c[i] == '#' || c[i] == '$' ||
                    c[i] == '%' || c[i] == '&' || c[i] == '*' || c[i] == '+' ||
                    c[i] == '-' || c[i] == '/' || c[i] == '=' || c[i] == '?' ||
                    c[i] == '^' || c[i] == '_' || c[i] == '`' || c[i] == '{' ||
                    c[i] == '|' || c[i] == '}' || c[i] == '~' || c[i] == '@')
                    continue;
                return false;
            }
            return true;
        }
    }
}
