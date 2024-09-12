namespace Types;

public class ClassA
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;

    public virtual ICollection<ClassB> ClassBs { get; set; } = new HashSet<ClassB>();

}