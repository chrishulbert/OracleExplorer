using System;
using System.Collections.Generic;
using System.Text;

namespace OracleExplorer.Code
{
  public class Table
  {
    public string Name;
    public bool View=false;
    public Schema ParentSchema;

    public Table(Schema Parent)
    {
      ParentSchema = Parent;
    }
  }
}
