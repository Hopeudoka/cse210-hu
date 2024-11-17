namespace Learning02
{
    // second class called "resume"
    public class Resume
    {
        public string _name = "";
        public List<Job> _jobList = new List<Job>();  

        // declare function or method
        public void DisplayResume()
        {
            Console.WriteLine($"{_name}");
            foreach (Job job in _jobList)
            {
                job.DisplayJobInfo();
            }
        }
    }
}