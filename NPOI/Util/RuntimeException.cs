using System;

namespace jp.co.systembase.NPOI.Util
{
    [Serializable]
    public class RuntimeException:Exception
    {
        public RuntimeException()
            :base()
        {
            
        }
        public RuntimeException(string message)
            : base(message)
        {
        }
        public RuntimeException(Exception e)
            : base("", e)
        {
        }
        public RuntimeException(string exception, Exception ex)
            : base(exception, ex)
        {

        }
    }
}
