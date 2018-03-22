using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MathsLibrary
{
    public class MathsOperations : IMathsOperations
    {
        public int Add(int num1, int num2)
        {
            return (num1 + num2);
        }

        public int Divide(int num1, int num2)
        {
            int result;

            try
            {
                result = num1 / num2;
            }
            catch (Exception e)
            {
                CustomFaultDetails customFaultDetails = new CustomFaultDetails();
                customFaultDetails.ErrorDetails = "division par 0";
                customFaultDetails.ErrorID = 424242;
                throw new FaultException<CustomFaultDetails>(customFaultDetails, "divide by 0");
            }
            return (result);
        }

        public int Multiply(int num1, int num2)
        {
            return (num1 * num2);
        }
    }

}
