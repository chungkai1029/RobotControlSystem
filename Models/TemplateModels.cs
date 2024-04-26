namespace RobotControlSystem.Models
{
    public class TemplateSubmitRequest
    {
        public long id { get; set; }
    }

    public class TemplateSubmitResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
    }

    public class TemplateListRequest
    {
        public long? groupId { get; set; }
        public string? name { get; set; }
        public int? currentPage { get; set; }
        public int? pageSize { get; set; }
    }

    public class TemplateListResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
        public TemplateData data { get; set; }
    }

    public class TemplateData
    {
        public List<TaskChainTemplatePo> taskChainTemplatePo { get; set; }
        public List<TaskTemplatePos> taskTemplatePos { get; set; }
    }

    public class TaskChainTemplatePo
    {
        public long id { get; set; }
        public string name { get; set; }
        public long? amrId { get; set; }
        public long areaId { get; set; }
        public int priority { get; set; }
        public long createTime { get; set; }
        public bool? repeatFlag { get; set; }
    }

    public class TaskTemplatePos
    {
        public long id { get; set; }
        public long taskChainTemplateId { get; set; }
        public string endPointCode { get; set; }
        public long mapId { get; set; }
        public int? loading { get; set; }
        public string taskType { get; set; }
        public double sequence { get; set; }
        public int? dockingDirection { get; set; }
        public double? dockingX { get; set; }
        public double? dockingY { get; set; }
        public string? extend { get; set; }
    }

    public class GenericSubmitRequest
    {
        public long id { get; set; }
        public string name { get; set; }
        public int isReturn { get; set; }
        public Targets targets { get; set; }
    }

    public class Targets
    {
        public long mapId { get; set; }
        public string code { get; set; }
        public string extend { get; set; }
    }

    public class GenericSubmitResponse
    {
        public string errMsg { get; set; }
        public string errCode { get; set; }
        public bool state { get; set; }
        public long data { get; set; }
    }
}
