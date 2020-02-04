using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorPik.Models
{
    public class ContactTeaser
    {
        public int Id { get; set; }

        public bool IsFavorite { get; set; }

        public string Firstname { get; set; }

        public string Middlename { get; set; }

        public string Lastname { get; set; }

        public string ImagePath { get; set; }

        public string Address { get; set; }

        public List<EmailAddress> EmailAddresses { get; set; }

        public string Employer { get; set; }

        public string BusinessTitle { get; set; }

        public string Tags { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                var fullname = string.Empty;
                if (!string.IsNullOrWhiteSpace(Firstname))
                {
                    fullname = Firstname;
                }

                if (!string.IsNullOrWhiteSpace(Middlename))
                {
                    fullname = string.Join(" ", fullname, Middlename);
                }

                if (!string.IsNullOrWhiteSpace(Lastname))
                {
                    fullname = string.Join(" ", fullname, Lastname);
                }

                return fullname.Trim();
            }
        }

        public virtual bool IsNull()
        {
            return false;
        }
    }
}
