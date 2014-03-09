
using System.Threading.Tasks;
using MYOB.TaxMate.YodleeAPI.Model;
using MYOB.TaxMate.YodleeAPI.business;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;

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
            var credentials = new AuthenticationInfo { CobrandLogin = "sbCobsonny", CobrandPassword = "a7d775a5-ae0c-427f-8291-d290a7766c65" };

            var loginCall = new CobrandLogin();

            var res = await loginCall.Login(credentials);

            Assert.IsTrue(res.IsValid, "Incorrect credentials- See test 'CobrandLogin'");
        }
       
        [TestMethod]
        public async Task CobrandUserLogin()
        {
            var credentials = new AuthenticationInfo { CobrandLogin = "sbCobsonny", CobrandPassword = "a7d775a5-ae0c-427f-8291-d290a7766c65" };

            var loginCall = new CobrandLogin();

            var resLogin = await loginCall.Login(credentials);
           
            Assert.IsTrue(resLogin.IsValid, "Incorrect credentials- See test 'CobrandLogin'");

            var account = JObject.Parse(resLogin.Result);

            var userLogin = new CobrandUserLogin();

            var sessionId = account["cobrandConversationCredentials"]["sessionToken"].ToString();

            var userSpecificLogin = new UserAuthenticationInfo { CobrandLogin = "sbMemsonny1", CobrandPassword = "sbMemsonny1#123", CobSessionToken = sessionId};

            var res = await userLogin.Login(userSpecificLogin);

            Assert.IsTrue(res.IsValid, "Incorrect credentials- See test 'CobrandUserLogin'");
        }
    }
}
