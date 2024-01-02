using System.Net.NetworkInformation;
using System.Text;

namespace IPUills;

internal class PingSomething
{

    public static string PingCurrentAddress()
    {
        Ping ping = new Ping();
        PingOptions options = new PingOptions();

        options.DontFragment = true;

        string data = "********************************";
        byte[] buffer = Encoding.ASCII.GetBytes(data);
        int timeout = 120;
        PingReply reply = ping.Send(IpAddressOperations.Address, timeout, buffer, options);

        if (reply.Status == IPStatus.Success)
        {
            return $"Address: {reply.Address}      RoundTrip time: {reply.RoundtripTime}";
        }

        return "Error";
    }
}
