 using System;

 namespace SuperApp
 {

    class Program
    {
        public static void Main()
        {
            firstScreen();
            appNavigator();
        }

        //The screen that will be displayed to the user when start the app, also this funciton is defining the window size, title, colors etc
        public static void firstScreen()
        {
            //Window characteristics
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.White;
           
            //Console.WindowWidth = Console.LargestWindowWidth;
            //Console.WindowHeight = Console.LargestWindowHeight;
            Console.Title = "Super App";

            Console.Write("Super App\nAn app that has many others on it, type 'apps' to get the apps list or 'commands' / 'help' to get the command list\n\n\n\n");
            
        }

        //Menu to navigate throughout the app
        public static void appNavigator()
        {   
            
            //var to store the commands
            string appNavigatorController;

         

            //var to check if user has executed or not a commands in the app list NOT-IMPLEMENTED
            //bool navigatorChecker = true;

            Console.WriteLine();
            Console.Write(">>>  ");
            appNavigatorController = Console.ReadLine();
            Console.WriteLine();

            switch(appNavigatorController)
            {

                case "apps":
                appsList();
                break;

            //if user hit enter without any commands the appNavigator will be recalled to promt for a command
                case "":
                appNavigator();
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
                
                
                
                //case "":
                //break;
                
                case "commands":
                commandsList();
                break;
                
                case "help":
                commandsList();
                break;

                //this two cases are going to assing the value 'close' or 'exit' to the appNavigatorController var, so the program will know on the next if-else statement if the user is or isnot willing to close the app
                case "exit":
                break;

                case "close":
                break;

                // exit the game without a promt or user willingness verification
                case "kill":
                Environment.Exit(0);
                break;

                //On the default case Im setting up the method to call back the switch since user was unable to run a app/command
                default:

                Console.WriteLine("Please type any of the apps names or command availables on the next listing\n");
               
                appsList();
                commandsList();

               //appNavigator();
                /*navigatorChecker = false;
               
                if (navigatorChecker == false)
                    {
                        appNavigator();
                    }*/

                break;
            }

            //this method evalute whenever or not the user want to close the app, if not will recall the menu / app navigator to stay the app
            if (appNavigatorController == "exit" || appNavigatorController == "close")
            {
                commandCloseExitApp();
            }
            else
            {
                appNavigator();
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

            Console.Write("Mathematical operator (it can be + - * or /): ");
            //calculatorOperator = Convert.ToChar(Console.Read());
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

                default:
                Console.Write("Please choose a correct operator (it can be + - * or /): ");
                break;
            }

            Console.Write("The result is: " + calculationResult);
            Console.Write("\n\n\n");


        }

        public static void appMadLibGame()
        {
            //Testing
            int [] calc = {20, 80, 100};
            Console.Write((calc[0] + calc[1]) * calc[2]);
        }

        //App to list things, like a stickynote
        public static void appObjectsLister() //TO-DO : the array is getting back to its original value removing the user input as soon as the method is recalled or the user jump to another app
        {
            //var to hold 10 objects to list
            string []objectsLister = new string[10];

            //var to navigate troughout this objects app
            string objectsListerNavigatorController;

            //var to specifi on what slot store the objects
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
































        //Close the app/terminal (user has to execute the exit/close command from the appNavigator)
        public static void commandCloseExitApp()
        {   

            //var to confirm user willingess to close app
            string confirmcommandCloseExitApp;

            //if statement to make sure user want to close or not the app5
            Console.Write("Are you sure you want to close this app? ");
            confirmcommandCloseExitApp = Console.ReadLine();
            Console.Write("\n\n");

            if (confirmcommandCloseExitApp == "yes" || confirmcommandCloseExitApp == "YES" || confirmcommandCloseExitApp == "Yes" || confirmcommandCloseExitApp == "y" || confirmcommandCloseExitApp == "Y")
            {
                Console.Write("Press any key to exit");
                Environment.Exit(0);
            }

            if (confirmcommandCloseExitApp == "no" || confirmcommandCloseExitApp == "NO" || confirmcommandCloseExitApp == "No" || confirmcommandCloseExitApp == "n" || confirmcommandCloseExitApp == "N")
            {
                appNavigator();
            }

            if (confirmcommandCloseExitApp != "yes" && confirmcommandCloseExitApp != "YES" && confirmcommandCloseExitApp != "Yes" && confirmcommandCloseExitApp != "y" && confirmcommandCloseExitApp != "Y" && confirmcommandCloseExitApp != "no" && confirmcommandCloseExitApp != "NO" && confirmcommandCloseExitApp != "No" && confirmcommandCloseExitApp != "n" && confirmcommandCloseExitApp != "N")
            {
             Console.Write("You can type 'yes' or 'no' / 'y' n' so... ");
             commandCloseExitApp();
            }

        }


    }
 }