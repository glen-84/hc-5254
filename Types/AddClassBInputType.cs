using HotChocolate.Language;

namespace Types;

public class AddClassBInputType : InputObjectType<ClassB>
{
    protected override void Configure(IInputObjectTypeDescriptor<ClassB> descriptor)
    {
        descriptor
            .Field(f => f.ClassAs)
            .DefaultValue(new ListValueNode());
    }
}