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
        public EventCallback<int> TeaserSelected { get; set; }

        [Parameter]
        public List<ContactTeaserModel> Contacts { get; set; }
        
        public async Task ContactSelected(int id)
        {
            await TeaserSelected.InvokeAsync(id);
        }
    }
}
