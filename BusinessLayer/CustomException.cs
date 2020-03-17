using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BusinessLayer
{
    public class CustomException:Exception
    {
        public CustomException(string str):base(str)
        {

        }
    }
}