using System;
using System.Xml;
using System.Net;

namespace AutoUpdater
{
    public class AutoUpdaterXML
    {
        private Version version;
        private Uri uri;
        private string fileName;
        private string md5;
        private string description;
        private string launchArgs;

        /// <summary>
        /// Update Version
        /// </summary>
        internal Version Version
        {
            get{ return this.version; }
        }
        /// <summary>
        /// Location of the update binary
        /// </summary>
        internal Uri Uri {
            get{ return this.uri; }
        }
        /// <summary>
        /// the file name of the binary
        /// for use on local computer
        /// </summary>
        internal string FileName {
            get { return this.fileName; }
        }
        /// <summary>
        /// the MD5 of the update's binary
        /// </summary>
        internal string MD5 {
            get { return this.md5; }
         }
        /// <summary>
        /// the update description
        /// </summary>
        internal string Description {
            get { return this.description; }
         }
        /// <summary>
        /// the arguments to pass to the update application on startup
        /// </summary>
        internal string LaunchArgs {
            get { return this.launchArgs; }
         }
        /// <summary>
        /// creata a new AutoUpdaterXML object
        /// </summary>
        /// <param name="version"></param>
        /// <param name="uri"></param>
        /// <param name="fileName"></param>
        /// <param name="md5"></param>
        /// <param name="description"></param>
        /// <param name="launchArgs"></param>
        internal AutoUpdaterXML(Version version, Uri uri, String fileName, String md5, String description, String launchArgs)
        {
            this.version = version;
            this.uri = uri;
            this.fileName = fileName;
            this.md5 = md5;
            this.description = description;
            this.launchArgs = launchArgs;
        }
        /// <summary>
        /// check if update's version is newer than the old version
        /// </summary>
        /// <param name="version">Application current Version</param>
        /// <returns>if the update's version is newer</returns>
        internal bool IsNewThan(Version version)
        {
            return this.version > version;
        }
        /// <summary>
        /// Check the uri to make sure file exist
        /// </summary>
        /// <param name="location">the uri of the update.xml</param>
        /// <returns>if the file exists</returns>
        internal static bool ExistsOnServer(Uri location)
        {
            try
            {
                HttpWebRequest req = (HttpWebRequest)WebRequest.Create(location.AbsoluteUri);
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                resp.Close();

                return resp.StatusCode == HttpStatusCode.OK; ///< neues Update vorhanden
            }
            catch { return false; }
        }
        /// <summary>
        /// Parses the update.xml into AutoUpdateXML object
        /// </summary>
        /// <param name="location">Uri of update.xml on server</param>
        /// <param name="appID">The Applications ID</param>
        /// <returns>The AutoUpdaterXML object with the data, or null of any errors</returns>
        internal static AutoUpdaterXML Parse(Uri location, string appID)
        {
            Version version = null;
            string url = "", fileName = "", md5 = "", description = "", launchArgs = "";

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(location.AbsoluteUri);

                XmlNode node = doc.DocumentElement.SelectSingleNode("//update[@appId='" + appID + "']");

                if (node == null)
                    return null;

                version = Version.Parse(node["version"].InnerText);
                url = node["url"].InnerText;
                fileName = node["fileName"].InnerText;
                md5 = node["md5"].InnerText;
                description = node["Description"].InnerText;
                launchArgs = node["launchArgs"].InnerText;

                return new AutoUpdaterXML(version, new Uri(url), fileName, md5, description, launchArgs);
            }
            catch{ return null; }
        }
    }
}
