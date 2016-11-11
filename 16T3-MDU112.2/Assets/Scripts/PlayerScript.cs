using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    public void Start()
    {
        // Create roster of 10 characters with stats
        Character playerOne = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerTwo = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerThree = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerFour = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerFive = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerSix = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerSeven = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerEight = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerNine = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerTen = new Character(UnityEngine.Random.Range(1, 11), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));

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
                
        // Create a team health value to easily track the conditional in the while loop
        float teamOneHealth = 1;
        teamOneHealth = teamOneMemberOne.health + teamOneMemberTwo.health + teamOneMemberThree.health;
        float teamTwoHealth = 2;
        teamTwoHealth = teamTwoMemberOne.health + teamTwoMemberTwo.health + teamTwoMemberThree.health;

        // Create a list for the battle characters in team one
        List<Character> teamOneBattleList = new List<Character>();
        teamOneBattleList.Add(teamOneMemberOne);
        teamOneBattleList.Add(teamOneMemberTwo);
        teamOneBattleList.Add(teamOneMemberThree);

        // Create a list for the battle characters in team two
        List<Character> teamTwoBattleList = new List<Character>();
        teamTwoBattleList.Add(teamTwoMemberOne);
        teamTwoBattleList.Add(teamTwoMemberTwo);
        teamTwoBattleList.Add(teamTwoMemberThree);

        // Count the rounds in the battle
        int numRounds = 1;
        
        while (teamOneHealth >0 & teamTwoHealth >0)
        {
            // Choose an attacker and a victim for team one
            int chooseAttackerTeamOne = UnityEngine.Random.Range(0, teamOneBattleList.Count);
            Character teamOneAttacker = teamOneBattleList[chooseAttackerTeamOne];
            int chooseAttackeeTeamOne = UnityEngine.Random.Range(0, teamTwoBattleList.Count);
            Character teamOneAttackee = teamTwoBattleList[chooseAttackeeTeamOne];

            // Do the damage for team one
            teamOneAttackee.health = teamOneAttackee.health - teamOneAttacker.damage;

            // Choose an attacker an a victim for team two
            int chooseAttackerTeamTwo = UnityEngine.Random.Range(0, teamTwoBattleList.Count);
            Character teamTwoAttacker = teamTwoBattleList[chooseAttackerTeamTwo];
            int chooseAttackeeTeamTwo = UnityEngine.Random.Range(0, teamOneBattleList.Count);
            Character teamTwoAttackee = teamOneBattleList[chooseAttackeeTeamTwo];

            // Do the damage for team two
            teamTwoAttackee.health = teamTwoAttackee.health - teamTwoAttacker.damage;

            // Remove a character if death occurs
            if(teamOneMemberOne.health <= 0)
            {
                teamOneBattleList.RemoveAt(0);
            }

            if (teamOneMemberTwo.health <= 0)
            {
                teamOneBattleList.RemoveAt(1);
            }

            if (teamOneMemberThree.health <= 0)
            {
                teamOneBattleList.RemoveAt(2);
            }

            if (teamTwoMemberOne.health <= 0)
            {
                teamTwoBattleList.RemoveAt(0);
            }

            if (teamTwoMemberTwo.health <= 0)
            {
                teamTwoBattleList.RemoveAt(1);
            }

            if (teamTwoMemberThree.health <= 0)
            {
                teamTwoBattleList.RemoveAt(2);
            }

            ++numRounds;
        }
        
    }
}
