using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Spammeri
{
    internal class STAScheduler : TaskScheduler
    {
        // Static
        internal static STAScheduler Scheduler { get; }
        internal static TaskFactory Factory { get; }

        static STAScheduler()
        {
            Scheduler = new STAScheduler();
            Factory = new TaskFactory(Scheduler);
        }

        internal static void Start()
        {
            Scheduler.StartThread();
        }

        // Instance
        private readonly BlockingCollection<Task> _tasks = new BlockingCollection<Task>();
        private readonly Thread _staThread;

        private STAScheduler()
        {
            _staThread = new Thread(Run);
            _staThread.SetApartmentState(ApartmentState.STA);
            _staThread.IsBackground = true;
        }

        protected override IEnumerable<Task> GetScheduledTasks()
        {
            return _tasks;
        }

        protected override void QueueTask(Task task)
        {
            _tasks.Add(task);
        }

        protected override bool TryExecuteTaskInline(Task task, bool taskWasPreviouslyQueued)
        {
            return false; // Task always queued from MainForm.
        }
        private void StartThread()
        {
            _staThread.Start();
        }

        private void Run()
        {
            foreach (var task in _tasks.GetConsumingEnumerable())
            {
                TryExecuteTask(task);
            }
        }
    }
}
