using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiTask
{
    public static class MultiTaskOptions
    {
        public static ParallelOptions parallelOpt = new ParallelOptions()
        {
            MaxDegreeOfParallelism = 2
        };
    }
}
