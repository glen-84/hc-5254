using HotChocolate.Language;

namespace Types;

public class AddClassAInputType : InputObjectType<ClassA>
{
    protected override void Configure(IInputObjectTypeDescriptor<ClassA> descriptor)
    {
        descriptor
            .Field(f => f.ClassBs)
            .DefaultValue(new ListValueNode());
    }
}