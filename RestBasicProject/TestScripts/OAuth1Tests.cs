using NUnit.Framework;
using RestBasicProject.Authenticators;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Xml.Serialization;

namespace RestBasicProject.TestScripts
{
    [TestFixture]
    class OAuth1Tests : BaseClass
    {
        [XmlRoot("queue")]
        private class Queue
        {
            [XmlElement("etag")]
            public string Etag { get; set; }

            public List<QueueItem> Items { get; set; }
        }

        [XmlRoot("queue_item")]
        private class QueueItem
        {
            [XmlElement("id")]
            public string Id { get; set; }

            [XmlElement("position")]
            public int Position { get; set; }
        }
        [Test]
        public void Can_Authenticate_Netflix_With_OAuth()
        {
            const string consumerKey = "L7gdVVLFZ24LkQlPXxPk3WBjd";
            const string consumerSecret = "t0q0QWPAquKblDoRFoI9VmzH8DGrRNtGrdXPbrYfsE1WolVqBP";

            AuthContext context = new OAuth1Context(consumerKey, consumerSecret);
            XAuthentication xas = new OAuthAuthentication(context);

            var request = new RestRequest("oauth/request_token", Method.POST);
           
            xas.Authenticate(client, request);
            var response = client.Execute(request);

            Assert.NotNull(response);
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
           
            // For Access Token >
            var qs = HttpUtility.ParseQueryString(response.Content);
            var oauthToken = qs["oauth_token"];
            var oauthTokenSecret = qs["oauth_token_secret"];

            request = new RestRequest("oauth/authorize");
            request.AddParameter("oauth_token", oauthToken);
            request.AddParameter("user_name", "prachijadhav59@gmail.com");
            request.AddParameter("password", "twitprachi");
            request.AddParameter("grant_type", "password");

            var url = client.BuildUri(request)
                .ToString();

            Process.Start(url);
                
            const string requestUrl = "https://www.prachi.com/?oauth_token=g6o8mAAAAAAA46YAAAABYhuA2DU&oauth_verifier=ZUSV9exrCch0jTOQYxWmszh6aLYyaveo";

            // get the access token
             string e = "https://www.prachi.com/?oauth_token=yu489AAAAAAA46YAAAABYifW0Ac&oauth_verifier=rNZFFL25DHvxmo0qmijN2mKf4SNaszJc";
            var requestTokenQueryParameters = HttpUtility.ParseQueryString(new Uri(e).Query);
            var requestVerifier = requestTokenQueryParameters["oauth_verifier"];

           
            client.Authenticator = OAuth1Authenticator.ForAccessToken(consumerKey, consumerSecret, oauthToken,
                oauthTokenSecret, requestVerifier);

            context = new OAuth1Context(consumerKey, consumerSecret, oauthToken,oauthTokenSecret, requestVerifier);
            xas = new OAuthAuthentication(context);

            request = new RestRequest("oauth/access_token", Method.POST);

            xas.Authenticate(client, request);
            response = client.Execute(request);

            Assert.NotNull(oauthToken);
            Assert.NotNull(oauthTokenSecret);
        }
      
    }
}
