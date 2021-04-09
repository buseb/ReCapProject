using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IAsyncResult Run(Results.IResult result, params IAsyncResult[] logics)
        {
            foreach(var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
