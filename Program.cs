using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Module1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* create variable and assign them a value
             * So that those values can be changed
             * later for the assignment's purpose 
             * */

            #region Student declaring and assigning values to Student related variables

            string s_first = "\nFaïza\n";
            string s_last = "Harbi\n";
            string s_email = "faiza.harbi@mic.edu\n";
            DateTime  s_birthdate = new DateTime(1982, 03, 06);
            string s_address_line_1 = "10 Main Street\n";
            string s_address_line_2 = "1st floor\n";
            string s_city = "Paris\n";
            string s_state_province = "";
            string s_zip_Postal = "\n34070\n";
            string s_contact2 = "Ju Mazet, 10 Main Street, +33612345678\n";
            string s_state = "none\n";
            string s_country = "France\n";
            float s_GPA = 4.1f;
            string s_year = "\nOne\n";
            string degree = "Bachelor's\n";
            string course1 = "Java 1\n";
            string course2 = "C 1\n";
            string course3 = "C# 1\n";
            #endregion


            #region Degree delaring and assigning values to Degree related variables

            string degree_name = "\nBachelor of Science in Information Technology\n";
            string d_field = "Computer Science and Programming; Data processing\n";
            string d_prereq = "High-school maths level\n";
            UInt16 d_credits = 80;
            #endregion

            #region University declaring and assigning values to University related variables

            string u_department_head = "\nDavid J. Malan\n";
            string univ_name = "Mic University\n";
            string univ_address = "1 Dawn St.\n";
            string univ_contact = "contact@mic.edu";
            string univ_programs = "Science in Information Technology, Psychology, Business & Management\n";
            string univ_degrees = "Bachelor, Master, Ph.D.\n";
            string u_dean = "L. Rorschach\n";
            #endregion
            
            #region Professor declaring and assigning values to Professor related variables

            string p_first = "\nBill\n";
            string p_last = "Gates\n";
            DateTime p_bday = new DateTime(1976,01,09);
            string p_appointment_title = "Professor of the Practice of Computer Science; Member of the Faculty of Education\n";
            string p_department = "Other Academic; Staff\n";
            string p_mailing_address = "Mic Engineering & Applied Sciences\nLinus Torvald 42\n33 First St\nCambridge MA 02138\n";
            string p_email = "bill.gates@mic.edu\n";
            string p_field = "Computer Science and Programming, C#\n";
            string p_building = "10 Dawn St. 042\n";
            string p_office_phone = "+1 555 555 5555\n";
            string p_office_fax = "+1 555 555 5556\n";
            string p_unit = "Mic Graduate School of Education; Faculty or Arts and Sciences\n";
            #endregion



            Console.SetWindowSize(100, 57);
            Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Type the inital of the informations you want to access (s for student,p for professor,\n u for university,f for fields of study,\n d for degrees:");
            string typed = "";
            do{
                    typed = Console.ReadLine();
                    
                    if(typed == "s")
                    {
                        Console.WriteLine(s_first);
                        Console.WriteLine(s_email);
                        Console.WriteLine(s_birthdate+"\n");
                        Console.WriteLine(s_address_line_1);
                        Console.WriteLine(s_address_line_2);
                        Console.WriteLine(s_zip_Postal);
                        Console.WriteLine(s_city);
                        Console.WriteLine(s_state_province);
                        Console.WriteLine(s_country);
                        Console.WriteLine(s_email);
                        Console.WriteLine(s_contact2);
                        Console.WriteLine(s_GPA);
                        Console.WriteLine(s_year);
                        Console.WriteLine(course1+ " ;"+course2+ " ;"+course3);
                    }
                    else if(typed == "p")
                    {
                        Console.WriteLine(p_first);
                        Console.WriteLine(p_last);
                        Console.WriteLine(p_bday+"\n");
                        Console.WriteLine(p_appointment_title);
                        Console.WriteLine(p_department);
                        Console.WriteLine(p_field);
                        Console.WriteLine(p_mailing_address);
                        Console.WriteLine(p_appointment_title);
                        Console.WriteLine(p_office_phone);
                        Console.WriteLine(p_office_fax);
                        Console.WriteLine(p_email);
                    } 
                    else if(typed == "d")
                    {
                        Console.WriteLine(degree_name);
                        Console.WriteLine(d_field);
                        Console.WriteLine(d_prereq);
                        Console.WriteLine(d_credits);
                        Console.WriteLine(u_department_head);
                    }
                    else if (typed == "u")
                    {
                        Console.WriteLine(univ_name);
                        Console.WriteLine(univ_address);
                        Console.WriteLine(univ_programs);
                        Console.WriteLine(univ_degrees);
                        Console.WriteLine(u_dean);
                        Console.WriteLine(univ_contact);    
                    }
                    else if (typed == "f")
                    {
                        Console.WriteLine(d_field);
                    }
                    else
                    {
                        
                        Console.WriteLine("You have to type either s, p, d, u, or f\n");
                    }

            } while (typed != "s" && typed != "p" && typed != "u" && typed != "d" && typed != "f");            
            
            Console.Title = "Module One";
            Console.ReadKey();
            
        }
    }
}