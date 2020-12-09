using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TPFinalTallerDeProgramacion.DAL.Interfaces;

namespace TPFinalTallerDeProgramacion.Controllers
{
    class SearchController
    {
        private readonly IUnitOfWork iUDT;

        public SearchController(IUnitOfWork pUnitOfWork)
        {
            iUDT = pUnitOfWork;
        }

        public void searchJuanAmador()
        {
            var mUrl = "https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/clients?id=12345678&pass=1234";

            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            try
            {
                WebResponse mResponse = mRequest.GetResponse();

                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                    if (mResponseJSON.Count >= 1)
                    {
                        System.Console.WriteLine("Item completo -> {0}", mResponseJSON[0].response);
                        System.Console.WriteLine("Nombre -> {0}", mResponseJSON[0].response.client.name);
                        System.Console.WriteLine("Segmento -> {0}", mResponseJSON[0].response.client.segment);
                    }
                    else
                    {
                        System.Console.WriteLine("No se devolvieron datos");
                    }
                }
            }
            catch (WebException ex)
            {
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    String mErrorText = mReader.ReadToEnd();

                    System.Console.WriteLine("Error: {0}", mErrorText);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: {0}", ex.Message);
            }

            System.Console.ReadLine();
        }

        public void searchProducts(int pDNI) 
        {
            var mUrl = "https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/products?id="+pDNI;

            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            try
            {
                WebResponse mResponse = mRequest.GetResponse();

                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                    if (mResponseJSON.Count >= 1)
                    {
                        System.Console.WriteLine("Item completo -> {0}", mResponseJSON[0].response);
                        System.Console.WriteLine("Products -> {0}", mResponseJSON[0].response.product);
                    }
                    else
                    {
                        System.Console.WriteLine("No se devolvieron datos");
                    }
                }
            }
            catch (WebException ex)
            {
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    String mErrorText = mReader.ReadToEnd();

                    System.Console.WriteLine("Error: {0}", mErrorText);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: {0}", ex.Message);
            }

            System.Console.ReadLine();
        }

        public void getBalance(int pDNI)
        {
            var mUrl = "https://my-json-server.typicode.com/utn-frcu-isi-tdp/tas-db/account-balance?id="+pDNI;

            HttpWebRequest mRequest = (HttpWebRequest)WebRequest.Create(mUrl);

            try
            {
                WebResponse mResponse = mRequest.GetResponse();

                using (Stream responseStream = mResponse.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(responseStream, Encoding.UTF8);

                    dynamic mResponseJSON = JsonConvert.DeserializeObject(reader.ReadToEnd());

                    if (mResponseJSON.Count >= 1)
                    {
                        System.Console.WriteLine("Item completo -> {0}", mResponseJSON[0].response);
                        System.Console.WriteLine("Balance -> {0}", mResponseJSON[0].response.balance);
                    }
                    else
                    {
                        System.Console.WriteLine("No se devolvieron datos");
                    }
                }
            }
            catch (WebException ex)
            {
                WebResponse mErrorResponse = ex.Response;
                using (Stream mResponseStream = mErrorResponse.GetResponseStream())
                {
                    StreamReader mReader = new StreamReader(mResponseStream, Encoding.GetEncoding("utf-8"));
                    String mErrorText = mReader.ReadToEnd();

                    System.Console.WriteLine("Error: {0}", mErrorText);
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Error: {0}", ex.Message);
            }

            System.Console.ReadLine();
        }
    }
}
