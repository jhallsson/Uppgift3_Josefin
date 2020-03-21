using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    abstract class UserError
    {
        public virtual string UEMessage()
        {
            return "error";
        }
    }
}
