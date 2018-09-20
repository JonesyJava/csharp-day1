namespace day_1.Models
{

  public class User
  {
    public string Name { get; set; }
    private int Age { get; set; }

    public User(string name, int age)
    {
      Name = name;
      Age = age;

    }
  }

}