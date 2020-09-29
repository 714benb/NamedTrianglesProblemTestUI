using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Threading.Tasks;
using GeometricLayouts.Models;

namespace NamedTrianglesProblemTestUI.Models
{
  public class TriangleModel
  {

    [Display(Name="Vertex 1")]
    public Vertex V1 { get; set; }
    [Display(Name="Vertex 2")]
    public Vertex V2 { get; set; }
    [Display(Name="Vertex 3")]
    public Vertex V3 { get; set; }

    [Display(Name="Name")]
    public string Name { get; set; }
  }
}
