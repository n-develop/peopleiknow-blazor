using System.Runtime.Serialization;

namespace BlazorPik.Models
{
    public class Relationship
    {
        public int Id { get; set; }
        public string Person { get; set; }
        public string Type { get; set; }

        public int ContactId { get; set; }

        [System.Text.Json.Serialization.JsonIgnore] 
        public virtual Contact Contact { get; set; }

        public virtual bool IsNull()
        {
            return false;
        }
    }
}