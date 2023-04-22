using System.ComponentModel.DataAnnotations;

namespace DataAoLookupHandler.Models;

public class Agency
{
    public int AgencyId { get; set; }
    [StringLength(150)]
    public string AgencyName { get; set; }
}