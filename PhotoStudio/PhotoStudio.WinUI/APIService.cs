using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhotoStudio.Data;
using System.Windows.Forms;
using Flurl;

namespace PhotoStudio.WinUI
{
    public class APIService
    {
        private string _route = null;
        public string endpoint = $"{Properties.Settings.Default.APIUrl}";

        public static string Username { get; set; }
        public static string Password { get; set; }

        public APIService(string route)
        {
            _route = route;
        }
        //private static T HandleException<T>(Dictionary<string, string> errors)
        //{
        //    if (errors != null)
        //    {
        //        errors.TryGetValue("message", out string message);

        //        MessageBox.Show(message, "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    else
        //        MessageBox.Show("Došlo je do greške", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //    return default;
        //}
        //public async Task<T> Prijava<T>(string username, string password)
        //{
        //    try
        //    {
        //        return await new Uri(Properties.Settings.Default.APIUrl)
        //                .AppendPathSegment(_route)
        //                .AppendPathSegment("autentifikacija")
        //                .WithBasicAuth(username, password)
        //                .GetJsonAsync<T>();
               
        //    }
        //    catch (FlurlHttpException ex)
        //    {
        //        if (ex.StatusCode == 401)
        //            MessageBox.Show("Neispravno korisničko ime ili lozinka! ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        else
        //            MessageBox.Show("Došlo je do greške, pokušajte opet! ", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);

        //        return default;
        //    }
        //}
        public async Task<T> Get<T>(object search = null)
        {
          //  try
            //{

                var query = "";
                if (search != null)
                {
                    query = await search?.ToQueryString();
                }
              //  get all ako je null
                var list = await $"{endpoint}/{_route}?{query}"
                 .WithBasicAuth(Username, Password)
                  .GetJsonAsync<T>();
                return list;
        //}
            //catch (FlurlHttpException ex)
            //{


            ////     catch (FlurlHttpException ex)
            ////{
            ////    var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

            ////    var stringBuilder = new StringBuilder();
            ////    foreach (var error in errors)
            ////    {
            ////        stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
            ////    }

            ////    MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
            ////    return default(T);
            ////}
            //var errors = await ex.GetResponseJsonAsync<Dictionary<string, string>>();

            //    return HandleException<T>(errors);
            //}
}
        public async Task<T> GetById<T>(object id)
        {
           // try
            //{
 var url = $"{endpoint}/{_route}/{id}";
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
 var url = $"{endpoint}/{_route}";

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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }

        public async Task<T> Update<T>(object id, object request)
        {
            try
            {
 var url = $"{endpoint}/{_route}/{id}";

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

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }

        }


    }
}
