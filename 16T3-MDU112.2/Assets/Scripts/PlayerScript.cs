using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    public void Start()
    {
        // Create roster of 10 characters with stats
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

        // List for Team One
        List<Character> teamOneList = new List<Character>();
        teamOneList.Add(playerOne);
        teamOneList.Add(playerTwo);
        teamOneList.Add(playerThree);
        teamOneList.Add(playerFour);
        teamOneList.Add(playerFive);

        // List for Team Two
        List<Character> teamTwoList = new List<Character>();
        teamTwoList.Add(playerSix);
        teamTwoList.Add(playerSeven);
        teamTwoList.Add(playerEight);
        teamTwoList.Add(playerNine);
        teamTwoList.Add(playerTen);

        // Selects UNIQUE Team One from the List of Characters
        // Important! From this point on teamMember... is the Characters name
        int chooseList1 = UnityEngine.Random.Range(0, teamOneList.Count);
        Character teamOneMemberOne = teamOneList[chooseList1];
        teamOneList.RemoveAt(chooseList1);
        int chooseList2 = UnityEngine.Random.Range(0, teamOneList.Count);
        Character teamOneMemberTwo = teamOneList[chooseList2];
        teamOneList.RemoveAt(chooseList2);
        int chooseList3 = UnityEngine.Random.Range(0, teamOneList.Count);
        Character teamOneMemberThree = teamOneList[chooseList3];
        teamOneList.RemoveAt(chooseList3);

        // Selects UNIQUE Team Two from the List of Characters
        int chooseList4 = UnityEngine.Random.Range(0, teamTwoList.Count);
        Character teamTwoMemberOne = teamTwoList[chooseList4];
        teamTwoList.RemoveAt(chooseList4);
        int chooseList5 = UnityEngine.Random.Range(0, teamTwoList.Count);
        Character teamTwoMemberTwo = teamTwoList[chooseList5];
        teamTwoList.RemoveAt(chooseList5);
        int chooseList6 = UnityEngine.Random.Range(0, teamTwoList.Count);
        Character teamTwoMemberThree = teamTwoList[chooseList6];
        teamTwoList.RemoveAt(chooseList6);
        
        // Display initial values for each member pre-battle (health)
        teamOneMemberOne.DisplayInfo();
        teamOneMemberTwo.DisplayInfo();
        teamOneMemberThree.DisplayInfo();
        teamTwoMemberOne.DisplayInfo();
        teamTwoMemberTwo.DisplayInfo();
        teamTwoMemberThree.DisplayInfo();



        // Call the display function for each Character
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
