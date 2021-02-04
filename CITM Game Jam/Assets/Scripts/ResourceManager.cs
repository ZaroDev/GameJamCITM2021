using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ResourceManager 
{
    private static Sprite[] m_RuneSpriteList;

    public static void LoadRunes()
    {
        m_RuneSpriteList = Resources.LoadAll<Sprite>("Images/runes");
    }

    public static Sprite getRuneSprite(RuneType rType)
    {
        return m_RuneSpriteList[(int)rType];
    }
}
