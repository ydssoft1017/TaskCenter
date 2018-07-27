using System;
using System.Collections.Generic;
using System.Text;
using TaskUtility;
namespace TaskService
{
    [TaskServiceCaption("测试任务服务2")]
    
    public class DemoService2 : DefaultTaskService
    {
        public override BoolMessage OnServiceRun()
        {
            return BoolMessage.True;
        }
    }
}
