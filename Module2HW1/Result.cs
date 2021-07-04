using System.Net.NetworkInformation;

namespace Module2HW1
{
    public class Result
    {
        public Result(bool flag)
        {
            Status = flag;
        }

        public Result(bool flag, string message)
            : this(flag)
        {
            ErrorMessage = message;
        }

        public bool Status { get; set; }
        public string ErrorMessage { get; set; }
    }
}