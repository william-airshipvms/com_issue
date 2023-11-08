using System;
using System.Runtime.InteropServices;

namespace ComProject1
{
    [ComVisible(true)]
    [Guid("81e94558-d593-4af1-b064-e2495d26979e")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IServer
    {
        /// <summary>
        /// Compute the value of the constant Pi.
        /// </summary>
        double ComputePi();
    }


    [ComVisible(true)]
    [Guid("1886d7fa-4ec6-4c40-945c-429bfdd9e407")]
    public class Server : IServer
    {
        public double ComputePi()
        {
            double sum = 0.0;
            int sign = 1;
            for (int i = 0; i < 1024; ++i)
            {
                sum += sign / (2.0 * i + 1.0);
                sign *= -1;
            }

            return 4.0 * sum;
        }
    }
}