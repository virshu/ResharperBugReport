using System.ComponentModel.DataAnnotations;

namespace DataAoLookupHandler.Models;

public class Lookup
{
    public int LookupIndex { get; set; }   
    public LookupConstants LookupInterfaceId { get; set; }
    [StringLength(600)]
    public string LookupDescription { get; set; }

}