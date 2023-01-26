using System;
namespace Learning04
{
    public class WriteAssignment : Assignment
    {
        private string _title = "";

        public WriteAssignment(string studentName, string topic, string title) : base(studentName, topic)
        {
            _title = title;
        }

        // public string GetSection()
        // {
        //     return _title;
        // }
        // public void SetSection(title)
        // {
        //     _title = title;
        // }

        public string GetWritingInformation()
        {
            // string studentName = GetName();
            return $"{_title} by {GetName()}";
        }
    }
}