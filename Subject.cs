using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w02
{
    class Subject
    {
        private string subjectCode;
        private string subjectName;
        private string subjectCredit;
        private string subjectDescribe;
        private string subjectPractice;
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }
        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }
        public string SubjectCredit
        {
            get { return subjectCredit; }
            set { subjectCredit = value; }
        }
        public string SubjectDescribe
        {
            get { return subjectDescribe; }
            set { subjectDescribe = value; }
        }
        public string SubjectPractice
        {
            get { return subjectPractice; }
            set { subjectPractice = value; }
        }

        public Subject() { }
        public Subject(string sjc, string sjn, string sjcd, string sjd, string sjp)
        {
            this.subjectCode = sjc;
            this.subjectName = sjn;
            this.subjectCredit = sjcd;
            this.subjectDescribe = sjd;
            this.subjectPractice = sjp;
        }
        public override string ToString()
        {
            return this.SubjectCode
            + this.SubjectName
            + this.SubjectCredit
            + this.SubjectDescribe
            + this.SubjectPractice;

        }
    }
}
