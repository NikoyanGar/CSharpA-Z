namespace _009_1_Bitwise_And_Shift_Operators
{
    [Flags]
    enum FeatureFlags
    {
        None = 0,
        Flag0 = 1 << 0,  // 0000000001
        Flag1 = 1 << 1,  // 0000000010
        Flag2 = 1 << 2,  // 0000000100
        Flag3 = 1 << 3,  // 0000001000
        Flag4 = 1 << 4,  // 0000010000
        Flag5 = 1 << 5,  // 0000100000
        Flag6 = 1 << 6,  // 0001000000
        Flag7 = 1 << 7,  // 0010000000
        Flag8 = 1 << 8,  // 0100000000
        Flag9 = 1 << 9   // 1000000000
    }
}
