using System.Runtime.CompilerServices;

namespace LAB_2_C_
{
    internal class Program
    {
        
        static void Main()
        {
            bool isExit = false;
            bool isCorrect = false;
            bool isLog = false;

            User administrator = new Admin("Andrii", "example111@gmail.com","admin");
            User moder = new Moderator("Anton","ex@gmail.com","mod");
            User person1 = new RegularUser("Chiwauwa", "ror@gmail.com","user123");
            User person2 = new RegularUser("Chiwau", "rors@gmail.com","user321");
            User person3 = new RegularUser("Chi", "ro@gmail.com", "user231");

            List<User> users = new List<User>
            {
                administrator,
                person3,
                person2,
                person1,
                moder
            };
            foreach (var user in users)
            {
                user.DisplayInfo();
            }
            while(!isExit) 
            {
                Console.Write("Enter Email: ");
                string inputEmail = Console.ReadLine();
                Console.Write("Enter password: ");
                string inputPassword = Console.ReadLine();
                isLog = true;

                foreach (var user in users)
                {
                    if (user.Authenticate(inputPassword, inputEmail))
                    {
                        Console.WriteLine("Correct authentication");

                        while (isLog)
                        {
                            Console.WriteLine("User menu: \n1.myInfo - see your information;\n2.changePassword - change your password;\n3.ban(only admin) - ban someone;" +
                                "\n4.changePost(only for admin and moderator) - change post;\n5.doPost - write something on comments;\n6.logOut - exit from account;" +
                                "\n7.exit - finish the program;");
                            string inputCommand = Console.ReadLine();
                            if (user is Admin admin)
                            {
                                if (inputCommand != null)
                                {
                                    if (inputCommand == "ban")
                                    {
                                        admin.BlockUser(person1);
                                    }
                                    if (inputCommand == "doPost")
                                    {
                                        admin.PostComment();
                                    }
                                    if (inputCommand == "changePost")
                                    {
                                        admin.ModerateContent();
                                    }
                                    if (inputCommand == "myInfo")
                                    {
                                        admin.DisplayInfo();
                                    }
                                    if (inputCommand == "changePassword")
                                    {
                                        Console.Write("Enter new password:");
                                        string inputNewPass = Console.ReadLine();
                                        admin.SetPassword(inputPassword, inputEmail, inputNewPass);
                                    }
                                    if (inputCommand == "logOut")
                                    {
                                        Console.WriteLine("LogOut complited!");
                                        isLog = false;
                                        break;
                                    }
                                    if (inputCommand == "exit")
                                    {
                                        Console.WriteLine("Exit complited!");
                                        isExit = true;
                                        isLog = false;
                                        break;
                                    }
                                }

                            }
                            else if (user is Moderator moderator)
                            {
                                if (inputCommand == "doPost")
                                {
                                    moderator.PostComment();
                                }
                                if (inputCommand == "changePost")
                                {
                                    moderator.ModerateContent();
                                }
                                if (inputCommand == "myInfo")
                                {
                                    moderator.DisplayInfo();
                                }
                                if (inputCommand == "changePassword")
                                {
                                    string inputNewPass = Console.ReadLine();
                                    moderator.SetPassword(inputPassword, inputEmail, inputNewPass);
                                }
                                if (inputCommand == "logOut")
                                {
                                    Console.WriteLine("LogOut complited!");
                                    isLog = false;
                                    break;
                                }
                                if (inputCommand == "exit")
                                {
                                    isExit = true;
                                    break;
                                }
                            }
                            else if (user is RegularUser regularUser)
                            {
                                if (inputCommand == "doPost")
                                {
                                    regularUser.PostComment();
                                }
                                if (inputCommand == "myInfo")
                                {
                                    regularUser.DisplayInfo();
                                }
                                if (inputCommand == "changePassword")
                                {
                                    string inputNewPass = Console.ReadLine();
                                    regularUser.SetPassword(inputPassword, inputEmail, inputNewPass);
                                }
                                if (inputCommand == "logOut")
                                {
                                    Console.WriteLine("LogOut complited!");
                                    isLog = false;
                                    break;
                                }
                                if (inputCommand == "exit")
                                {
                                    isExit = true;
                                    break;
                                }
                            }


                        }
                        if (!isLog)
                        {
                            break;
                        }

                    }
                    else
                    {
                        Console.WriteLine("invalid data;authentication failed");
                    }
                }
                
            }
        }
    }
}
