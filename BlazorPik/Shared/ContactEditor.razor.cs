using System.Threading.Tasks;
using BlazorPik.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorPik.Shared
{
    public partial class ContactEditor
    {
        [Parameter]
        public Contact Contact { get; set; }

        [Parameter]
        public EventCallback<string> ContactUpdated { get; set; }

        private async Task SaveButtonPressed(EditContext context)
        {
            ContactUpdated.InvokeAsync("").ConfigureAwait(false); // TODO brauche ich den string überhaupt?
        }

        private bool ShowIt = true;
        
        async Task CancelButtonPressed()
        {
            
        }
    }
}