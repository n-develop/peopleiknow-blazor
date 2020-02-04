using System;
using BlazorPik.Models;
using Xunit;

namespace BlazorPik.Tests
{
    public class ContactTeaserTests
    {
        [Fact]
        public void HasName()
        {
            var teaser = new ContactTeaser();
            var name = teaser.Name;
        }

        public void HasAddress()
        {
            var teaser = new ContactTeaser();
            var name = teaser.Address;
        }

        public void HasEmails()
        {
            var teaser = new ContactTeaser();
            var name = teaser.Emails;
        }
    }
}
