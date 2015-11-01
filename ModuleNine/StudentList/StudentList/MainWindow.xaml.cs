using System;
using System.Collections.Generic;
using System.Windows;

namespace StudentList
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Students = new List<Student>();
        }

        private List<Student> Students;
        private Int32 iCurrentStudent = -1;

        private void btnPrevious_Click(Object sender, RoutedEventArgs e)
        {
            // Go to previous student
            if (iCurrentStudent > 0)
            {
                iCurrentStudent--;
                txtFirstName.Text = Students[iCurrentStudent].FirstName;
                txtLastName.Text = Students[iCurrentStudent].LastName;
                dtBirthDate.SelectedDate = Students[iCurrentStudent].BirthDate;
            }
        }

        private void btnCreate_Click(Object sender, RoutedEventArgs e)
        {
            String first = txtFirstName.Text;
            String last = txtLastName.Text;
            DateTime? birth = dtBirthDate.SelectedDate;
            // Create a new student only if the given values are accepted
            if (!String.IsNullOrEmpty(first) && !String.IsNullOrEmpty(last) && birth != null)
            {
                Student newStudent = new Student(first, last, birth);
                Students.Add(newStudent);
                // Make the new student current
                iCurrentStudent++;
                // Here's how to use a message box!
                MessageBox.Show("Student Added!", "Student List", MessageBoxButton.OK, MessageBoxImage.Information);
                // Clear fields
                txtFirstName.Text = "";
                txtLastName.Text = "";
                dtBirthDate.SelectedDate = null;
            }
        }

        private void btnNext_Click(Object sender, RoutedEventArgs e)
        {
            // Go to next student
            if (iCurrentStudent < Students.Count - 1)
            {
                iCurrentStudent++;
                txtFirstName.Text = Students[iCurrentStudent].FirstName;
                txtLastName.Text = Students[iCurrentStudent].LastName;
                dtBirthDate.SelectedDate = Students[iCurrentStudent].BirthDate;
            }
        }
    }

    public class Student
    {
        #region Constructors
        public Student(String firstName, String lastName, DateTime? birthDate)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
        }
        public Student() : this("", "", DateTime.Today) { }
        #endregion

        #region Properties
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public DateTime? BirthDate { get; set; } 
        #endregion
    }
}
