using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOpg1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Øvelse 1: Login

            //arrays containing usernames and passwords, the index space in usernames corresponds to the index space in password
            string[] userNames = new string[5] { "user1", "user2", "user3", "user4", "user5" };
            string[] passWords = new string[5] { "11", "22", "33", "44", "55" };

            //bool used to check if the user has input a registered username
            bool userPass = false;
            //bytes used to keep track on failed login attempts
            byte failPassword = 0;
            byte failUsername = 0;
            //bool used to keep the login process running
            bool login = true;


            //this while loop will keep the login process running, if the 'login' bool turns false the user have sucessfully logged in
            while (login == true)
            {

                //if user fail to log in too many times, the program will shut down
                if (failPassword == 2 || failUsername == 3)
                {
                    Console.WriteLine("Shutdown Initiated");
                    Console.ReadKey();
                    Environment.Exit(0);
                }

                //program requesting the user to input an username
                Console.WriteLine("Username:");
                string username = Console.ReadLine();

                
                for (int i = 0; i < userNames.Length; i++)
                {
                    //if the 'username' input match a name from the 'usernames' array, it will request a password from user
                    if (username == userNames[i])
                    {
                        Console.WriteLine("password:");
                        string password = Console.ReadLine();
                        userPass = true;

                        //if the password does not match the user will lose an attempt
                        while (password != passWords[i] && failPassword != 2)
                        {
                            Console.WriteLine("Wrong password: Access Denied");
                            failPassword++;
                            Console.WriteLine("password:");
                            password = Console.ReadLine();

                        }
                        if (password == passWords[i])
                        {
                            Console.WriteLine("Access Granted");
                            Console.WriteLine("Welcome");
                            Console.ReadKey();
                            login = false;
                        }
                    }


                }
                if (userPass != true && failUsername != 3)
                {
                    Console.WriteLine("Unknown Username\n");
                    failUsername++;
                    //Console.WriteLine("Username:");
                    //username = Console.ReadLine();

                }
            }

            Console.WriteLine("If you see this line, you have successfully logged in");
            #endregion


        }
    }
}