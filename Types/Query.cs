﻿namespace hc_5254.Types;

[QueryType]
public static class Query
{
    public static Book GetBook()
        => new Book("C# in depth.", new Author("Jon Skeet"));
}
