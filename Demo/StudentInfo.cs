using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
#region User Defined Data Type
    class StudentInfo
    {
        #region State - private
        private string id;
        private string name;
        private int marks;
        #endregion
        #region Behaviors, public interfaces / Mutators for message passing
        public string getId()
        { return this.id; }
        public string getName()
        { return this.name; }
        public int getMarks()
        { return this.marks; }
        public void setId(string value)
        { this.id = value; }
        public void setName(string value)
        { this.name = value; }
        public void setMarks(int value)
        { this.marks = value; }
        #endregion
#endregion

    }
}
