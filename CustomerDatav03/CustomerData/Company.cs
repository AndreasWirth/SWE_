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

       

        public void AddCustomer(Customer newCustomer)
        {
            CustomerDict.Add(newCustomer.ID,newCustomer);
        }

        public Dictionary<int, Customer> GetCustomers()
        {
            return CustomerDict;        
        }

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
        

    }
}
