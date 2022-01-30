using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Course_Management
{
    public class ViewModel : INotifyPropertyChanged
    {
        private List<Student> Students;
        private int currentStudent;
        public Command NextStudent { get; private set; }
        public Command PreviousStudent { get; private set; }
        public ViewModel()
        {
            this.currentStudent = 0;
            this.IsAtStart = true;
            this.IsAtEnd = false;
            this.NextStudent = new Command(this.Next, () =>
            this.Students.Count > 1 && !this.IsAtEnd);
            this.PreviousStudent = new Command(this.Previous, () =>
            this.Students.Count > 0 && !this.IsAtStart);
            this.Students = new List<Student>
            {
                new Student
                {
                    StudentID = 11299,
                    TspName = "USSL",
                    StudentFName = "RAIHAN",
                    StudentLName = "KABIR",
                    BatchID = "USSL-29-1A-CS",
                    CourseName = "ESAD-CS",
                    Dob = "05-10-1993",
                    Phone = "111-1111"
                },
                new Student
                {
                    StudentID = 11356,
                    TspName = "USSL",
                    StudentFName = "AZMAL",
                    StudentLName = "HOSSAIN",
                    BatchID = "USSL-29-1A-CS",
                    CourseName = "ESAD-CS",
                    Dob = "02-07-1995",
                    Phone = "111-2222"
                },
                new Student
                {
                    StudentID = 11211,
                    TspName = "USSL",
                    StudentFName = "MIFTAHUL",
                    StudentLName = "ALAM",
                    BatchID = "USSL-29-1A-WPSI",
                    CourseName = "WPSI",
                    Dob = "19-11-1998",
                    Phone = "111-3333"
                },
                new Student
                {
                    StudentID = 11196,
                    TspName = "Data Park",
                    StudentFName = "MD.",
                    StudentLName = "ABDULLAH",
                    BatchID = "DP-29-1A-GV",
                    CourseName = "GAVE",
                    Dob = "25-09-1999",
                    Phone = "111-4444"
                },
                new Student
                {
                    StudentID = 11567,
                    TspName = "TCL IT",
                    StudentFName = "RAFIQUL",
                    StudentLName = "ISLAM",
                    BatchID = "TCL-29-1M-J2EE",
                    CourseName = "ESAD–J2EE",
                    Dob = "24-03-1994",
                    Phone = "111-5555"
                },
                new Student
                {
                    StudentID = 11120,
                    TspName = "PNTL",
                    StudentFName = "SIRAJUR",
                    StudentLName = "RAHMAN",
                    BatchID = "PNT-29-1M-GV",
                    CourseName = "GAVE",
                    Dob = "01-01-1997",
                    Phone = "111-6666"
                }
            };
        }
        private bool _isAtStart;
        public bool IsAtStart
        {
            get => this._isAtStart;
            set
            {
                this._isAtStart = value;
                this.OnPropertyChanged(nameof(IsAtStart));
            }
        }
        private bool _isAtEnd;
        public bool IsAtEnd
        {
            get => this._isAtEnd;
            set
            {
                this._isAtEnd = value;
                this.OnPropertyChanged(nameof(IsAtEnd));
            }
        }

        public Student Current
        {
            get => this.Students.Count > 0 ? this.Students[currentStudent] : null;
        }

        private void Next()
        {
            if (this.Students.Count - 1 > this.currentStudent)
            {
                this.currentStudent++;
                this.OnPropertyChanged(nameof(Current));
                this.IsAtStart = false;
                this.IsAtEnd = (this.Students.Count - 1 == this.currentStudent);
            }
        }
        private void Previous()
        {
            if (this.currentStudent > 0)
            {
                this.currentStudent--;
                this.OnPropertyChanged(nameof(Current));
                this.IsAtEnd = false;
                this.IsAtStart = (this.currentStudent == 0);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
