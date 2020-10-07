using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SENG8040
{
    public static class TriangleSolver
    {
        /// <summary>
        /// Validate if input forms Trangle
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>

        public static bool ValidateTrangle(int side1, int side2, int side3)
        {
            // check condition 
            if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
                return false;
            else
                return true;
        }

      
        /// <summary>
        /// Check Type of Trangle
        /// </summary>
        /// <param name="side1"></param>
        /// <param name="side2"></param>
        /// <param name="side3"></param>
        /// <returns></returns>
        public static string GetTrangleType(int side1, int side2, int side3)
        {
            string outputString = string.Empty;

            if(side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles"; 
            }
            else
            {
                return "Scalene";
            }

        }
    }
}
