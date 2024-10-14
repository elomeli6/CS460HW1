//This model will hold the names of the teams

using System.ComponentModel.DataAnnotations;
namespace TeamBuilder.Models;

public static class Repository {
    private static List<MemberNames> names => new ();

    public static IEnumerable<MemberNames> Names => names; //returns private names list
    public static void AddResponse (MemberNames name){
        Console.WriteLine(name);
        names.Add(name);
    }

}
