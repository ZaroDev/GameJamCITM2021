using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RuneSlot : MonoBehaviour
{
    public RuneType runeType;

    void Start()
    {
        if (GameState.IsUnlocked(runeType))
        {
            GetComponent<Image>().sprite = ResourceManager.getRuneSprite(runeType);
            GetComponent<Image>().enabled = true;
        }
    }
}
