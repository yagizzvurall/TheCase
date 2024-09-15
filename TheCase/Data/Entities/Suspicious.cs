using TheCase.Data.Model;

namespace TheCase.Data.Entities;

public class Suspicious
{
    public int SuspiciousId { get; set; }
    
    public string Name { get; set; }

    public string Surname { get; set; }

    public int LevelId { get; set; }

    public int Age { get; set; }

    public bool IsGuilty { get; set; }

    public string RelationDegree { get; set; }  
    
    public List<SuspiciousQuestionModel> Question { get; set; }
}