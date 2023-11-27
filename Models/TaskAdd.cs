namespace RobotControlSystem.Models
{
    public class TaskAddRequest
    {
        public TaskChain taskChain { get; set; }
        public List<Tasks> tasks { get; set; }
    }

    public class TaskChain
    {
        public bool? isReturn { get; set; }
        public ulong areaId { get; set; }
        public byte? priority { get; set; }
        public ulong? amrId { get; set; }
        public ulong groupId { get; set; }
    }

    public class Tasks
    {
        public string taskType { get; set; }
        public ulong mapId { get; set; }
        public string endPointCode { get; set; }
        public string? extend { get; set; }
    }

    public class TaskAddResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
        public ulong data { get; set; }
    }
}
