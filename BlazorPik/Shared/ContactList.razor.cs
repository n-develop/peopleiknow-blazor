using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorPik.Data;
using BlazorPik.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorPik.Shared
{
    public partial class ContactList
    {
        [Parameter]
        public EventCallback<Contact> TeaserSelected { get; set; }

        public List<ContactTeaserModel> Contacts { get; set; } = new List<ContactTeaserModel>();
        public Contact SelectedContact { get; set; }

        public async Task ContactSelected(int id)
        {
            var c = await ContactService.GetContact(id);
            if (c != null)
            {
                SelectedContact = c;
                await TeaserSelected.InvokeAsync(c);
            }
        }

        protected override async Task OnInitializedAsync()
        {
            Contacts = await ContactService.GetContacts();
        }
    }
}
