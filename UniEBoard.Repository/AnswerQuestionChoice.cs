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
    
    public partial class AnswerQuestionChoice
    {
        public int Id { get; set; }
        public int QuestionChoiceId { get; set; }
        public int AnswerId { get; set; }
    
        public virtual QuestionChoice QuestionChoice { get; set; }
        public virtual Answer Answer { get; set; }
    }
}