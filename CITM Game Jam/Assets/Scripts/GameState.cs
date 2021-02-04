
public static class GameState
{
    private static bool[] m_UnlockedRunes = new bool[(int)RuneType.RT_None];

    public static void UnlockRune(RuneType rType)
    {
        m_UnlockedRunes[(int)rType] = true;
    }

    public static bool IsUnlocked(RuneType runeType)
    {
        return m_UnlockedRunes[(int)runeType];
    }
}
