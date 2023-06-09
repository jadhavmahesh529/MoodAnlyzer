using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalazer
{
    public class MoodAnalyser
    {
        public string HAPPYMOOD = "Happy";
        public string SADMOOD = "Sad";

        public string AnalyzeMood(string mood)
        {
           if(mood.Contains("HAPPY")) 
           {
                Console.WriteLine("Happy");
                return HAPPYMOOD;
           }
            if (mood.Contains("SAD");
            {
                Console.WriteLine("Sad");
                return SADMOOD;
            }
        }
        
    }
}
