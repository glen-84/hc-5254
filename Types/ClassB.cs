namespace Types;

public class ClassB
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;

    public virtual ICollection<ClassA> ClassAs { get; set; } = new HashSet<ClassA>();
}