using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Drawing;
using System.Windows.Forms;

namespace AutoUpdater
{
    public interface IAutoUpdater
    {
        /// <summary>
        /// Name der Anwendung
        /// </summary>
        string ApplicationName { get; }
        /// <summary>
        /// ID der Anwendung
        /// </summary>
        string ApplicationID { get; }
        /// <summary>
        /// Versionsinformationen der Anwendung
        /// </summary>
        Assembly ApplicationAssembly { get; }
        /// <summary>
        /// Icon der Anwendung
        /// </summary>
        Icon ApplicationIcon { get; }
        /// <summary>
        /// Ort von wo die Updates heruntergeladen werden
        /// </summary>
        Uri UpdateXmlLocation { get; }  
        /// <summary>
        /// Der Context von einem Programm
        /// Windows Form Anwendungen benutzen, "this"
        /// </summary>
        Form Context { get; }
    }
}
