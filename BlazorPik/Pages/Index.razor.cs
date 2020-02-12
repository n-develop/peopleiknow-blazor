using System;
using BlazorPik.Models;

namespace BlazorPik.Pages
{
    public partial class Index
    {
        public Contact SelectedContact { get; set; }

        public void ContactSelected(Contact c)
        {
            if (c != null)
            {
                SelectedContact = c;
            }
        }
    }
}
