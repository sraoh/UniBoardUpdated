//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniEBoard.Repository
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student : User
    {
        public Student()
        {
            this.CourseRegistrations = new HashSet<CourseRegistration>();
            this.QuizEntries = new HashSet<QuizEntry>();
            this.Submissions = new HashSet<Submission>();
        }
    
        public string StudentNumber { get; set; }
    
        public virtual ICollection<CourseRegistration> CourseRegistrations { get; set; }
        public virtual ICollection<QuizEntry> QuizEntries { get; set; }
        public virtual ICollection<Submission> Submissions { get; set; }
    }
}
