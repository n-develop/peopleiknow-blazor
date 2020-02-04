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
            Assert.Equal("", teaser.Name);
        }
    }
}
