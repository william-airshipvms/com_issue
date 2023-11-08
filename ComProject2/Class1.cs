using System.Runtime.InteropServices;

namespace ComProject2
{
    [ComVisible(true)]
    [Guid("58acfd7a-2c53-4437-8ee7-f7d9b0dd8f4c")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IServer
    {
        /// <summary>
        /// Compute the value of the constant Pi.
        /// </summary>
        double ComputePi();
    }

    [ComVisible(true)]
    [Guid("7cceb258-a1f3-4c66-8998-d360a791042c")]
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