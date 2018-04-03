using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestBasicProject.Authenticators
{
    class OAuth1AccessToken  : XAuthentication
    {
        /// <summary>
        /// This is BasicAuthentication constructor initializes authcontext
        /// </summary>
        public OAuth1AccessToken(AuthContext authContext) : base(authContext)
        {

        }

        /// <summary>
        /// This is Authenticate method which authenticate URL by passing key and secret
        /// </summary>
        /// <param name="client">client</param>
        /// <param name="request">request</param>
        /// <returns>Auth header if authentication gets passed</returns>
        public override void Authenticate(IRestClient client, IRestRequest request)
        {

            request.AddParameter("consumerKey", ((OAuth1Context)authContext).GetConsumerKey());
            request.AddParameter("consumerSecret", ((OAuth1Context)authContext).GetConsumerSecret());
            request.AddParameter("outhToken", ((OAuth1Context)authContext).GetOauthToken());
            request.AddParameter("outhTokenSecret", ((OAuth1Context)authContext).GetOauthTokenSecret());
            request.AddParameter("outhTokenVerifier", ((OAuth1Context)authContext).GetOauthTokenVerifier());

            // client.Authenticator = OAuth1Authenticator.ForProtectedResource(((OAuth1Context)authContext).GetConsumerKey(), ((OAuth1Context)authContext).GetConsumerKey()
            //   , ((OAuth1Context)authContext).GetoauthToken(), ((OAuth1Context)authContext).GetoauthTokenSecret());
            client.Authenticator = OAuth1Authenticator.ForAccessToken(((OAuth1Context)authContext).GetConsumerKey(), ((OAuth1Context)authContext).GetConsumerSecret()
               , ((OAuth1Context)authContext).GetOauthToken(), ((OAuth1Context)authContext).GetOauthTokenSecret(), ((OAuth1Context)authContext).GetOauthTokenVerifier());

        }

    }
}
