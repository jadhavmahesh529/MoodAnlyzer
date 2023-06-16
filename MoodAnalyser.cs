﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalazer
{
    public class MoodAnalyser
    {
        string message;
        public string HAPPY = "HAPPY";
        public string SAD = "SAD";
        public MoodAnalyser()
        {
            message = "";
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            if (message.Contains("I am in Sad Mood"))
            {
                return SAD;
            }
            if (message.Contains("I am in Happy Mood"))
            {
                return SAD;
            }
            return null;
        }

    }


}

