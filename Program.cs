 using System;

 namespace SuperApp
 {

    class Program
    {
        public static void Main()
        {   
            ScreenSettings();

            WelcomeScreen();
    
            AppNavigator();
        }

        //this method is defining the window size, title, colors and others settings
        public static void ScreenSettings()
        {
            //Window characteristics
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
           
            //Console.WindowWidth = Console.LargestWindowWidth;
            //Console.WindowHeight = Console.LargestWindowHeight;
            Console.Title = "Super App";
        }


        //This method actually is unnecessary, Im just making it to do some methods-arguments calls
        public static void WelcomeScreen()
        {
            //vars to take answer the command from the user
            string welcomScreenNavigatorController;

            

            Console.WriteLine("Welcome to SuperApp OS (SAOS)\n\n");

            Console.WriteLine("\n\nType 'sing in' / 'si' for sing in or 'sing up' / 'su' to sing up");
            Console.Write(">>>  ");
            welcomScreenNavigatorController = Console.ReadLine();
            Console.WriteLine();

            if (welcomScreenNavigatorController == "sing in" || welcomScreenNavigatorController == "Sing in" || welcomScreenNavigatorController == "Sing In" || welcomScreenNavigatorController == "SING IN" || welcomScreenNavigatorController == "si" || welcomScreenNavigatorController == "SI")
                {
                    SingInProcess();
                }

            if (welcomScreenNavigatorController == "sing up" || welcomScreenNavigatorController == "Sing up" || welcomScreenNavigatorController == "Sing Up" || welcomScreenNavigatorController == "SING UP" || welcomScreenNavigatorController == "su" || welcomScreenNavigatorController == "SU")
                {
                    SingUpProcess();
                }
            //else
            //   {Console.WriteLine("Wrong command, try with 'sing in' or 'sing up'");}

        }

        public static void SingInProcess()
        {
            //vars to promt user for credentials
            string singInUsername, singInPassword;

            //vars holding already saved credentials to compare (receiving credentials from SingUpProcess() method)
            string[] userSavedCredentialReceiver = SingUpProcess(); // possible cause of the bug / the command 'sing in' is calling the process/method sing up instead of sing in
            string userSavedUsername = userSavedCredentialReceiver[0], userSavedPassword = userSavedCredentialReceiver[1];

            Console.WriteLine("Sing In\n");

            Console.Write("Username: ");
            singInUsername = Console.ReadLine();
            
            Console.Write("Password: ");
            singInPassword = Console.ReadLine();

            if (singInUsername == userSavedUsername)
                {
                    if (singInPassword == userSavedPassword)
                    {
                        Console.WriteLine("Welcome back " + userSavedUsername);
                    }

                }

          
           
        }

        public static string[]  SingUpProcess()
        {
           
            //vars to save the user credentials
            string savedUsername, savedPassword;

            Console.WriteLine("Sing Up\n\n");

            Console.Write("New username: ");
            savedUsername = Console.ReadLine();
            
            Console.Write("New password: ");
            savedPassword = Console.ReadLine();

            Console.WriteLine("\n\n");

            if (savedUsername.Any())
                {
                    if (savedPassword.Any())
                        {
                            Console.WriteLine("User successfully created, returning back to the app...\n\n\n");
                            Main();
                        }
                    else
                        {
                            Console.WriteLine("You need to create a password in order to sing in");
                        }
                }
            else 
                {
                    Console.WriteLine("You need a username in order to sing in");
                }
            
            string[] userSavedCredentialTransporter = {savedUsername, savedPassword};
            return userSavedCredentialTransporter;
        }

        public static string[] SingInInformationTransferer(string userInputUsername, string userInputPasword)
        {
            //var to transfer the user input value to the next method
            string[] userCredentials = {userInputUsername, userInputPasword};

            return userCredentials;
            //userCredentials[0], userCredentials[1];  
        }

        //Menu to navigate throughout the app
        public static void AppNavigator()
        {   
            
            //var to store the commands
            string AppNavigatorController;

            Console.WriteLine();
            Console.Write(">>>  ");
            AppNavigatorController = Console.ReadLine();
            Console.WriteLine();

            switch(AppNavigatorController)
            {

                case "apps":
                appsList();
                break;

                //if user hit enter without any commands the AppNavigator will be recalled to promt for a command
                case "":
                AppNavigator();
                break;

                case "calculator":
                appCalculator();
                break;
                
                case "calc":
                appCalculator();
                break;
                
                case "objl":
                appObjectsLister();
                break;

                case "objects lister":
                appObjectsLister();
                break;
                
                case "mabl":
                appMadLibGame();
                break;
                
                //case "":
                //break;
                
                case "commands":
                commandsList();
                break;
                
                case "help":
                commandsList();
                break;

                //this two cases are going to assing the value 'close' or 'exit' to the AppNavigatorController var, so the program will know on the next if-else statement if the user is or isnot willing to close the app
                //TO-DO take a look into this, looks like this whole block of code (if-statement and exit/close  cases) is easier just call commandCloseExitApp method whenener the user execute the exit/close command, the commandCloseExitApp method is capable to handle the user's willingness to close or not the app
                case "exit":
                break;

                case "close":
                break;

                // exit the game without a promt or user willingness verification, like just killing the game
                case "kill":
                Environment.Exit(0);
                break;

                //On the default case Im setting up the method to call back the switch since user was unable to run a app/command
                default: //TO-DO recall the AppNavigator method here so if user commans doesnt match any of the options available the program has to let the user now the options and also prompt for a input

                Console.WriteLine("Please type any of the apps names or command availables on the next listing\n");
               
                appsList();
                commandsList();
                break;
            }

            //this method evalute whenever or not the user want to close the app, if not will recall the menu / app navigator to stay the app
            //TO-DO (refering to the cases exit/close from above) take a look into this, looks like this whole block of code (if-statement and exit/close  cases) is easier just call commandCloseExitApp method whenener the user execute the exit/close command, the commandCloseExitApp method is capable to handle the user's willingness to close or not the app
            if (AppNavigatorController == "exit" || AppNavigatorController == "close")
            {
                commandCloseExitApp();
            }
            else
            {
                AppNavigator();
            }
            
        }

        //command to show up all the apps available
        public static void appsList()
        {
            Console.WriteLine("Apps");
            Console.WriteLine("================================================================");
            Console.WriteLine("Calculator     |  calc  | A calculator");
            Console.WriteLine("Mad Lib        |  mabl  | A madlib text game");
            Console.WriteLine("Object Lister  |  objl  | Add objects to a list");
            Console.WriteLine("Name Analyzer  |  name  | Analyze components in given name");
            Console.WriteLine("");

        }

        //command to show up all the commands available
        public static void commandsList()
        {

            Console.WriteLine("Commands");
            Console.WriteLine("================================================================");
            Console.WriteLine("apps             |  show up all the apps available");
            Console.WriteLine("commands / help  |  show up all the commands available");
            Console.WriteLine("exit / close     |  close the terminal/app");
            Console.WriteLine("kill             |  close the terminal/app immediately");
            Console.WriteLine("");

        }

        public static void appCalculator()
        {
            //vars for operate numbers
            double firstNumber;
            double secondNumber;
            char calculatorOperator;
            double calculationResult = 0.0;

            Console.Write("Calculator\n\n");

            Console.Write("First number to operate: ");
            firstNumber = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine();

            Console.Write("Mathematical operator (it can be + - * / or %): ");
            calculatorOperator = Convert.ToChar(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Second number to operate: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());

            //doing the math
            switch(calculatorOperator)
            {
                
                case '+':
                calculationResult = (firstNumber + secondNumber);
                break;
                
                case '-':
                calculationResult = (firstNumber - secondNumber);
                break;
                
                case '*':
                calculationResult = (firstNumber * secondNumber);
                break;

                case '/':
                calculationResult = (firstNumber / secondNumber);
                break;

                case '%':
                calculationResult = CalculatorPercentage(firstNumber, secondNumber);
                break;

                default:
                Console.Write("Please choose a correct operator (it can be + - * / or %): ");
                break;
            }

            Console.Write("The result is: " + calculationResult);
            Console.Write("\n\n\n");


        }

        //method to calculate the percent of given numbers then pass the value back to the calculator method (again, this whole thing is completly
        //unnencessary) so Im working in this way just to use the argument staments and those things
        public static double CalculatorPercentage(double percentageNumberToCalculate, double percentageTotalNumberToCalculate)
        {
            double percentageCalculationResult = (percentageNumberToCalculate * 0.01) * percentageTotalNumberToCalculate;
            
           return percentageCalculationResult; //TO-DO challenge: convert this double method to a array one
        }

        //TO-DO finish this word-minigame
        public static void appMadLibGame()
        {
            //Testing
            int [] calc = {20, 80, 100};
            Console.Write((calc[0] + calc[1]) * calc[2]);
        }

        //App to list things, like a stickynote
        public static void appObjectsLister() //TO-DO : the array is getting back to its original value removing the user input as soon as the method is recalled or the user jump to another app, fix this by storing the value definitively
        {
            //var to hold 10 objects to list
            string []objectsLister = new string[10];

            //var to navigate troughout this objects app
            string objectsListerNavigatorController;

            //var to specify on what slot store the objects
            int objectSlotChecker;

            Console.WriteLine("Objects Lister, an app to write down up to 10 objects.\nType 'view' to watch the list or 'add' to add new objects in it\n");

            Console.WriteLine();
            Console.Write(">>>  ");
            objectsListerNavigatorController = Console.ReadLine();
            Console.WriteLine();

            if (objectsListerNavigatorController == "add" || objectsListerNavigatorController ==  "Add" || objectsListerNavigatorController == "ADD")
            {
                Console.Write("On which slot (1-10): ");
                objectSlotChecker = Convert.ToInt32(Console.ReadLine());

                switch (objectSlotChecker)
                {
                    case 1:
                    Console.Write("Enter the object name (Up to 15 characters): ");
                    objectsLister[0] = Console.ReadLine();
                    break;

                    case 2:
                    Console.Write("Enter the object name (Up to 15 characters): ");
                    objectsLister[1] = Console.ReadLine();
                    break;

                    case 3:
                    Console.Write("Enter the object name (Up to 15 characters): ");
                    objectsLister[2] = Console.ReadLine();
                    break;

                    case 4:
                    Console.Write("Enter the object name (Up to 15 characters): ");
                    objectsLister[3] = Console.ReadLine();
                    break;

                    case 5:
                    Console.Write("Enter the object name (Up to 15 characters): ");
                    objectsLister[4] = Console.ReadLine();
                    break;

                    case 6:
                    Console.Write("Enter the object name (Up to 15 characters): ");
                    objectsLister[5] = Console.ReadLine();
                    break;

                    case 7:
                    Console.Write("Enter the object name (Up to 15 characters): ");
                    objectsLister[6] = Console.ReadLine();
                    break;

                    case 8:
                    Console.Write("Enter the object name (Up to 15 characters): ");
                    objectsLister[7] = Console.ReadLine();
                    break;

                    case 9:
                    Console.Write("Enter the object name (Up to 15 characters): ");
                    objectsLister[8] = Console.ReadLine();
                    break;

                    case 10:
                    Console.Write("Enter the object name (Up to 15 characters): ");
                    objectsLister[9] = Console.ReadLine();
                    break;

                    default:
                    Console.Write("Choose a slot from 1 - 10\n\n");
                    appObjectsLister();
                    break;

                }

               
            }

            if (objectsListerNavigatorController == "view" || objectsListerNavigatorController ==  "View" || objectsListerNavigatorController == "VIEW")
            { 
                Console.WriteLine("Objects");
                Console.WriteLine("================================================================");
                Console.WriteLine(" 1 | " + objectsLister[0] +"    ");
                Console.WriteLine(" 2 | " + objectsLister[1] +"    ");
                Console.WriteLine(" 3 | " + objectsLister[2] +"    ");
                Console.WriteLine(" 4 | " + objectsLister[3] +"    ");
                Console.WriteLine(" 5 | " + objectsLister[4] +"    ");
                Console.WriteLine(" 6 | " + objectsLister[5] +"    ");
                Console.WriteLine(" 7 | " + objectsLister[6] +"    ");
                Console.WriteLine(" 8 | " + objectsLister[7] +"    ");
                Console.WriteLine(" 9 | " + objectsLister[8] +"    ");
                Console.WriteLine("10 | " + objectsLister[9] +"     \n");
                
            }

            if (objectsListerNavigatorController != "view" && objectsListerNavigatorController !=  "View" && objectsListerNavigatorController != "VIEW" && objectsListerNavigatorController != "add" && objectsListerNavigatorController !=  "Add" && objectsListerNavigatorController != "ADD")
            {
                Console.Write("wrong command, try again");
                appObjectsLister();
            }

        }

        public static int gunsCriticalRate(int criticalRate)
        {


            
            return criticalRate;
        }































        //Close the app/terminal (user has to execute the exit/close command from the AppNavigator)
        public static void commandCloseExitApp()
        {   

            //var to confirm user willingess to close app
            string confirmCommandCloseExitApp;

            //if-statement to make sure user want to close or not the app
            Console.Write("Are you sure you want to close this app? ");
            confirmCommandCloseExitApp = Console.ReadLine();
            Console.Write("\n\n");

            if (confirmCommandCloseExitApp == "yes" || confirmCommandCloseExitApp == "YES" || confirmCommandCloseExitApp == "Yes" || confirmCommandCloseExitApp == "y" || confirmCommandCloseExitApp == "Y")
            {
                Console.Write("Press any key to exit");
                Environment.Exit(0);
            }

            if (confirmCommandCloseExitApp == "no" || confirmCommandCloseExitApp == "NO" || confirmCommandCloseExitApp == "No" || confirmCommandCloseExitApp == "n" || confirmCommandCloseExitApp == "N")
            {
                AppNavigator();
            }

            if (confirmCommandCloseExitApp != "yes" && confirmCommandCloseExitApp != "YES" && confirmCommandCloseExitApp != "Yes" && confirmCommandCloseExitApp != "y" && confirmCommandCloseExitApp != "Y" && confirmCommandCloseExitApp != "no" && confirmCommandCloseExitApp != "NO" && confirmCommandCloseExitApp != "No" && confirmCommandCloseExitApp != "n" && confirmCommandCloseExitApp != "N")
            {
             Console.Write("You can type 'yes' or 'no' / 'y' n' so... ");
             commandCloseExitApp();
            }

        }


    }
 }