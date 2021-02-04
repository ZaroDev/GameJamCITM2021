public enum RuneType
{
    RT_ICE,
    RT_Fire,
    RT_Earth,
    RT_Nature,
    RT_Electricity,
    RT_Water,
    RT_Air,
    RT_None
}

public class Rune
{
    public RuneType runeType = RuneType.RT_None;

    Rune(RuneType rType)
    {
        runeType = rType;
    }
}
