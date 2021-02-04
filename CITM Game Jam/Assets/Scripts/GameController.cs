using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    void Start()
    {
        ResourceManager.LoadRunes();
        GameState.UnlockRune(RuneType.RT_Water);
    }

    void Update()
    {
        
    }
}
