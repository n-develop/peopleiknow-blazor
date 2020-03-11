using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPik.Data;
using BlazorPik.Models;

namespace BlazorPik.Pages
{
    public partial class Index
    {
        public List<ContactTeaserModel> Contacts { get; set; }

        public Contact SelectedContact { get; set; }

        public async Task ContactSelected(int id)
        {
            var c = await ContactService.GetContact(id);
            if (c != null)
            {
                SelectedContact = c;
            }
        }
        
        protected override async Task OnInitializedAsync()
        {
            Contacts = await ContactService.GetContacts();
        }
    }
}
