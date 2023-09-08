namespace CodeChallenge.Models
{
    public class ReportingStructure
    {
        public Employee employee { get; set; }

        public int numberOfReports { get; private set; }

        public ReportingStructure(Employee emp)
        {
            this.employee = emp;
            this.numberOfReports = CountReports(emp);
        }

        private int CountReports(Employee emp)
        {
            int count = 0;
            if (emp.DirectReports != null)
            {
                foreach (Employee e in emp.DirectReports)
                {
                    count++;
                    count += CountReports(e);
                }
            }
            return count;
        }
    }
}
