using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace Modul1
{
    class Retrieve_all_info
    {
        #region looks nice
        static DirectoryEntry myLdapConnection;
        static DirectorySearcher search;
        static SearchResult result;
        static string userChoice; //Used in menu
        #endregion

        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Console.Clear();
                Console.WriteLine("Choose one");
                Console.WriteLine("");
                Console.WriteLine("[1] Find all information about user");
                Console.WriteLine("");
                Console.WriteLine("[2] Not done yet");
                Console.WriteLine("");
                Console.WriteLine("[3] Not done yet");
                Console.WriteLine("");
                Console.Write("I choose: ");
                userChoice = Console.ReadLine();
                Console.Clear();
                Menu();
                Console.ReadLine();
            }
        }


        static void Menu()
        {
            switch (userChoice)
            {
                case "1":
                    FindAllInfo();
                    break;
                case "2":
                    Console.WriteLine("Not set up yet");
                    break;
                default:
                    Console.WriteLine("Hello world");
                    break;
            }
            return;
        }

        static void FindAllInfo()
        {
            Console.Write("Enter user fx. Jakob JAWA. Waidow: ");
            String username = Console.ReadLine();

            try
            {
                // create LDAP connection object  

                //mLdapConnetion is our connection to AD if there is no result comming out
                ///Check for the right connection string
                myLdapConnection = createDirectoryEntry();

                // create search object which operates on LDAP connection object  
                // and set search object to only find the user specified  

                ///Search filter becomes what we typed at the start                
                search = new DirectorySearcher(myLdapConnection);
                search.Filter = "(cn=" + username + ")";

                // create results objects from search object  
                result = search.FindOne();

                IsFound();
            }


            catch (Exception e)
            {
                Console.WriteLine("Exception caught:\n\n" + e.ToString());
            }


            return;
        }

        static void IsFound()
        {
            ///When result is found 
            if (result != null)
            {
                // user exists, cycle through LDAP fields (cn, telephonenumber etc.)  

                ResultPropertyCollection fields = result.Properties;

                ///Searches for all results that have pur input inside?
                foreach (String ldapField in fields.PropertyNames)
                {
                    // cycle through objects in each field e.g. group membership  
                    // (for many fields there will only be one object such as name)  

                    foreach (Object myCollection in fields[ldapField])
                        Console.WriteLine(String.Format("{0,-20} : {1}",
                                      ldapField, myCollection.ToString()));
                }
            }
            ///If it cant find the user
            ///IT will not say this if connetion string is wrong
            else
            {
                // user does not exist  
                Console.WriteLine("User not found!");
            }

        }
        /// <summary>
        /// Connection for our AD
        /// </summary>
        static DirectoryEntry createDirectoryEntry()
        {
            // create and return new LDAP connection with desired settings  


            ///Some other way we can connect in the future
            DirectoryEntry ldapConnection = new DirectoryEntry("LDAP://192.168.0.2", "Administrator", "Emil1234E", AuthenticationTypes.Secure);


            //DirectoryEntry ldapConnection = new DirectoryEntry("MMDA.DK");
            ///We only need a path if we want to be very specific in what OU we want to look for
            //ldapConnection.Path = "LDAP://OU=Miljømærkering DK,DC=MMDA,DC=dk"; ///We are searching for it in miljømærkering
            ldapConnection.AuthenticationType = AuthenticationTypes.Secure; ///makes secure connetion?

            return ldapConnection;
        }
    }
}