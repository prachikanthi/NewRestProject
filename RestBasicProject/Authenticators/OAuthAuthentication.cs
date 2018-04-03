using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestBasicProject.Authenticators
{
        /// <summary>
        /// This is BasicAuthentication Class inherits XAuthentication
        /// </summary>
        public class OAuthAuthentication : XAuthentication
        {
            /// <summary>
            /// This is BasicAuthentication constructor initializes authcontext
            /// </summary>
            public OAuthAuthentication(AuthContext authContext) : base(authContext)
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

               client.Authenticator = OAuth1Authenticator.ForRequestToken(((OAuth1Context)authContext).GetConsumerKey(), ((OAuth1Context)authContext).GetConsumerSecret());
            }
        
        }
    }


