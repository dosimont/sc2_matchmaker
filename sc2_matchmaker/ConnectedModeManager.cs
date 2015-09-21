using Octokit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sc2_matchmaker
{
    class ConnectedModeManager
    {
        String clientId = "some-id-here";
        String clientSecret = "some-id-here";
        GitHubClient client;
        Credentials tokenAuth;
        User user;
        string token;

        public ConnectedModeManager(string token)
        {
            this.token = token;   
        }

        async
        public void Connect()
        {
            client = new GitHubClient(new ProductHeaderValue("SC 2 Matchmaker"));
            tokenAuth = new Credentials(token); // NOTE: not real token
            client.Credentials = tokenAuth;
            User user = await client.User.Get("shiftkey");
        }

        
    }
}
