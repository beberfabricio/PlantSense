namespace Domain.Entities;

public class HealthAssesment
{
    public int Id { get; set; }
    public int PlantId { get; set; }
    public virtual Plant Plant { get; set; } = null!;
    public string PlantImage { get; set; } = string.Empty;
    public bool IsHealthy { get; set; }
    public decimal IsHealthyProbability { get; set; }
    public string Disease { get; set; } = string.Empty;
    public decimal DiseaseProbability { get; set; }
    public string DiseaseDescription { get; set; } = string.Empty;
    public string DiseaseCommonNames { get; set; } = string.Empty;
    public int UserId { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
}
