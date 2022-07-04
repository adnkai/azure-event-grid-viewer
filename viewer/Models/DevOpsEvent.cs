using System;
using Newtonsoft.Json;
namespace viewer.Models
{
    public class DevOpsEvent<T> where T: class
    {
        [JsonProperty("notificationId")]
        public string Id { get; set;}
        
        [JsonProperty("eventType")]
        public string EventType { get; set;}
        
        [JsonProperty("resource.revisedBy.displayName")]
        public string Subject {get; set;}
        
        [JsonProperty("createdDate")]
        public DateTime EventTime { get; set; } 
        
        [JsonProperty("resource")]
        public T Data { get; set; } 

        [JsonProperty("message.text")]
        public string Topic { get; set; }
    }
}


/*

details.id,
details.workItemId,
details.resource.revisedDate.ToLongTimeString(),
details.revisedBy.displayName,
e.ToString());

*/