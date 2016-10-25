using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    void Start()
    {
        Character playerOne = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        Character playerTwo = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        Character playerThree = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        Character playerFour = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        Character playerFive = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        Character playerSix = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        Character playerSeven = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        Character playerEight = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        Character playerNine = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));
        Character playerTen = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(1, 11));

        playerOne.DisplayInfo();
        playerTwo.DisplayInfo();
        playerThree.DisplayInfo();
        playerFour.DisplayInfo();
        playerFive.DisplayInfo();
        playerSix.DisplayInfo();
        playerSeven.DisplayInfo();
        playerEight.DisplayInfo();
        playerNine.DisplayInfo();
        playerTen.DisplayInfo();
    }
}
