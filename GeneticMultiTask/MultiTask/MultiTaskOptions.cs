using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTask
{
    public static class MultiTaskOptions
    {
        public static ParallelOptions parallelOptMutation = new ParallelOptions()
        {
            MaxDegreeOfParallelism = 100
        };
        public static ParallelOptions parallelOptCrossover = new ParallelOptions()
        {
            MaxDegreeOfParallelism =  100
        };
    }
}
