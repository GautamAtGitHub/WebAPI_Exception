using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_Exception
{
    public class ExceptionHelper
    {
        ///We can make this method more usefull by adding more details about exception
        public static object ProcessError(Exception ex)
        {
            return new
            {
                error = new
                {
                    errorcode = ex.HResult,
                    message = ex.Message
                }
            };
        }
    }
}
