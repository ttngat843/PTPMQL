public class BMIModel
{
    public double Weight { get; set; } 
    public double Height { get; set; } 
    public double BMI => Weight / (Height * Height); 
}