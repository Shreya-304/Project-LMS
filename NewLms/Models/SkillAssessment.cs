namespace NewLms.ViewModels
{
    public class SkillAssessmentViewModel
    {
        // Ratings
        public Dictionary<string, int> Ratings { get; set; }

        // Technical Skills
        public Dictionary<string, bool> TechnicalSkills { get; set; }

        // Soft Skills
        public Dictionary<string, bool> SoftSkills { get; set; }
    }
}
