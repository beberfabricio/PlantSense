namespace Domain.Dtos.PlantRisks;
public class RiskDto
{
    public DateTime Day { get; set; }
    public string Risk { get; set; } = string.Empty;
    public string Level { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
}