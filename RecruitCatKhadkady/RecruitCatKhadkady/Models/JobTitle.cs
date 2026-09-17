namespace RecruitCatKhadkady.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public decimal MinimumSalary { get; set; }

        public decimal MaximumSalary { get; set; }

        public bool IsRemoteEligible { get; set; }
    }
}