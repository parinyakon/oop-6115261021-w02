using System;
using System.Collections.Generic;
using System.Text;

namespace oop_6115261021_w02
{
    class StudyGroup
    {
        private string studyGroupName;
        private string studyGroupDegree;

        public string StudyGroupName
        {
            get { return studyGroupName; }
            set { studyGroupName = value; }
        }
        public string StudyGroupDegree
        {
            get { return studyGroupDegree; }
            set { studyGroupDegree = value; }
        }

        public StudyGroup() { }
        public StudyGroup(string sgn, string sgd)
        {
            this.studyGroupName = sgn;
            this.studyGroupDegree = sgd;

        }
        public override string ToString()
        {
            return this.studyGroupName
            + this.studyGroupDegree;

        }
    }
}
