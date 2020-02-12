using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using BlazorPik.Models;

namespace BlazorPik.Data
{
    public class ContactService
    {
        static string baseURL = "https://localhost:5001/";

         
        public ContactService()
        {
        }

        public static async Task<List<ContactTeaserModel>> GetContacts()
        {
            try
            {
                using (var http = new HttpClient())
                {
                    var uri = new Uri(baseURL + "api/contacts");
                    string json = await http.GetStringAsync(uri);
                    var customers = JsonConvert.DeserializeObject<List<ContactTeaserModel>>(json);
                    return customers;
                }
            }
            catch (Exception ex)
            {
                return new List<ContactTeaserModel>();
            }
        }

        internal static async Task<Contact> GetContact(int id)
        {
            try
            {
                using (var http = new HttpClient())
                {
                    var uri = new Uri(baseURL + "api/contacts/" + id);
                    string json = await http.GetStringAsync(uri);
                    var customers = JsonConvert.DeserializeObject<Contact>(json);
                    return customers;
                }
            }
            catch (Exception ex)
            {
                return new Contact();
            }
        }
    }
}
