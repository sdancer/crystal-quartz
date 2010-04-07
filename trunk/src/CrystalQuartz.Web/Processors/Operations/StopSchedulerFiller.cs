namespace CrystalQuartz.Web.Processors.Operations
{
    using System.Web;
    using Core;

    public class StopSchedulerFiller : OperationFiller
    {
        public StopSchedulerFiller(ISchedulerProvider schedulerProvider)
            : base(schedulerProvider)
        {
        }

        protected override void DoAction(HttpResponseBase response, HttpContextBase context)
        {
            _schedulerProvider.Scheduler.Shutdown(false);
        }
    }
}