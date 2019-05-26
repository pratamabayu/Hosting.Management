using System;
using System.Threading;
using System.Threading.Tasks;

namespace Hosting.Management.Scheduling
{
    public interface IScheduledTask
    {
        string Schedule { get; }
    }
}
