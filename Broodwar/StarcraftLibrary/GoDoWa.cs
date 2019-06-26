using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarcraftLibrary
{
    public class GoDoWa
    {
        public string ReturnReturn(ref string strTemp, string[] x)
        {
            //string strTemp = string.Empty;

            try
            {
                strTemp = x[0] + x[1];
            }
            catch (Exception e)
            {
                throw new Exception(e.ToString());
            }
            return strTemp;
        }
    }
}
