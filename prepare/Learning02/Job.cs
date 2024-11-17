namespace Learning02
{
    // first class called "Job"
    public class Job
    {
        // declare variables or attributes
        public string _company = "";
        public string _jobTitle = "";
        public int _startYear = 0;
        public int _endYear = 0;

        // declare function or methods
        public void DisplayJobInfo()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
}