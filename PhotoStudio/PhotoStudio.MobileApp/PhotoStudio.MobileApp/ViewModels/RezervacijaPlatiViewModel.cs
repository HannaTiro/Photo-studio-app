using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;
using Prism.Commands;
using Prism.Navigation;
using Stripe;
using Xamarin.Forms;
using PhotoStudio.Data.Requests.Rezervacija;
using PhotoStudio.Data.Model;
using System.Threading;
using System.Threading.Tasks;
using Acr.UserDialogs;
using PhotoStudio.MobileApp.Views;

namespace PhotoStudio.MobileApp.ViewModels
{
    public class RezervacijaPlatiViewModel: BindableBase
    {
        APIService _rezervacijaService = new APIService("Rezervacija");


        #region Variable

        private CreditCardModel _creditCardModel;
        private RezervacijaUpsert _rezervacijaInsert;

        private TokenService Tokenservice;
        private Token stripeToken;
        private bool _isCarcValid;
        private bool _isTransectionSuccess;
        private string _expMonth;
        private string _expYear;
        private string _title;

        #endregion Variable
        #region Public Property
        
        private string StripeTestApiKey = "pk_test_51KbjlDCr05cbDgJVJmLRtpwhugNKQh0dWNXTimT6ANpNgJB8ZzzzHMySlDT3NXzzHFBJ7E2MVDYqEafLgkKnwYFq00wmpLfshL";
        private string StripeSecreatApiKey = "sk_test_51KbjlDCr05cbDgJVTMD8OZSHm3nzA2xXUfinqx67G4MqcXvyNVfpDybXMqEgaKy3sNJOUnvdunHMKIe3hmgWIxxQ00SlcymMEk";

        public string ExpMonth
        {
            get { return _expMonth; }
            set { SetProperty(ref _expMonth, value); }
        }

        public bool IsCarcValid
        {
            get { return _isCarcValid; }
            set { SetProperty(ref _isCarcValid, value); }
        }

        public bool IsTransectionSuccess
        {
            get { return _isTransectionSuccess; }
            set { SetProperty(ref _isTransectionSuccess, value); }
        }

        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public string ExpYear
        {
            get { return _expYear; }
            set { SetProperty(ref _expYear, value); }
        }
        //decimal _iznos = 0;
        //public decimal Iznos
        //{
        //    get { return _iznos; }
        //    set { SetProperty(ref _iznos, value); }
        //}
      
        public RezervacijaUpsert RezervacijaUpsert
        {
            get { return _rezervacijaInsert; }
            set { SetProperty(ref _rezervacijaInsert, value); }
        }

        public CreditCardModel CreditCardModel
        {
            get { return _creditCardModel; }
            set { SetProperty(ref _creditCardModel, value); }
        }

        #endregion Public Property
        #region Constructor

        public RezervacijaPlatiViewModel()
        {
            CreditCardModel = new CreditCardModel();
            Title = "Card Details";
        }

        #endregion Constructor
        #region Command

