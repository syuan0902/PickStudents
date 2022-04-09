using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseStudent
{
    class PickStudents
    {
        static Random m_random = new Random();
        public static string[] PickSomeStudents(int numberOfStudents)
        {

            string[] m_pickedStudents = new string[numberOfStudents];
            for (int i = 0; i < numberOfStudents; i++)
            {
                m_pickedStudents[i] = RandomValue();
            }
            return m_pickedStudents;
        }

        private static string RandomValue()
        {
            int m_value = m_random.Next(1, 46);
            return m_value.ToString();
        }
    }
}
