using Lucene.Net.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduSearch.Models
{
    public class CustomSimilarity : DefaultSimilarity
    {
        public override float Tf(float freq)
        {
            return freq;
        }
    }
}
