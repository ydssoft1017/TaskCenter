using System;
using System.Threading.Tasks;
using Quartz;
using Quartz.Impl;
namespace QuartzService
{
    public class FindService : IJob
    {
        Task IJob.Execute(IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
    public class BuildTask
    {
        public async Task DoTask(string sercicename)
        {
            //https://github.com/YANGKANG01/QuartzNetJob
            //https://github.com/guryanovev/CrystalQuartz
            //https://github.com/ydssoft1017/CrystalQuartz.git
            //1.首先创建一个作业调度池
            ISchedulerFactory schedf = new StdSchedulerFactory();
            IScheduler sched = await schedf.GetScheduler();
            //2.创建出来一个具体的作业
            IJobDetail job = JobBuilder.Create<FindService>().Build();
            //3.创建并配置一个触发器
            ISimpleTrigger trigger = (ISimpleTrigger)TriggerBuilder.Create().WithSimpleSchedule(x => x.WithIntervalInSeconds(30000000).WithRepeatCount(int.MaxValue)).Build();
            //4.加入作业调度池中
            await sched.ScheduleJob(job, trigger);
            //5.开始运行
            await sched.Start();
        }
    }
}
