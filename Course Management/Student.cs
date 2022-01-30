using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Course_Management
{
    public class Student : INotifyPropertyChanged
    {
        public int _studentID;
        public string _tspName;
        public string _studentFName;
        public string _studentLName;
        public string _batchID;
        public string _courseName;
        public string _dob;
        public string _phone;
        public int StudentID
        {
            get => this._studentID;
            set
            {
                this._studentID = value;
                this.OnPropertyChanged(nameof(StudentID));
            }
        }
        public string TspName
        {
            get => this._tspName;
            set
            {
                this._tspName = value;
                this.OnPropertyChanged(nameof(TspName));
            }
        }
        public string StudentFName
        {
            get => this._studentFName;
            set
            {
                this._studentFName = value;
                this.OnPropertyChanged(nameof(StudentFName));
            }
        }
        public string StudentLName
        {
            get => this._studentLName;
            set
            {
                this._studentLName = value;
                this.OnPropertyChanged(nameof(StudentLName));
            }
        }
        public string BatchID
        {
            get => this._batchID;
            set
            {
                this._batchID = value;
                this.OnPropertyChanged(nameof(BatchID));
            }
        }
        public string CourseName
        {
            get => this._courseName;
            set
            {
                this._courseName = value;
                this.OnPropertyChanged(nameof(CourseName));
            }
        }
        public string Dob
        {
            get => this._dob;
            set
            {
                this._dob = value;
                this.OnPropertyChanged(nameof(Dob));
            }
        }
        public string Phone
        {
            get => this._phone;
            set
            {
                this._phone = value;
                this.OnPropertyChanged(nameof(Phone));
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
