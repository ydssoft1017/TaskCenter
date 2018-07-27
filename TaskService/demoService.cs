using System;
using TaskUtility;
namespace TaskService
{
    [TaskServiceCaption("测试任务服务")]
    public class DemoService : DefaultTaskService
    {
        public override BoolMessage OnServiceRun()
        {
            return BoolMessage.True;
        }
    }
}
