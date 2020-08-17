using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w02
{
    class Section
    {
        private string sectionRoom;
        private string sectionBuilding;
        private string sectionSubject;
        private string sectionLecturer;
        private string sectionDay;
        private string sectionStartTime;
        private string sectionEndTime;

        public string SectionRoom
        {
            get { return sectionRoom; }
            set { sectionRoom = value; }
        }
        public string SectionBuilding
        {
            get { return sectionBuilding; }
            set { sectionBuilding = value; }
        }
        public string SectionSubject
        {
            get { return sectionSubject; }
            set { sectionSubject = value; }
        }
        public string SectionLecturer
        {
            get { return sectionLecturer; }
            set { sectionLecturer = value; }
        }
        public string SectionDay
        {
            get { return sectionDay; }
            set { sectionDay = value; }
        }
        public string SectionStartTime
        {
            get { return sectionStartTime; }
            set { sectionStartTime = value; }
        }
        public string SectionEndTime
        {
            get { return sectionEndTime; }
            set { sectionEndTime = value; }
        }

        public Section() { }
        public Section(string sr, string sb, string ss, string sl, string sd, string sst, string set)
        {
            this.sectionRoom = sr;
            this.sectionBuilding = sb;
            this.sectionSubject = ss;
            this.sectionLecturer = sl;
            this.sectionDay = sd;
            this.sectionStartTime = sst;
            this.sectionEndTime = set;

        }
        public override string ToString()
        {
            return this.sectionRoom
               + this.sectionBuilding
               + this.sectionSubject
               + this.sectionLecturer
               + this.sectionDay
               + this.sectionStartTime
               + this.sectionEndTime;

        }
    }
}
