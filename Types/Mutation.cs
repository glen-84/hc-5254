namespace Types;

public class Mutation
{
    public async Task<ClassA> AddClassAAsync(
        ClassA input,
        /* [Service] ClassARepository classARepository, */
        CancellationToken token)
    {
        return await Task.FromResult(new ClassA());

        //return await classARepository.AddAsync(input, token);
    }
}