using System.Collections.Generic;
using System.Linq;
using BlazorPik.Data;
using BlazorPik.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorPik.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public ContactsController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/contacts
        [HttpGet]
        public IEnumerable<ContactTeaserModel> Get()
        {
            try
            {
                var contacts = _dbContext.Contacts.ToList();

                return contacts.Select(c => new ContactTeaserModel {
                    Firstname = c.Firstname,
                    Lastname = c.Lastname,
                    Address = c.Address,
                    BusinessTitle = c.BusinessTitle,
                    Employer = c.Employer,
                    Id = c.Id,
                    ImagePath = c.ImagePath,
                    IsFavorite = c.IsFavorite,
                    Middlename = c.Middlename,
                    Tags = c.Tags,
                    EmailAddress = c.EmailAddresses?.FirstOrDefault()?.Email
                }).ToList();
            }
            catch (System.Exception ex)
            {
                return new List<ContactTeaserModel>();
            }
        }

        // GET api/contacts/5
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            var contact = _dbContext.Contacts
                .Include(c => c.EmailAddresses)
                .Include(c => c.TelephoneNumbers)
                .Include(c => c.Relationships)
                .Include(c => c.StatusUpdates)
                .FirstOrDefault(c => c.Id == id);
            return contact ?? NullContact.GetInstance();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
