using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift3_Josefin
{
    class PersonHandler
    {
        public void SetName(Person pers, string fName)
        {

            pers = new Person(fName);
            pers.FirstName = fName;
        }
    }
}
