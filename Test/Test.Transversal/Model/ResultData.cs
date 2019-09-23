using System;
using System.Collections.Generic;
using System.Text;

namespace Test.Transversal.Model
{
    public class ResultData<T>
    {
        public bool Result { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
