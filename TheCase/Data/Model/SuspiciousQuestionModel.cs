using TheCase.Data.Entities;

namespace TheCase.Data.Model;

public class SuspiciousQuestionModel
{
    public int SuspiciousQuestionId { get; set; }

    public string SuspiciousQuestionContent { get; set; }
    
    public SuspiciousAnswerModel SuspiciousAnswer { get; set; }
}