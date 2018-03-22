using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Company
    {
        private Dictionary<int,Customer> CustomerDict = new Dictionary<int, Customer>();
        private string password = "YouCantGuessIT";

       
        /// <summary>
        /// Adds a new Customer
        /// </summary>
        /// <param name="newCustomer">Customer to add</param>
        public void AddCustomer(Customer newCustomer)
        {
            if (!checkIfIDUnique(newCustomer.ID))
            {
                throw new IndexOutOfRangeException("ID already used");
            }
            CustomerDict.Add(newCustomer.ID,newCustomer);
        }
        /// <summary>
        /// Getting the Dictionry off all Customers
        /// </summary>
        /// <returns>returns the Customer Dictionary</returns>
        public Dictionary<int, Customer> GetCustomers()
        {
            return CustomerDict;        
        }
        /// <summary>
        /// Do a Transition/ Booking for a Customer
        /// </summary>
        /// <param name="amount">Amount of money to change</param>
        /// <param name="CustomerID">ID(Dictionary key) for the Customer</param>
        public void DoATransition(int amount, int CustomerID)
        {
            try
            {
                CustomerDict[CustomerID].DoATransition(amount);
            }
            catch (Exception e)
            {
                Console.WriteLine("Customer Id not found. Booking Canceled.");
                System.Windows.Forms.MessageBox.Show("Customer Id not found. Booking Canceled.");

            }
            
        }
        /// <summary>
        /// Changing a Customer (Fully overwritting the entry in the Dictionary)
        /// </summary>
        /// <param name="CustomerID">key for the Ductionary</param>
        /// <param name="changedCustomer">Full Customer</param>
        public void ChangeCustomer(int CustomerID,Customer changedCustomer)
        {
            try
            {
                CustomerDict[CustomerID] = changedCustomer;
            }
            catch (Exception e)
            {
                //Console.WriteLine("Customer Id not found.");
                System.Windows.Forms.MessageBox.Show("Customer Id not found. Change not possible.");
                throw;

            }
        }
        /// <summary>
        /// Gives back a list of keys for the Customers Dictionary
        /// At this Stage sortin gis only on the first letter
        /// </summary>
        /// <param name="sortby">on which Data should be sorted</param>
        /// <returns>array of keys for Customers Dictionary</returns>
        public int[] GetSortedCustomer(int sortby)
        //public int[] GetIndexArray(int sortby)
        {
            int length = CustomerDict.Count;
            int[] indizes = new int[length];
            int[] chars = new int[length];
            if (length >0)
            {
                int k = 0;
                switch (sortby)
                {
                    case 1:
                        foreach (var custom in CustomerDict)   // create array of first char (int representation) of last name 
                        {
                            chars[k] = custom.Value.LastName.ToLower()[0] - 97;
                            k++;
                        }
                        break;
                    default:
                        foreach (var custom in CustomerDict)
                        {
                            chars[k] = custom.Value.ID;
                            k++;
                        }
                        break;
                }
                int i = 0;
                foreach (var element in CustomerDict)      // iterate over customers
                {
                    int currentChar = element.Value.LastName.ToLower()[0] - 97;
                    int count = 0;
                    for (int j = 0; j < i; j++)     // iterate over already set indizes
                    {
                        if (chars[j] > currentChar) indizes[j]++;   // count all higher chars one up
                        else count++;                               // count current couter one up, for each lower char
                    }
                    indizes[i] = count;     // set current index to counter value
                    i++;
                }
                //TODO: erstelle dictionary zur ausgabe
                int[] keyarray = new int[indizes.Length];
                int count2 = 0;
                foreach (var customer in CustomerDict)
                {
                    int place = indizes[count2];   
                    keyarray[place]= customer.Key;
                    count2++;
                }
                return keyarray;
            }
            return new int[0];
        }
        /// <summary>
        /// Checks Passwort is correct
        /// </summary>
        /// <param name="password"></param>
        /// <returns>True if correct, fasle if not</returns>
        private bool checkPassword(string password)
        {
            if (this.password == password)
                return true;
            return false;
        }

        public void StoreDataTOcsv()
        {
            //TODO 
            //Methode konnte zeitlich noch nicht erstellt werden.
            //Soll Daten verschlüsselt in eine csv Datei Speichern.
        }
        public void GetDataFromcsv()
        {
            //TODO 
            //Methode konnte zeitlich noch nicht erstellt werden.
            //Soll die Verschlüsselten Daten aus csv Datei nehmen und diese in Klasse laden.
        }
        /// <summary>
        /// Checks if input is unique
        /// </summary>
        /// <param name="customerID">CustomerID (Dictionary key)</param>
        /// <returns>false if already in dictionary, true if free</returns>
        private bool checkIfIDUnique(int customerID)
        {
            if (CustomerDict.ContainsKey(customerID)) return false;
            return true;
        }
        /// <summary>
        /// checks Email if Email is unique
        /// </summary>
        /// <param name="eMail">Email of a Customer</param>
        /// <returns>false if already in the Dictionary, true if free</returns>
        public bool checkIfEMailUnique(string eMail)
        {
            foreach (var customer in CustomerDict)
            {
                if (eMail == customer.Value.EMail) return false;
            }
            return true;
        }

    }
}
