// <auto-generated>

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Invoicetronic.Sdk.Client
{
    /// <summary>
    /// A token constructed from a username and password.
    /// </summary>
    public class BasicToken : TokenBase
    {
        private string _username;

        private string _password;

        /// <summary>
        /// Constructs a BasicToken object.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="timeout"></param>
        public BasicToken(string username, string password, TimeSpan? timeout = null) : base(timeout)
        {
            _username = username;

            _password = password;
        }

        /// <summary>
        /// Places the token in the header.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="headerName"></param>
        public virtual void UseInHeader(global::System.Net.Http.HttpRequestMessage request, string headerName)
        {
            request.Headers.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Basic", Invoicetronic.Sdk.Client.ClientUtils.Base64Encode(_username + ":" + _password));
        }
    }
}