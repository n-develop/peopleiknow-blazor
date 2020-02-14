using BlazorPik.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorPik.Shared
{
    public partial class ContactEditor
    {
        [Parameter]
        public Contact Contact { get; set; }
    }
}