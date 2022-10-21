using System.ComponentModel.DataAnnotations;
using webapp_travel_agency.Models;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

public class Message
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Name { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Title { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? Text { get; set; }

    [Required(ErrorMessage = "Il campo è obbligatorio")]
    public string? EMail { get; set; }

    //ONE-TO-MANY
    public int? TravelBoxId { get; set; }
    public TravelBox? TravelBox { get; set; }

    public Message()
    {

    }
}