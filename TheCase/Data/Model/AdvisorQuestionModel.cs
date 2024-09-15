namespace TheCase.Data.Model;

public class AdvisorQuestionModel
{
    public int AdvisorQuestionId { get; set; }

    public string AdvisorQuestionContent { get; set; }

    public AdvisorAnswerModel AdvisorAnswer { get; set; }
}