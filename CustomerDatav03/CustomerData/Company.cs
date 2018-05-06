using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CustomerData
{
    /// <summary>
    /// Company Class which holds all Customers in an Ductionary (key = ID, Value = Customer)
    /// Also handels Data usage of the Customers (save & load the Data)
    /// </summary>
    public class Company
    {
        private Dictionary<int,Customer> CustomerDict = new Dictionary<int, Customer>();
        private string Password = "YouCantGuessIT";

        // Secret key string
        static string SecretKey = "YouGuess";
        // Byte array key. For encryption and decryption purpose.
        readonly static byte[] Key = Encoding.UTF8.GetBytes(SecretKey);
        // Byte array iv. For encryption and decryption purpose.
        readonly static byte[] IV = Encoding.UTF8.GetBytes(SecretKey);
        // DES Crypto Service Provider.
        static DESCryptoServiceProvider Des;

        static ICryptoTransform Desencrypt;


        /// <summary>
        /// Adds a new Customer
        /// </summary>
        /// <param name="newCustomer">Customer to add</param>
        public void AddCustomer(Customer newCustomer)
        {
            if (!CheckIfIDUnique(newCustomer.ID))
            {
                //System.Windows.Forms.MessageBox.Show("Customer ID '"+ AddCustomer.ID+ "' already used");
                // It would be possible to return an fault, and ask the User to overwritte existing Customer.
                // Due to the fact that it isn't in the requironment and of time issus it is not implemented.

                throw new Exception("Customer ID already used");
            }
            else
            {
                CustomerDict.Add(newCustomer.ID, newCustomer);   
            }
            
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
        public void DoATransition(decimal amount, int CustomerID)
        {
            try
            {
                CustomerDict[CustomerID].DoATransition(amount);
            }
            catch (Exception)
            {
                
                //System.Windows.Forms.MessageBox.Show("Customer Id not found. Booking Canceled.");
                throw new Exception("Customer Id not found. Booking Canceled.");
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
            catch (Exception)
            {
                throw new Exception("Customer Id not found. Change not possible.");

            }
        }
        /// <summary>
        /// Gives back a list of keys for the Customers Dictionary
        /// At this Stage sortin gis only on the first letter
        /// </summary>
        /// <param name="sortby">on which Data should be sorted</param>
        /// <returns>array of keys for Customers Dictionary</returns>
        public int[] GetSortedCustomer(int sortby)
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
        public bool CheckPassword(string password)
        {
            if (this.Password == password)
                return true;
            return false;
        }
        /// <summary>
        /// encrypts and serializes an object
        /// </summary>
        public void StoreData()
        {
            if (CustomerDict.Count == 0)
            {
                //System.Windows.Forms.MessageBox.Show("Empty Database! No Customers found. Storeing data canceled");
                throw new Exception("Empty Database! No Customers found. Storeing data canceled");
            }
            List<Customer> customer = new List<Customer>();
            foreach (var cust in CustomerDict)
            {
                customer.Add(cust.Value);
            }
            // Instances a memory stream object
            Stream serializedStream = new MemoryStream();
            //Instantiate a binary formatter object
            IFormatter formatterEn = new BinaryFormatter();
            //First serialize our data object to memory stream
            formatterEn.Serialize(serializedStream, customer);
            //Reset bach out stream to Position 0. This is due to the serialization process, the stream data positions has reached
            //the last position. This is important because else we migth face the Exception aso 'Binary strea '0' does not contaimn a valid Ninary Header
            serializedStream.Seek(0, SeekOrigin.Begin);

            //Instantiate a file stream object 
            FileStream fsWrite = new FileStream(Environment.CurrentDirectory + "\\CustomerData.txt", FileMode.Create, FileAccess.Write);
            //Create a byte array with the length of our serialized stream
            byte[] byteArray = new byte[serializedStream.Length];
            //Read the serialized stream and store its byte array value to our byteArray variable
            serializedStream.Read(byteArray, 0, byteArray.Length);
            //Instantiate a DES descryptor service provider type object
            Des = new DESCryptoServiceProvider();
            Des.Padding = PaddingMode.PKCS7;
            Des.Mode = CipherMode.CBC;
            Des.Key = Key;
            Des.IV = IV;
            //Create the Encryptor
            Desencrypt = Des.CreateEncryptor();
            //Instantiate a crypto stream object, construct with file stream, encryptor. Note that the mode we use is write.
            CryptoStream cryptStream = new CryptoStream(fsWrite, Desencrypt, CryptoStreamMode.Write);
            //Write the byteArray to our filestream via crypStream
            cryptStream.Write(byteArray, 0, byteArray.Length);
            //flush and close our stream
            cryptStream.FlushFinalBlock();
            cryptStream.Close();
            cryptStream.Flush();
            cryptStream.Close();
            fsWrite.Close();
        }
        /// <summary>
        /// decrypts and deserializes a stored file
        /// </summary>
        public void GetData()
        {
            List<Customer> customer = new List<Customer>();
            try
            {
                //Create a file stream to read the encrypted file back
                using (var fsread = new FileStream(Environment.CurrentDirectory + "\\CustomerData.txt", FileMode.Open, FileAccess.Read))
                {
                    //Create DES crypto service provider object
                    Des = new DESCryptoServiceProvider();
                    Des.Padding = PaddingMode.PKCS7;
                    Des.Mode = CipherMode.CBC;
                    Des.Key = Key;
                    Des.IV = IV;
                    //Create descryptor
                    Desencrypt = Des.CreateDecryptor();
                    //Construct the cryptpstream with filestream that we used to store data that we read from file
                    CryptoStream cryptStream = new CryptoStream(fsread, Desencrypt, CryptoStreamMode.Read);
                    //Create byte array object with length of our filestream
                    byte[] byteArray = new byte[fsread.Length];
                    //Store the byte in cryptStream to our byteArray
                    cryptStream.Read(byteArray, 0, byteArray.Length);
                    //Create a new memory stream
                    MemoryStream memoryStream = new MemoryStream();
                    //Write the byteArray to memory stream
                    memoryStream.Write(byteArray, 0, byteArray.Length);
                    //Create formatter
                    IFormatter formatter = new BinaryFormatter();
                    //Reporsition our memory stream tp position 0
                    memoryStream.Seek(0, SeekOrigin.Begin);
                    //assign the deserialization object to our customer object
                    customer = (List<Customer>)formatter.Deserialize(memoryStream);
                    //Flush and close all stream
                    cryptStream.Flush();
                    cryptStream.Close();
                    fsread.Close();
                    memoryStream.Flush();
                    memoryStream.Close();
                }
            }
            catch (Exception)
            {
                //System.Windows.Forms.MessageBox.Show("No stored Data Found");
                throw new FileNotFoundException("No stored Data Found");
            }
            if (customer.Count==0)
            {
                //System.Windows.Forms.MessageBox.Show("File was empty! No Customer added.");
                throw new ArgumentNullException("File was empty! No Customer added.");
            }

            CustomerDict.Clear();

            foreach (var cust in customer)
            {
                try
                {
                    AddCustomer(cust);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                    
            }

        }
        /// <summary>
        /// Checks if input is unique
        /// </summary>
        /// <param name="customerID">CustomerID (Dictionary key)</param>
        /// <returns>false if already in dictionary, true if free</returns>
        private bool CheckIfIDUnique(int customerID)
        {
            if (CustomerDict.ContainsKey(customerID)) return false;
            return true;
        }
        /// <summary>
        /// checks Email if Email is unique
        /// </summary>
        /// <param name="eMail">Email of a Customer</param>
        /// <returns>false if already in the Dictionary, true if free</returns>
        public bool CheckIfEMailUnique(string eMail)
        {
            foreach (var customer in CustomerDict)
            {
                if (eMail.ToLower() == customer.Value.EMail.ToLower()) return false;
            }
            return true;
        }

    }
}
