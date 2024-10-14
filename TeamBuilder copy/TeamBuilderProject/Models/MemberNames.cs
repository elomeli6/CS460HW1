//This model will be used to hold the list of team member names and their desired team size
//Added validations to names and team size!
using System.ComponentModel.DataAnnotations;

namespace TeamBuilder.Models;
public class MemberNames 
{
    [Required(ErrorMessage = "Please enter names")]
    [RegularExpression(@"^[a-zA-Z\s\s,.-_']+$", ErrorMessage = "Names can only contain letters, spaces, and the characters: ,.-_'")]
    public string Name { get; set;}
    
    [Required(ErrorMessage = "Please select a team size")]
    [Range(2, 10, ErrorMessage = "Please select a team size between 2 and 10 ONLY")]
    public int TeamSize { get; set; }

    public List<string> TeamMembers {get; set;} = new List<string> ();
    
   // public int totalMembers = TeamMembers.Count();


}