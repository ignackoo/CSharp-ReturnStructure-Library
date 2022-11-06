/******************************************************************************
**  Copyright(c) 2022 ignackoo. All rights reserved.
**
**  Licensed under the MIT license.
**  See LICENSE file in the project root for full license information.
**
**  This file is a part of the C# Registry Library.
** 
**  Return Structure
**
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// Example of use
// 
// ReturnStructure TestFunction(Exception ex)
// {
//     ReturnStructure rs = new ReturnStructure();
//     rs.StatusCode = 0;
//     rs.Message = "Status Code OK";
//     rs.Exception = ex;
//     return (rs);
// }
//
// ReturnStructure TestFunction2(Exception ex)
// {
//     return (new ReturnStructure(0, "Status Code OK", ex);
// }
//


namespace Library
{
    public class ReturnStructure
    {
        /// <summary>
        /// Status Code return value; <0 ERROR, =0 OK, >0 WARNING
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// Message return value; "" empty string or "nonempty string"
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Exception return value; NULL or Exception
        /// </summary>
        public Exception Exception { get; set; }

        public ReturnStructure()
        {
        }
        public ReturnStructure(int iStatusCode, string sMessage, Exception eException)
        {
            this.StatusCode = iStatusCode;
            this.Message = sMessage;
            this.Exception = eException;
        }
    }
}
