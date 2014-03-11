
using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;
using MYOB.TaxMate.YodleeAPI.business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;


namespace YodleeTest
{
    /// TODO:Push out to TypeMock(BDD), as unit test are currently too coupled!
    /// Start adding String type form josn results!
    /// Break up unit test

    [TestClass]
    public class AuthenticateTests
    {
        [TestMethod]
        public async Task CobrandLogin()
        {
            var loginCall = new CobrandLogin();

            var credentials = new AuthenticationInfo
                                  {
                                      CobrandLogin = "sbCobsonny",
                                      CobrandPassword = "a7d775a5-ae0c-427f-8291-d290a7766c65"
                                  };
            
            var res = await loginCall.Login(credentials);

            Assert.IsTrue(res.IsValid, "Incorrect credentials- See test 'CobrandLogin'");

            var response = JsonConvert.DeserializeObject<ResponseCobrandLogin>(res.Result);
            Assert.IsNull(response, "No response");
        }

        [TestMethod]
        public async Task CobrandUserLogin()
        {
            var loginCall = new CobrandLogin();
            var userLogin = new CobrandUserLogin();
            var credentials = new AuthenticationInfo
                                  {
                                      CobrandLogin = "sbCobsonny",
                                      CobrandPassword = "a7d775a5-ae0c-427f-8291-d290a7766c65"
                                  };

            var resLogin = await loginCall.Login(credentials);

            Assert.IsTrue(resLogin.IsValid, "Incorrect credentials- See test 'CobrandLogin'");

            var account = JsonConvert.DeserializeObject<ResponseCobrandLogin>(resLogin.Result);
            Assert.IsNull(account, "No response");

            var sessionId = account.CobrandConversationCredentials.SessionToken;

            var userSpecificLogin = new UserAuthenticationInfo
                                        {
                                            CobrandLogin = "sbMemsonny1",
                                            CobrandPassword = "sbMemsonny1#123",
                                            CobSessionToken = sessionId
                                        };

            var res = await userLogin.Login(userSpecificLogin);
            Assert.IsTrue(res.IsValid, "Incorrect credentials- See test 'CobrandUserLogin'");

            var response = JsonConvert.DeserializeObject<ResponseUserLogin>(res.Result);
            Assert.IsNull(response, "No response");
        }

        [TestMethod]
        public async Task SearchSite()
        {
            var loginCall = new CobrandLogin();
            var userLogin = new CobrandUserLogin();

            var credentials = new AuthenticationInfo
                                  {
                                      CobrandLogin = "sbCobsonny",
                                      CobrandPassword = "a7d775a5-ae0c-427f-8291-d290a7766c65"
                                  };

            var resLogin = await loginCall.Login(credentials);

            Assert.IsTrue(resLogin.IsValid, "Incorrect credentials- See test 'CobrandLogin'");

            var account = JsonConvert.DeserializeObject<ResponseCobrandLogin>(resLogin.Result);
            Assert.IsNull(account, "invalid cast from json");

            var userSpecificLogin = new UserAuthenticationInfo
                                        {
                                            CobrandLogin = "sbMemsonny1",
                                            CobrandPassword = "sbMemsonny1#123",
                                            CobSessionToken = account.CobrandConversationCredentials.SessionToken
                                        };

            var res = await userLogin.Login(userSpecificLogin);

            Assert.IsTrue(res.IsValid, "Incorrect credentials- See test 'CobrandUserLogin'");

            var userAccount = JsonConvert.DeserializeObject<ResponseUserLogin>(res.Result);
            Assert.IsNull(userAccount, "invalid cast from json");

            var userSessionId = userAccount.UserContext.ConversationCredentials.SessionToken;

            var searchSite = new SearchSite();
            ///TODO: 1 create correct search term and get result set
            ///      2 Create POCCO from JSON result and transform.
            var searchSiteInfo = new SearchSiteInfo
                                     {
                                         SiteSearchString = "",
                                         UserSessionToken = userSessionId,
                                         CobSessionToken =
                                             account.CobrandConversationCredentials.SessionToken
                                     };

            var siteSearchRes = await searchSite.Login(searchSiteInfo);

            Assert.IsTrue(siteSearchRes.IsValid, "Incorrect credentials- See test 'CobrandUserLogin'");
        }

        [TestMethod]
        public async Task GetItemSummariesInfo()
        {
            var loginCall = new CobrandLogin();
            var getSum = new GetItemSummaries();
            var userLogin = new CobrandUserLogin();

            var credentials = new AuthenticationInfo
                                  {
                                      CobrandLogin = "sbCobsonny",
                                      CobrandPassword = "a7d775a5-ae0c-427f-8291-d290a7766c65"
                                  };

            var resLogin = await loginCall.Login(credentials);
            Assert.IsTrue(resLogin.IsValid, "Incorrect credentials- See test 'CobrandLogin'");

            var account = JsonConvert.DeserializeObject<ResponseCobrandLogin>(resLogin.Result);
            Assert.IsNull(account, "invalid cast from json");

            var userSpecificLogin = new UserAuthenticationInfo
                                        {
                                            CobrandLogin = "sbMemsonny3",
                                            CobrandPassword = "sbMemsonny3#123",
                                            CobSessionToken = account.CobrandConversationCredentials.SessionToken
                                        };

            var res = await userLogin.Login(userSpecificLogin);
            Assert.IsTrue(res.IsValid, "Incorrect credentials- See test 'CobrandUserLogin'");

            var userAccount = JsonConvert.DeserializeObject<ResponseUserLogin>(res.Result);
            Assert.IsNull(userAccount, "invalid cast from json");

            var summaries = new GetItemSummariesInfo
                                {
                                    CobSessionToken = account.CobrandConversationCredentials.SessionToken,
                                    UserSessionToken = userAccount.UserContext.ConversationCredentials.SessionToken
                                };

            var sums = await getSum.Login(summaries);
            Assert.IsTrue(sums.IsValid, "Incorrect credentials- See test 'CobrandUserLogin'");

            var summary = JsonConvert.DeserializeObject<RepsonseItemSummaries[]>(sums.Result);
            Assert.IsNull(summary,"invalid cast from json");
        }
    }
}
