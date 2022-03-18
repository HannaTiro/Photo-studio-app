using Flurl.Http;
using PhotoStudio.Data;
using PhotoStudio.Data.Requests.Korisnik;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace PhotoStudio.MobileApp
{
    public class APIService
    {
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int KorisnikId { get; set; }

        private readonly string _route = null;
#if DEBUG
        private string _apiUrl = "http://localhost:52869/api";

#endif
#if RELEASE
        private string _apiUrl = "https://mywebsite.com/api/"; 
#endif

        public APIService(string route)
        {
            _route = route;
        }


        public async Task<T> Get<T>(object search = null)
        {

            var url = $"{_apiUrl}/{_route}";
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                return await HandleException<T>(ex);
            }
        }
        public async Task<T> GetRegistracija<T>(object search = null)
        {

            var url = $"{_apiUrl}/{_route}/registracija";
            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                return await url.GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                return await HandleException<T>(ex);
            }
        }


        public async Task<T> GetById<T>(object id)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                return await HandleException<T>(ex);
            }

        }
        public async Task<T> Insert<T>(object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}";

                return await url
                    .WithBasicAuth(Username, Password)
                    .PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                return await HandleException<T>(ex);
            }
        }

        public async Task<T> Update<T>(object id, object request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url
                    .WithBasicAuth(Username, Password)
                    .PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                return await HandleException<T>(ex);
            }

        }

        private static async Task<T> HandleException<T>(FlurlHttpException ex)
        {
            if (ex.StatusCode == (int)HttpStatusCode.Unauthorized)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Neispravan username ili password", "OK");
            }
            else if (ex.StatusCode == (int)HttpStatusCode.Forbidden)
            {
                await Application.Current.MainPage.DisplayAlert("Greška", "Nemate pravo pristupa", "OK");
            }
            else
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");

            }
            return default;
        }

        public async Task<T> SignUp<T>(KorisnikUpsert request)
        {
            try
            {
                var url = $"{_apiUrl}/{_route}/signUp";

                return await url
                    .PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                return await HandleException<T>(ex);
            }
        }
    }
}
