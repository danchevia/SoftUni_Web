﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Site.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLenght = 50)
        {
            if (text == null || text.Length <= maxLenght)
            {
                return text;
            }

            var shorttext = text.Substring(0, maxLenght) + "...";
            return shorttext;
        }
    }
}