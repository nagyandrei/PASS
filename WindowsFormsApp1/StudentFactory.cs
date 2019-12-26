using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class StudentFactory
    {
        bool mType;
        public StudentFactory(bool Type)
        {
            mType = Type;
        }

        public StudentDAO Build()
        {
            if(mType)
            {
                return new StudentDAOXml();
            }
            return new StudentDAOSql();
        }
    }
}
