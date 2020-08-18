using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261014_w05
{
    class Lecturer
    {
        private string lecturerFName;
        private string lecturerLName;
        private string lecturerPosition;

        public string LecturerFName
        {
            get { return lecturerFName; }
            set { lecturerFName = value; }
        }

        public string LecturerLName
        {
            get { return lecturerLName; }
            set { lecturerLName = value; }
        }

        public string LecturerPosition
        {
            get { return lecturerPosition; }
            set { lecturerPosition = value; }
        }
        public Lecturer(string sc, string lln, string lp)
        {
            this.LecturerFName = sc;
            this.LecturerLName = lln;
            this.LecturerPosition = lp;

        }
        public override string ToString()
        {
            return this.LecturerFName + this.LecturerLName + this.LecturerPosition;
        }
    }
}