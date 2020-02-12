using System;
using System.Threading.Tasks;
using BlazorPik.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorPik.Shared
{
    public partial class ContactTeaser
    {
        [Parameter]
        public ContactTeaserModel Contact { get; set; }

        [Parameter]
        public EventCallback<int> TeaserSelected  { get; set; }

        void TeaserClicked()
        {
            TeaserSelected.InvokeAsync(Contact.Id);
        }

        protected override Task OnInitializedAsync()
        {
            return base.OnInitializedAsync();
        }
    }
}
