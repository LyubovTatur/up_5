using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_5_lib
{
    /// <summary>
    /// Мой класс ексепшон
    /// </summary>
    class Exception_1 : Exception
    {
        /// <summary>
        /// констр
        /// </summary>
        /// <param name="message"></param>
        public Exception_1(string message) : base(message)
        {
        }
    }
}
