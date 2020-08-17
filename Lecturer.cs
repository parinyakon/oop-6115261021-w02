using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w02
{
    class Lecturer
    {
        private string lecturerFirstName;
        private string lecturerLastName;
        private string lecturerPosition;
        public string LecturerFirstName
        {
            get { return lecturerFirstName; }
            set { lecturerFirstName = value; }
        }
        public string LecturerLastName
        {
            get { return lecturerLastName; }
            set { lecturerLastName = value; }
        }
        public string LecturerPosition
        {
            get { return lecturerPosition; }
            set { lecturerPosition = value; }
        }

        public Lecturer() { }
        public Lecturer(string lfn, string lln, string lp)
        {
            this.lecturerFirstName = lfn;
            this.lecturerLastName = lln;
            this.lecturerPosition = lp;
            
        }
        public override string ToString()
        {
            return this.lecturerFirstName
            + this.lecturerLastName
            + this.lecturerPosition;

        }
    }
}
