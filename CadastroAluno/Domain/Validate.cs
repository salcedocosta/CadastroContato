using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace Domain
{
    public class Validate
    {
        public EnumValidate Type { get; set; }
        public string Message { get; set; }
    }

    public enum EnumValidate
    {
        Success = 0,
        Error = 1,
        Warning = 2
    }
}
