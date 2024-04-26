namespace RobotControlSystem.Models
{
    public class TaskAddRequest
    {
        public TaskChain taskChain { get; set; }
        public List<Tasks> tasks { get; set; }
    }

    public class TaskChain
    {
        public int? isReturn { get; set; }
        public long areaId { get; set; }
        public int? priority { get; set; }
        public long? amrId { get; set; }
        public long groupId { get; set; }
    }

    public class Tasks
    {
        public string taskType { get; set; }
        public long mapId { get; set; }
        public string endPointCode { get; set; }
        public string? extend { get; set; }
    }

    public class TaskAddResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
        public long data { get; set; }
    }

    public class GetTaskChainByIdsRequest
    {
        public List<int> taskChainIds { get; set; }
    }

    public class GetTaskChainByIdsResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
        public TaskData data { get; set; }
    }

    public class TaskData
    {
        public List<TaskChainPo> taskChainPo { get; set; }
        public List<TaskPos> taskPos { get; set; }
    }

    public class TaskPos
    {
        public long? id { get; set; }
        public string taskType { get; set; }
        public string endPointCode { get; set; }
        public long taskChainId { get; set; }
        public long mapId { get; set; }
        public int status { get; set; }
        public long startTime { get; set; }
        public long finishTime { get; set; }
        public int? loading { get; set; }
    }

    public class TaskCancelRequest
    {
        public long orderChainId { get; set; }
    }

    public class TaskCancelResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
        public string data { get; set; }
    }

    public class TaskPriorityRequest
    {
        public long taskChainId { get; set; }
        public int priority { get; set; }
    }

    public class TaskPriorityResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
    }
}
