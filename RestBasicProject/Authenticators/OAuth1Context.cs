using System;

namespace RestBasicProject.Authenticators
{
    /// <summary>
    /// This is OAuth1Context Class to get credentials and also inherit AuthContext class
    /// </summary>
    public class OAuth1Context : AuthContext
    {
        private string consumerKey;
        private string consumerSecret;
        private string oauthToken;
        private string oauthTokenSecret;
        private string oauthVerifier;
        
        /// <summary>
        /// This is OAuth1Context constructor to get credentials
        /// </summary>
        /// <param name="consumerSecret">consumer Secret</param>
        /// <param name="consumerKey">consumer Key</param>
        public OAuth1Context(string consumerKey, string consumerSecret)
        {
            this.consumerKey = consumerKey;
            this.consumerSecret = consumerSecret;
        }

        /// <summary>
        /// This is OAuth1Context constructor to get credentials
        /// </summary>
        /// <param name="consumerSecret">consumer Secret</param>
        /// <param name="consumerKey">consumer Key</param>
        ///  <param name="requestToken">requestToken</param>
        ///  <param name="requestSecret">requestSecret</param>
        ///   <param name="requestVerifier">requestVerifier</param>
        public OAuth1Context(string consumerKey, string consumerSecret,string requestToken, string requestSecret, string requestVerifier)
        {
            this.consumerKey = consumerKey;
            this.consumerSecret = consumerSecret;
            this.oauthToken = requestToken;
            this.oauthTokenSecret = requestSecret;
            this.oauthVerifier = requestVerifier;
        }
        /// <summary>
        /// This is OAuth1Context constructor to get credentials
        /// </summary>
        /// <param name="consumerSecret">consumer Secret</param>
        /// <param name="consumerKey">consumer Key</param>
        ///  <param name="oauthToken">oauthToken</param>
        ///   <param name="oauthTokenSecret">oauthTokenSecret</param>
        public OAuth1Context(string consumerKey, string consumerSecret, string oauthToken, string oauthTokenSecret)
        {
            this.consumerKey = consumerKey;
            this.consumerSecret = consumerSecret;
            this.oauthToken = oauthToken;
            this.oauthTokenSecret = oauthTokenSecret;
        }

        /// <summary>
        /// This method Class to get consumerKey
        /// </summary>
        public string GetConsumerKey()
        {
            return consumerKey;
        }

        /// <summary>
        /// This method Class to get consumerSecret
        /// </summary>
        public string GetConsumerSecret()
        {
            return consumerSecret;
        }

        /// <summary>
        /// This method Class to get oauthToken
        /// </summary>
        public string GetOauthToken()
        {
            return oauthToken;
        }

        /// <summary>
        /// This method Class to get oauthTokenSecret
        /// </summary>
        public string GetOauthTokenSecret()
        {
            return oauthTokenSecret;
        }

        /// <summary>
        /// This method Class to get oauthVerifier
        /// </summary>
        public string GetOauthTokenVerifier()
        {
            return oauthVerifier;
        }
    }

}

