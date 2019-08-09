using System;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace PhentrixGames.NewColonyAPI.Mods
{
    internal class VersionCheck
    {
        private static bool MyRemoteCertificateValidationCallback(System.Object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            bool isOk = true;

            if(errors != SslPolicyErrors.None)
            {
                for (int i = 0; i < chain.ChainStatus.Length; i++)
                {
                    if (chain.ChainStatus[i].Status == X509ChainStatusFlags.RevocationStatusUnknown)
                        continue;

                    chain.ChainPolicy.RevocationFlag = X509RevocationFlag.EntireChain;
                    chain.ChainPolicy.RevocationMode = X509RevocationMode.Online;
                    chain.ChainPolicy.UrlRetrievalTimeout = new TimeSpan(0, 0, 30);
                    chain.ChainPolicy.VerificationFlags = X509VerificationFlags.AllFlags;
                    bool chainIsValid = chain.Build((X509Certificate2)certificate);
                    if(chainIsValid == false)
                    {
                        isOk = false;
                        break;
                    }
                }
            }

            return isOk;
        }


        public static void RunVersionCheck(string modName, Version currentVersion, string versionURL)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
            ServicePointManager.ServerCertificateValidationCallback = MyRemoteCertificateValidationCallback;

            WebClient client = new WebClient();
            string latestVersion = client.DownloadString(versionURL);

            if(latestVersion.Length > 0)
            {
                Version latest = new Version(latestVersion);
                int result = currentVersion.CompareTo(latest);
                if(result > 0) //newer
                {
                    Helpers.Logging.VersionLog(modName, Helpers.Logging.LogVersionType.Newer, latest);
                }
                else if(result < 0) //out of date
                {
                    Helpers.Logging.VersionLog(modName, Helpers.Logging.LogVersionType.Outofdate, latest);
                }
                else //up to date
                {
                    Helpers.Logging.VersionLog(modName, Helpers.Logging.LogVersionType.Release);
                }

                return;
            }
        }

        public static string SinglePlayerVersionCheck(string modname, Version currentVersion, string versionURL)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Ssl3;
            ServicePointManager.ServerCertificateValidationCallback = MyRemoteCertificateValidationCallback;

            WebClient client = new WebClient();
            string latestVersion = client.DownloadString(versionURL);

            if (latestVersion.Length > 0)
            {
                Version latest = new Version(latestVersion);

                var result = currentVersion.CompareTo(latest);
                if (result > 0)
                {
                    // currenversion is greater
                    return "You are running a newer version than the public release of " + modname + " (latest public release: " + latestVersion.ToString() + ")";
                }
                else if (result < 0)
                {
                    // latestversion is greater
                    return modname + " is out of date. Latest version: " + latestVersion.ToString() + "!";
                }
                else
                {
                    // currenversion is greater
                    return modname + " is up to date.";
                }
            }
            return "";
        }
    }
}
