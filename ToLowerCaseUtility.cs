using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace LowerCase.Utility
{
    public class ToLowerCaseUtility
    {
        public static string ToLowerCase(string str)
        {
            if (String.IsNullOrEmpty(str))
                return str;
            

            string strLower = str.ToLower();
            string result = String.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                // Lower Case
                if (str[i] == strLower[i])
                {
                    result += strLower[i];
                }
                else // Upper Case
                {
                    result += "_" + strLower[i];
                }
            }

            // do not start with "_"
            if (result.StartsWith("_"))
            {
                return result.Substring(1);
            }
            else
            {
                return result;
            }
        }
    }
}
