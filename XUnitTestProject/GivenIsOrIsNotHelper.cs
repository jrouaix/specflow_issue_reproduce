using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject
{
    public static class GivenIsOrIsNotHelper
    {
        public static bool Is(this GivenIsOrIsNot givenIsOrIsNot)
        {
            return givenIsOrIsNot == GivenIsOrIsNot.IS;
        }
        public static bool IsNot(this GivenIsOrIsNot givenIsOrIsNot)
        {
            return givenIsOrIsNot == GivenIsOrIsNot.IS_NOT;
        }
    }
}
