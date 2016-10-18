using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    void Start()
    {
        Character playerOne = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        Character playerTwo = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        playerOne.DisplayInfo();
        playerTwo.DisplayInfo();
    }
}
