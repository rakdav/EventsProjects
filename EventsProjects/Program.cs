using EventsProjects;

List<Student> group = new List<Student>
{
    new Student
    {
        FirstName="Буренкин",
        LastName="Васька",
        BirthDate=new DateTime(2020,5,1)
    },
    new Student
    {
        FirstName="Андрюшкин",
        LastName="ОС",
        BirthDate=new DateTime(2023,2,1)
    }
};
Teacher teacher=new Teacher();
foreach(Student item in group)
{
    teacher.examEvent += item.Exam;
}
teacher.Exam("Physics");

Account account = new Account(100);
account.Notify += DisplayMessage;
//account.Notify-= DisplayMessage;
account.Put(20);
Console.WriteLine($"Сумма на счете: {account.Sum}");
account.Take(70);
Console.WriteLine($"Сумма на счете: {account.Sum}");
account.Take(180);
Console.WriteLine($"Сумма на счете: {account.Sum}");
void DisplayMessage(string message) => Console.WriteLine(message);
