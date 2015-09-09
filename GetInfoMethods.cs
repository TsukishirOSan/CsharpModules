using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleThree
{

    /**
    -Using the above partial code sample, complete the method for getting student data.
    -Create a method to get information for a teacher, a course, a program, and a degree using a similar method as above.
    -Create methods to print the information to the screen for each object such as static void PrintStudentDetails(...).
    -From within Main(), call each of the methods to prompt for input from a user of your application.
    -Just enter enough information to show you understand how to use methods.  (At least three attributes each).
    -Assign the values that are input, to the proper variables.
    or DateTime to determine ways to check if a valid date is entered
     */


    public class GetInfoMethods
    {

        public static void Main(String[] args)
        {
            Console.WriteLine("Press a key to start\n");
            GetStudentInfo();
            GetTeacherInfo();
            GetUnivProgramInfo();
            GetDegreeInfo();

            TryValidBdayFailShowExceptionMessage();
            Console.ReadKey();
        }

        #region Dedicated to parsing and handling user's input properly
        // Is called in Get info method asking for a string info, returns a string
        private static string ConsoleInfoInput(string InfoInput)
        {
            Console.Write(InfoInput);
            string UserInput = Console.ReadLine();
            

            return UserInput;
        }

        // Is called in Get info method asking for a DateTime info, gets a string returns a checked and valid DateTime
        private static DateTime AskDateTimeUserInput(string InfoInput)
        {
            Console.Write(InfoInput);
            // initialize DatetimeInput
            DateTime DatetimeInput = default(DateTime);
            // Check for nullity or invalid input for the DateTime type until the input is valid aka is not defaul(DateTime) 
            do{
                string DatetimeUserInput = Console.ReadLine();
                try
                {
                    DatetimeInput = DateTime.Parse(DatetimeUserInput);
                }
                catch(ArgumentNullException ae)
                {
                    Console.WriteLine("{0}You need to enter a date{0}", Environment.NewLine);
                }
                catch(FormatException fe)
                {
                    Console.WriteLine("{0}You need to enter a valid date{0}", Environment.NewLine);
                }
            } while(DatetimeInput == default(DateTime));

            // Checking if the date is logically valid
            IsPersonBdayValid(DatetimeInput);
            
            return DatetimeInput;
        }

        // Is called in Get info method asking for an int info, gets a string returns an int
        private static int AskUserInt32Input(string UserInput)
        {
            Console.Write(UserInput);
            string UserInputInt32 = Console.ReadLine();
            int UserInfoInt32 = Int32.Parse(UserInputInt32);

            return UserInfoInt32;
        }
        #endregion
        
        #region Dedicated to Handling DateTime related Exception
        // handles bad user's birthday input by throwing an exception
        private static bool IsPersonBdayValid(DateTime PersonBdayToCheck)
        {

            //throw new NotImplementedException();  // NEED TO WORK ON THAT, ELSE RENDER IT WITH THIS LINE ONLY UNCOMMENTED
            DateTime now = DateTime.Now;
            int year = DateTime.Now.Year;
            int inputYear = PersonBdayToCheck.Year;
            
            if ((inputYear > year || year - inputYear < 12))
            {
                return false;
            }
            return true;
        }

        // try method catching a bad birthday input and output a message to user. 
        private static void TryValidBdayFailShowExceptionMessage()
        {
            try
            {
                bool isBdayValid = IsPersonBdayValid(new DateTime(1982, 03, 06));
            }
            //catches the invalid input if any and prompts a message to explicit that the input was invalid
            catch (NotImplementedException bdayFail)
            {
                Console.WriteLine("{0}An exception has been thrown due to a bad birthdate input{0}" +
                    "{1}", Environment.NewLine, bdayFail.Message);
            }
        }
        #endregion
        #region Dedicated to Student Info
        // Is called in Main. Student Getter method calling ConsoleInfoInput where the user enters 
        // the asked data and assign it to the proper arguments.
        // Ouputs the infos given by the user.
        private static void GetStudentInfo()
        {
            string UserInput = "Enter the student's first name: ";
            string s_First = ConsoleInfoInput(UserInput);
            Console.WriteLine();
            UserInput = "\nEnter the student's last name: ";
            string s_Last = ConsoleInfoInput(UserInput);
            Console.WriteLine();
            UserInput = "Enter the student's birthdate (MM/DD/YYYY): ";
            DateTime s_Bday = AskDateTimeUserInput(UserInput);
            try 
            {
                if()
            }
            Console.WriteLine();
            OutputStudentInfo(s_First, s_Last, s_Bday);
        }
        #endregion
        
        // Outputs the infos the user entered on Student. {x} are indexes related to the arguments passed in the Console object.
        static void OutputStudentInfo(string s_First, string s_Last, DateTime s_Bday)
        {
            Console.WriteLine("{0}Student {1} {2} was born the {3:MM/dd/yyyy}{0}",
                Environment.NewLine, s_First, s_Last, s_Bday);
            Console.WriteLine();
        }

        #region Dedicated to Teacher
        // Is called in Main.Professor Getter method calling ConsoleInfoInput where the user enters 
        // the asked data and assign it to the proper arguments.
        // Ouputs the infos given by the user.
        private static void GetTeacherInfo()
        {
            string UserInput = "Enter the Professor's first name: ";
            string t_First = ConsoleInfoInput(UserInput);
            Console.WriteLine();
            UserInput = "Enter the Professor's last name: ";
            string t_Last = ConsoleInfoInput(UserInput);
            Console.WriteLine();
            UserInput = "Enter the Professor's birthdate (MM/DD/YYYY): ";
            DateTime t_Bday = AskDateTimeUserInput(UserInput);
            Console.WriteLine();
            OutputTeacherInfo(t_First, t_Last, t_Bday);

        }

        // Outputs the infos the user entered on a Professor. {x} are indexes related to the arguments passed in the Console object.
        static void OutputTeacherInfo(string t_First, string t_Last, DateTime t_Bday)
        {
            Console.WriteLine("{0}Professor {1} {2} was born the {3:MM/dd/yyyy}{0}",
                Environment.NewLine, t_First, t_Last, t_Bday);
            Console.WriteLine();
        }
        #endregion

        #region Dedicated to Degree
        // Is called in Main.Degree Getter method calling ConsoleInfoInput and AskUserInt32Input where the user enters 
        // the asked data and assign it to the proper arguments.
        // Ouputs the infos given by the user
        private static void GetDegreeInfo()
        {
            string message = ("Please enter the Degree's name: \n");
            string d_Name = ConsoleInfoInput(message);
            Console.WriteLine();
            message = "Please enter the type of the degree(i.e B.S, M.S, PhD)\n";
            string d_Type = ConsoleInfoInput(message);
            Console.WriteLine();
            message = ("Please enter the total number of hours to complete the Degree:\n");
            int d_CreditTotalNumHours = AskUserInt32Input(message);
            Console.WriteLine();
            OutputDegreeInfo(d_Name, d_Type, d_CreditTotalNumHours);
        }

        // Outputs the informations entered by the user related to a Degree.
        static void OutputDegreeInfo(string d_Name, string d_Type, int d_CreditTotalNumHours)
        {
            Console.WriteLine("{0}Degree's name: {1} is a {2}.\nTotal credit hours needed: {3}{0}",
                Environment.NewLine, d_Name, d_Type, d_CreditTotalNumHours);
            Console.WriteLine();
        }
        #endregion

        #region Dedicated to University Program
        // Is called in Main. University Getter method calling ConsoleInfoInput where the user enters 
        // the asked data and assign it to the proper arguments.
        // Ouputs the infos given by the user.
        private static void GetUnivProgramInfo()
        {
            string AskUserUnivProgInput = "Enter the University name: ";
            string u_Name = ConsoleInfoInput(AskUserUnivProgInput);
            Console.WriteLine();
            AskUserUnivProgInput = "Enter the degrees available in the university (i.e., B.S.,M.S.,Ph.D.): ";
            string u_Degrees = ConsoleInfoInput(AskUserUnivProgInput);
            Console.WriteLine();
            AskUserUnivProgInput = "Enter the department head's full name: ";
            string u_Head = ConsoleInfoInput(AskUserUnivProgInput);
            Console.WriteLine();
            OutputUnivProgramInfo(u_Name, u_Degrees, u_Head);
        }

        // Prints out the informations about the university program
        static void OutputUnivProgramInfo(string u_Name, string u_Degrees, string u_Head)
        {
            Console.WriteLine("{0}University's name: {1} \n\nDegrees available: {2}\n\nhead of the Department: {3}{0}",
                Environment.NewLine, u_Name, u_Degrees, u_Head);
            Console.WriteLine();
        }
        #endregion
    }
}
