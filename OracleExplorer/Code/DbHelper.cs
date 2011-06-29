using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OracleExplorer.Code
{
  class DbHelper
  {
    /// <summary>
    /// This function checks that the oracle driver files are present
    /// </summary>
    public bool OracleFilesPresent()
    {
      return
        File.Exists("oci.dll") &&
        Directory.GetFiles(".","orannzsbb*.dll").Length > 0 &&
        Directory.GetFiles(".", "oraocci*.dll").Length > 0 &&
        Directory.GetFiles(".", "oraociicus*.dll").Length > 0;
    }

    /// <summary>
    /// Sanitise a string for sql by replacing ' with ''
    /// </summary>
    public static string Sanitise(string str)
    {
      return str.Replace("'", "''");
    }
  }
}
