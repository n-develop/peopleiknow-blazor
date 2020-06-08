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

        async Task UpdateContact()
        {
            var result = await ContactService.UpdateContact(SelectedContact);
            if (result.IsNull())
            {
                // TODO what should I do in this case?
            }
            else
            {
                SelectedContact = result;
                Contacts = await ContactService.GetContacts();
                // TODO this is not a great way to update the UI. Loading ALL the contacts again is too much.
            }
        }
        
        protected override async Task OnInitializedAsync()
        {
            Contacts = await ContactService.GetContacts();
        }
    }
}
