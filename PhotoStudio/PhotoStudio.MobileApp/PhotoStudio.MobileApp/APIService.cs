using Flurl.Http;
using PhotoStudio.Data;
using System;
using System.Collections.Generic;
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
        
      
       
        public async Task<T> Get<T>(object search=null)
        {

            var url = $"{_apiUrl}/{_route}";
            try
            {

                //var query = "";
                //if (search != null)
                //{
                //    query = await search?.ToQueryString();
                //}
                ////  get all ako je null
                //var list = await $"{_apiUrl}/{_route}?{query}"
                // .WithBasicAuth(Username, Password)
                //  .GetJsonAsync<T>();
                //return list;
                

                if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }   
            catch (FlurlHttpException ex)
            {


                await Application.Current.MainPage.DisplayAlert("Greška", "Niste authentificirani", "OK");

                throw;
            }
}
        public async Task<T> GetProvjera<T>(object search)
        {
            var url = $"{_apiUrl}/{_route}";
            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }
            return await url.GetJsonAsync<T>();
        }
        public async Task<T> SingUp<T>(object request)
        {
            var url = $"{_apiUrl}/{_route}";
            return await url.PostJsonAsync(request).ReceiveJson<T>();
        }


        public async Task<T> GetById<T>(object id)
        {
            // try
            //{
            var url = $"{_apiUrl}/{_route}/{id}";
            // return await url.GetJsonAsync<T>();
            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            //}
            //catch(FlurlHttpException ex)
            //{
            //    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string>>();

            //    return HandleException<T>(errors);
            //}

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
            //catch (FlurlHttpException ex)
            //{
            //    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string>>();

            //    return HandleException<T>(errors);
            //}
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                //MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
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
            //catch (FlurlHttpException ex)
            //{
            //    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string>>();

            //    return HandleException<T>(errors);
            //}
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");

                //MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }

      

    }
}
