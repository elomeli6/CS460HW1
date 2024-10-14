using System.Diagnostics;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using TeamBuilder.Models;

namespace TeamBuilder.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
     [HttpGet]
    public IActionResult TeamForm()
    {
        return View();
    }
    


    [HttpPost]
    public ViewResult TeamForm(MemberNames memberName)
    {
        if(ModelState.IsValid){
        Repository.AddResponse(memberName);
        return View("Thanks", memberName);
        }
        else
        {
            return View();
        }
    }

    [HttpPost]
    public IActionResult SubmitNames (MemberNames members){
        
        if(ModelState.IsValid){
            var teamsSize = members.TeamSize; //need to hold current team size since we are going to format string names and pass formatted string names
            var namesArray = members.Name.Split('\n', StringSplitOptions.RemoveEmptyEntries).ToList(); //creates an array of strings and uses the Split method to split text and Split method to remove empty texts...
           //...Converted namesArray to List type so we can pass it the TeamMemebers List -- cant pass String type to List Type
           members.TeamMembers = namesArray;
          // Repository.AddResponse(members);

           return RedirectToAction("CreateTeams",members);
        }
        else{
            return View("TeamForm",members);
        }

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    public ViewResult ListTeamMembers(MemberNames members){
        return View(members.Name);
    }

    public IActionResult CreateTeams (MemberNames members){
       // if(ModelState.IsValid){

            int totalTeams = members.TeamSize;
            int totalMembers = members.TeamMembers.Count();
            int baseSize = totalMembers / totalTeams;
            int remainder = totalMembers % totalTeams;
            int teamSize = 0;
            int memberIndex = 0;
            
            List<List<string>> teams = new List<List<string>>();

            for(int i = 0; i < totalTeams; i++){
                if (i < remainder){
                    teamSize = baseSize + 1;
                }
                else{
                    teamSize = baseSize;
                }
                List<string> team = new List<string>();
                for (int j = 0; j < teamSize; j++){
                    team.Add(members.TeamMembers[memberIndex]);
                    memberIndex++;
                }
                teams.Add(team);
            }
        return View("CreateTeams",teams);
       // }
       // else{
         //   return View();
       // }
    }

    [HttpGet]
    public IActionResult GetTeamNames(){
         List<string> names = new List<string> ();
        using StreamReader reader = new("TSwift.txt");  // This is the textfile that we are going to read
        string line = reader.ReadLine();

        while(line != null){
            names.Add(line);
            line = reader.ReadLine();
        }
        return Json(names);
    }
}
