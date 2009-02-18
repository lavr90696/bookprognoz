using System;
using System.Collections.Generic;
using System.Text;

namespace BookPrognoz
{
    public class BookPrognozException:Exception
    {

        public BookPrognozException(string message)
            : base(message)
        {

        }
    }
}
