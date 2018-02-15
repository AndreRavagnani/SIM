using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using Newtonsoft.Json;

/// <summary>
/// Descrição resumida de ClinicaSIM
/// </summary>

public class Specialty
{
    public int id { get; set; }
    public string name { get; set; }
    public object comments { get; set; }
    public string category_name { get; set; }
    public int category_id { get; set; }
}
public class SpecialtiesByClass
{
    public double id { get; set; }
    public string name { get; set; }
    public List<Specialty> specialties { get; set; }
}
public class RootObject
{
    public List<SpecialtiesByClass> specialtiesByClass { get; set; }
}