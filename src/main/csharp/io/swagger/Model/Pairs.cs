using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace io.swagger.Model {
  public class Pairs {
    

    /* Category name */
    
    public string Name { get; set; }

    

    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Pairs {\n");
      
      sb.Append("  Name: ").Append(Name).Append("\n");
      
      sb.Append("}\n");
      return sb.ToString();
    }
  }
  
  
}