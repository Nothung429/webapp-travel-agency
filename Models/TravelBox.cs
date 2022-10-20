using System.ComponentModel.DataAnnotations;
using webapp_travel_agency.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

public class TravelBox
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Image { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public int? Price { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Description { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public int? TravelDays { get; set; }

    public TravelBox()
    {

    }
}