        public DelegateCommand SubmitCommand => new DelegateCommand(async () =>
        {

         
            var rezervacija = await _rezervacijaService.GetById<Data.Model.Rezervacija>(RezervacijaId);

            CreditCardModel.ExpMonth = Convert.ToInt64(ExpMonth);
            CreditCardModel.ExpYear = Convert.ToInt64(ExpYear);
            CancellationTokenSource tokenSource = new CancellationTokenSource();
            CancellationToken token = tokenSource.Token;
            try
            {
                if (rezervacija.IsPlaceno == true)
                {
                    UserDialogs.Instance.Alert("Greška", "Već plaćeno", "OK");
                  
                }

                UserDialogs.Instance.ShowLoading("Payment processing..");
                await Task.Run(async () =>
                {
                    
                    var Token = CreateToken();
                  
                    Console.Write("Payment Gateway" + "Token :" + Token);
                    if (Token != null)
                    {
                        IsTransectionSuccess = MakePayment(Token);
                    }
                    else
                    {
                        UserDialogs.Instance.Alert("Neispravni podaci za uplatu", null, "OK");
                    }
                });
            }
            catch (Exception ex)
            {
                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert(ex.Message, null, "OK");
                Console.Write("Payment Gatway" + ex.Message);


            }

            if (IsTransectionSuccess)
            {

                //await _rezervacijaService.Insert<Data.Model.Rezervacija>(RezervacijaUpsert);
                //Console.Write("Payment Gateway" + "Payment Successful ");
                //UserDialogs.Instance.Alert("Your payment was successfull", "Payment success", "OK");
                //UserDialogs.Instance.Alert("Uspješno ste rezervisali fotografa!", "Payment success", "OK");
                //UserDialogs.Instance.HideLoading();

                
                UserDialogs.Instance.HideLoading();
              
                var request = new RezervacijaUpsert
                {
                    DatumDo = rezervacija.DatumDo,
                    DatumOd = rezervacija.DatumOd,
                    FotografId = rezervacija.Fotograf.FotografId,
                    KorisnikId = APIService.KorisnikId,
                    IsKomentarisano = rezervacija.IsKomentarisano,
                    IsOcijenjeno = rezervacija.IsOcijenjeno,
                    //IZNOS = >//avans...ne ukupno fiksno 50KM 

                    //IsPLACENO= dodati radi filtriranja koje rezervacije su placene, a koje ne
                    IsPlaceno = true
                   

                };
                var updateo = await _rezervacijaService.Update<Data.Model.Rezervacija>(RezervacijaId, request);
                Console.Write("Payment Gateway" + "Payment Successful ");
               
                UserDialogs.Instance.Alert("Uspješno ste rezervisali fotografa!", "Payment success", "OK");
                Xamarin.Forms.Application.Current.MainPage = new PocetniPage();

            }
            else
            {

                UserDialogs.Instance.HideLoading();
                UserDialogs.Instance.Alert("Oops, something went wrong", "Payment failed", "OK");
                Console.Write("Payment Gateway" + "Payment Failure ");
            }
            

        });
        public int RezervacijaId { get; set; }
        public int FotografId { get; set; }
        public Data.Model.Fotograf _fotograf { get; set; }


        #endregion Command
        #region Method

        private string CreateToken()
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeTestApiKey);
                var service = new ChargeService();
                var Tokenoptions = new TokenCreateOptions
                {
                    Card = new TokenCardOptions
                    {
                        Number = CreditCardModel.Number,
                        ExpYear = CreditCardModel.ExpYear,
                        ExpMonth = CreditCardModel.ExpMonth,
                        Cvc = CreditCardModel.Cvc,
                        Name = APIService.Username,
                        AddressLine1 = "Adresa1",
                        AddressLine2 = "Adresa2",
                        AddressCity = "Sarajevo",
                        AddressZip = "81000",
                        AddressState = "Sarajevski kanton",
                        AddressCountry = "Bosna i Hercegovina",
                        Currency = "bam",

                    }
                };

                Tokenservice = new TokenService();
                stripeToken = Tokenservice.Create(Tokenoptions);
                return stripeToken.Id;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool MakePayment(string token)
        {
            try
            {
                StripeConfiguration.SetApiKey(StripeSecreatApiKey);
                var options = new ChargeCreateOptions
                {
                    Amount = (50) * 100,

                    Currency = "bam",
                    Description = "Charge for "+APIService.Username,
                    Source = stripeToken.Id,
                    StatementDescriptor = "Custom descriptor",
                    Capture = true,
                    ReceiptEmail = "sonu.sharma@gmail.com",
                };
                //Make Payment
                var service = new ChargeService();
                Charge charge = service.Create(options);
                return true;
            }
            catch (Exception ex)
            {
                Console.Write("Payment Gatway (CreateCharge)" + ex.Message);
                throw ex;
            }
        }

        private bool ValidateCard()
        {
            if (CreditCardModel.Number.Length == 16 && ExpMonth.Length == 2 && ExpYear.Length == 2 && CreditCardModel.Cvc.Length == 3)
            {
            }
            return true;
        }

        #endregion Method

    }
}
