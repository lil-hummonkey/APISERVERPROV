using APISERVERPROV;

public class StudentCollection
{
    List<Students> students = new(){
        new() {Name = "Hampus", SemenInCC = 2},
        new() {Name = "Yuriy", SemenInCC = 1232874212},
        new() {Name = "Neo", SemenInCC = 12130}  
    };

    public IResult GetStudent(int number){
    Console.WriteLine("hej");

    if (number < 0 || number >= students.Count)
    {
        return Results.NotFound();
    }
    return Results.Ok(students[number]);
    }
}
