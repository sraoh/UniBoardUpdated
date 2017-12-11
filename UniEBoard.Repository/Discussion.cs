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
    
    public partial class Discussion
    {
        public Discussion()
        {
            this.BaseQuestionTopics_Topic = new HashSet<Topic>();
        }
    
        public Nullable<int> SortOrder { get; set; }
        public bool IsPostModerated { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string Description { get; set; }
        public Nullable<int> CourseId { get; set; }
        public Nullable<int> LatestPostId { get; set; }
        public Nullable<int> ParentDiscussionId { get; set; }
    
        public virtual ICollection<Topic> BaseQuestionTopics_Topic { get; set; }
        public virtual Course Cours { get; set; }
        public virtual TopicPost TopicPost { get; set; }
    }
}