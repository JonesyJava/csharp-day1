namespace day_1.Models
{

  public class User
  {
    public string Name { get; set; }
    public int Age { get; private set; }
    public bool IsAlive { get; set; }

    public void Birthday()
    {
      Age++;
    }

    public User(string name, int age)
    {
      Name = name;
      Age = age;
      IsAlive = true;
    }
  }

}