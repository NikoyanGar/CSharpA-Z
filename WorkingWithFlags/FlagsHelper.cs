namespace WorkingWithFlags
{
    public static class FlagsHelper<TEnum> where TEnum : Enum
    {
        public static bool IsSet(TEnum flags, TEnum flag)
        {
            int flagsValue = Convert.ToInt32(flags);
            int flagValue = Convert.ToInt32(flag);
            return (flagsValue & flagValue) == flagValue;
        }

        public static TEnum Set(TEnum flags, TEnum flag)
        {
            int flagsValue = Convert.ToInt32(flags);
            int flagValue = Convert.ToInt32(flag);
            return (TEnum)Enum.ToObject(typeof(TEnum), flagsValue | flagValue);
        }

        public static TEnum Unset(TEnum flags, TEnum flag)
        {
            int flagsValue = Convert.ToInt32(flags);
            int flagValue = Convert.ToInt32(flag);
            return (TEnum)Enum.ToObject(typeof(TEnum), flagsValue & ~flagValue);
        }
    }
}
