using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;
using RestSharp;

namespace MYOB.TaxMate.YodleeAPI.Business
{
    public abstract class BaseBusiness
    {

        #region Private Members

        /// Note: Not really happy with encapsulation of AppSettings, should be passed down by consuming code!
        private static readonly String BaseUrl = ConfigurationManager.AppSettings["serviceBaseUrl"];
        private readonly Dictionary<String, String> _parameters;

        #endregion

        #region Chain Constructors

        protected BaseBusiness()
            : this(String.Empty, Method.POST, new Dictionary<String, String>()){}

        protected BaseBusiness(String endPoint) : this(endPoint, Method.POST){}

        protected BaseBusiness(String endPoint, Method method)
            : this(endPoint, method, new Dictionary<String, String>()){}

        protected BaseBusiness(String endPoint, Method method, Dictionary<String, String> parameters)
        {
            EndPoint = endPoint;
            Method = method;
            _parameters = parameters;
        }

        #endregion

        #region Public Properties

        public Method Method { get; set; }

        public String EndPoint { get; set; }

        public Dictionary<String, String> Parameters
        {
            get { return _parameters; }
        }
        #endregion

        #region Protected Methods
        protected async Task<ServiceResult> Execute()
        {
            var request = new RestRequest(EndPoint, Method);

            foreach (var par in Parameters)
            {
                request.AddParameter(par.Key, par.Value);
            }

            var client = new RestClient(BaseUrl);

            var response = await client.ExecuteTaskAsync(request);

            //TODO: further logical error handling logic!
            if (response.StatusCode != HttpStatusCode.OK)
            {
                var res = new ServiceResult(String.Empty) {IsValid = false};
                return res;
            }

            return new ServiceResult(response.Content);
        }
        #endregion
    }
}