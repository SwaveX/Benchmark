using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    public class MyParser
    {
        /// <summary>
        /// Try Catch is fu*king long and besides that it requires memory in heap for exception
        /// It's useless to use it for Parsing 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public int TryCatchParse(string str)
        {
            int result;

            try
            {
                result = int.Parse(str);
            }
            catch (Exception ex)
            {
                result = 0;
            }
            return result;
        }

        public int TryParse(string str)
        {
            int result;
            if (!int.TryParse(str, out result))
            {
                result = 0;
            }
            return result;
        }
        public int TryParseFixed(string str) //Best UwU
        {
            int result;
            int.TryParse(str, out result);            
            return result;
        }
        public int TryParseFixed_V2(string str)
        {
            int.TryParse(str, out int result);
            return result;
        }
    }
}
