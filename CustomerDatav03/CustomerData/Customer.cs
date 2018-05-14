using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /// <summary>
    /// Customer Class to hold all necessary Data of a Customer, and gives Methodes to check standarts
    /// </summary>
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
                    throw new ArgumentOutOfRangeException("Email Adress not valid!");
                }
            }
        }
        public decimal Balance { get; set; }
        public DateTime LastChange { get; set; }
        public int ID { get; set; }

        /// <summary>
        /// Constructor for a new Customer
        /// </summary>
        /// <param name="firstName">first name of the new Customer</param>
        /// <param name="lastName">last name of the new Customer</param>
        /// <param name="email">email adress of the new Customer</param>
        /// <param name="balance">start ballance of the new Customer</param>
        /// <param name="ID">ID of the new Customer</param>
        public Customer(string firstName, string lastName, string email, decimal balance, int ID)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = email;
            this.Balance = balance;
            this.LastChange = DateTime.Now;
            this.ID = ID;
        }
        /// <summary>
        /// Constructor for a already existing Customer with Lastcahnge
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="email"></param>
        /// <param name="balance"></param>
        /// <param name="ID"></param>
        /// <param name="lastChange"></param>
        public Customer(string firstName, string lastName, string email, decimal balance, int ID, DateTime lastChange)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = email;
            this.Balance = balance;
            this.LastChange = lastChange;
            this.ID = ID;
        }
        /// <summary>
        /// Adds the given amount
        /// </summary>
        /// <param name="amount">amount do add</param>
        public void DoATransition(decimal amount)
        {
            this.Balance += amount;
            this.LastChange = DateTime.Now;
        }
        /// <summary>
        /// overwritten To string method, prepared to show in GUI
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s =this.ID+" | "+ this.FirstName + " | " + this.LastName + " | " + this.EMail + " | " + this.Balance + " | " + LastChange;
            return s;
        }
        /// <summary>
        /// Builds a GUI string so that the Data can be Displayed in Rows.
        /// Fills the String with Blances to show den below each other.
        /// </summary>
        /// <returns>Blanc filled String to Display in GUI</returns>
        public string GetClusteredString()
        {
            /*
            StringBuilder s = new StringBuilder();
            
            const int LENGTID = 10;
            const int LENGTFIRSTNAME = 20;
            const int LENGTLASTNAME = 40;
            const int LENGTEMAIL = 60;
            const int LENGTBALLANCE = 70;
            const int LENGTLASTCHANGE = 90;
            
            s.Append(MakeClusteredStringPart(ID.ToString(), LENGTID));
            s.Append(MakeClusteredStringPart(FirstName, LENGTFIRSTNAME));
            s.Append(MakeClusteredStringPart(LastName, LENGTLASTNAME));
            s.Append(MakeClusteredStringPart(Balance.ToString(), LENGTBALLANCE));
            s.Append(MakeClusteredStringPart(EMail, LENGTEMAIL));
            s.Append(MakeClusteredStringPart(LastChange.ToString(), LENGTLASTCHANGE));
            //s.Append(LastChange);

            return s.ToString();
            */
            // c# build in Method
            string s = String.Format("{0,5} {1,15} {2,15} {3,10} {4,20} {5,20}",
                this.ID, this.FirstName, this.LastName, this.Balance, this.EMail, this.LastChange.ToString());
            return s;
        }
        /// <summary>
        /// checks if the Email string matches the given standarts
        /// </summary>
        /// <param name="eMail">Email of an Customer</param>
        /// <returns>true if ok, false if incorrect</returns>
        public static bool CheckEmail(string eMail)
        {
            //Prüfe ob der String lang genug ist
            if (eMail.Length < 4) return false;
            // Prüfe, ob der String ein @ enthält bzw. nicht mehr als ein @ und Teile ihn dort in zwei
            if (!eMail.Contains('@') || (eMail.Split('@').Count() - 1) >= 2) return false;
            string[] array = eMail.Split('@');
            //Prüfe, ob der zweite Teil nach dem @ mehr als einen Punkt enthält
            if ((array[1].Split('.').Count() - 1) < 1) return false;
            //Prüfe, ob sich nach dem letzten '.' 2-4 Zeichen mit lediglich Buchstaben befinden
            string[] second = array[1].Split('.');
            if (((second[second.Length - 1].Length < 2) || (second[second.Length - 1].Length > 4)) || (!IsAlpha(second[second.Length - 1]))) return false;
            // prüfe auf buchstaben vor @
            if (array[0].Length < 2 || array[1].Length < 2) return false;
            //Prüfe, ob sich nach/vor dem @ oder ganz am Anfang ein Punkt befindet
            if (array[1].Substring(0, 1) == "." || array[0].Substring(array[0].Length - 1, 1) == "." || array[0].Substring(0, 1) == ".") return false;
            //Prüfe, ob der string sonstige ungültigen Zeichen enthält
            if (!IsAllowed(eMail) && !IsAlpha(eMail)) return false;
            return true;
        }
        /// <summary>
        /// checks if the given text contains only letters
        /// </summary>
        /// <param name="text">text to check</param>
        /// <returns>treu if only letters</returns>
        public static bool IsAlpha(string text)
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
        public static bool IsAllowed(string text)
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
