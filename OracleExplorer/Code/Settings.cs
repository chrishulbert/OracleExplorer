using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;

namespace OracleExplorer.Code
{
  class Settings
  {
    /// <summary>
    /// The path to the settings file
    /// </summary>
    public string SettingsFilePath
    {
      get
      {
        return SettingsFolder + "/OracleExplorerSettings.xml";
      }
    }

    /// <summary>
    /// The folder that the settings file is in (no trailing slash)
    /// </summary>
    public string SettingsFolder
    {
      get
      {
        return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/OracleExplorer";
      }
    }

    public XmlDocument xmldoc;
    public XmlElement root;

    /// <summary>
    /// This gets and returns the list of database connections from the xml
    /// </summary>
    public List<Connection> Connections
    {
      get
      {
        // Find the old list
        List<Connection> conns = new List<Connection>();
        foreach (XmlNode n in root.ChildNodes)
        {
          if (n.Name == "Connections")
          {
            foreach (XmlNode xc in n.ChildNodes)
            {
              if (xc is XmlElement && xc.Name == "Connection")
              {
                Connection c = new Connection();
                c.Name = xc.Attributes["Name"].Value;
                c.User = xc.Attributes["User"].Value;
                c.Pass = xc.Attributes["Pass"].Value;
                c.Host = xc.Attributes["Host"].Value;
                c.Port = xc.Attributes["Port"]==null ? "1521" : xc.Attributes["Port"].Value;
                c.Sid = xc.Attributes["Sid"]==null ? "" : xc.Attributes["Sid"].Value;
                c.Service = xc.Attributes["Service"] == null ? "" : xc.Attributes["Service"].Value;
                conns.Add(c);
              }
            }
          }
        }
        return conns;
      }
      set
      {
        // Find and remove the old list
        foreach (XmlNode n in root.ChildNodes) if (n.Name == "Connections") root.RemoveChild(n);
        XmlElement xconns = xmldoc.CreateElement("Connections");
        root.AppendChild(xconns);

        foreach (Connection c in value)
        {
          XmlElement xc = xmldoc.CreateElement("Connection");
          XmlAttribute xe;

          xe = xmldoc.CreateAttribute("Name");
          xe.Value = c.Name;
          xc.Attributes.Append(xe);

          xe = xmldoc.CreateAttribute("User");
          xe.Value = c.User;
          xc.Attributes.Append(xe);

          xe = xmldoc.CreateAttribute("Pass");
          xe.Value = c.Pass;
          xc.Attributes.Append(xe);

          xe = xmldoc.CreateAttribute("Host");
          xe.Value = c.Host;
          xc.Attributes.Append(xe);

          xe = xmldoc.CreateAttribute("Port");
          xe.Value = c.Port;
          xc.Attributes.Append(xe);

          xe = xmldoc.CreateAttribute("Sid");
          xe.Value = c.Sid;
          xc.Attributes.Append(xe);

          xe = xmldoc.CreateAttribute("Service");
          xe.Value = c.Service;
          xc.Attributes.Append(xe);

          xconns.AppendChild(xc);
        }
      }
    }

    /// <summary>
    /// Loads the settings from disk
    /// </summary>
    public void Load()
    {
      xmldoc = new XmlDocument();
      if (File.Exists(SettingsFilePath))
      {
        xmldoc.Load(SettingsFilePath);

        // find the root node
        foreach (XmlNode n in xmldoc.ChildNodes)
          if (n is XmlElement && n.Name == "OracleExplorerSettings") root = (XmlElement)n;

        // is it missing? If so, create it
        if (root == null)
        {
          root = xmldoc.CreateElement("OracleExplorerSettings");
          xmldoc.AppendChild(root);
        }
      }
      else
      {
        // http://www.java2s.com/Code/CSharp/XML/ProgrammaticallycreatinganewXMLdocument.htm
        xmldoc.AppendChild(xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null));

        // This is the root element that everything must be joined to
        root = xmldoc.CreateElement("OracleExplorerSettings");
        xmldoc.AppendChild(root);
      }
    }

    public void Save()
    {
      if (!Directory.Exists(SettingsFolder)) Directory.CreateDirectory(SettingsFolder);
      xmldoc.Save(SettingsFilePath);
    }
  }
}
