using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
     public class GradeStatistics
    {
        public GradeStatistics()
        {
            HighestGrade = 0;
            Lowestgrade = float.MaxValue;
        }
       

        public float AverageGrade;
        public float HighestGrade;
        public float Lowestgrade;   
    }
}
