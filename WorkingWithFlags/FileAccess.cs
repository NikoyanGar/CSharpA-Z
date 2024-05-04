namespace WorkingWithFlags
{
    [Flags]
    enum FileAccess
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4
    }
}
