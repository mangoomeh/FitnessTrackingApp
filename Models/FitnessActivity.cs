using System.ComponentModel.DataAnnotations;

namespace SportsTrackingApp.Models;

public class FitnessActivity
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    [Display(Name = "Activity Type")]
    public string Type { get; set; } = "Others";

    [Display(Name = "Duration (Minutes)")]
    public int DurationMinutes { get; set; }
}