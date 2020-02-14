using System.Runtime.Serialization;

namespace BlazorPik.Models
{
    public class TelephoneNumber
    {
        public int Id { get; set; }
        public string Telephone { get; set; }
        public string Type { get; set; }

        public int ContactId { get; set; }

        [System.Text.Json.Serialization.JsonIgnore] 
        public virtual Contact Contact { get; set; }

        public string TelephoneNormalized => string.IsNullOrEmpty(Telephone)
            ? string.Empty
            : Telephone.Replace(" ", "")
                .Replace("-", "")
                .Replace("(", "")
                .Replace(")", "");

        public virtual bool IsNull()
        {
            return false;
        }
    }
}