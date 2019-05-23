using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Procedure : IComparable<Procedure>
    {
        private string procedureName;
        private int cycleLength;

        public string ProcedureName
        {
            get { return procedureName; }
            set { procedureName = value; }
        }

        public int CycleLength
        {
            get { return cycleLength; }
            set { cycleLength = value; }
        }

        public int CompareTo(Procedure other)
        {
            if (this.CycleLength > other.CycleLength)
                return 1;
            else if (this.CycleLength < other.CycleLength)
                return -1;
            else
                return 0;
        }

        public Procedure()
        {
            ProcedureName = "";
            CycleLength = 0;
       
        }

        public Procedure(string procedureName, int cycleLength)
        {
            ProcedureName = procedureName;
            CycleLength = cycleLength;

        }

        public override string ToString()
        {
            string output = string.Empty;
            output = string.Format("{0}, {1}", ProcedureName, CycleLength);

            return output;
        }

    }

  
}
