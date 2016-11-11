using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerScript : MonoBehaviour
{
    public void Start()
    {
        // Create roster of 10 characters with stats
        Character playerOne = new Character(UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerTwo = new Character(UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerThree = new Character(UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerFour = new Character(UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerFive = new Character(UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerSix = new Character(UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerSeven = new Character(UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerEight = new Character(UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerNine = new Character(UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));
        Character playerTen = new Character(UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(6, 11), UnityEngine.Random.Range(1, 6), UnityEngine.Random.Range(1, 11));

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
        int numRounds = 0;
        
        while (teamOneBattleList.Count > 0 & teamTwoBattleList.Count > 0)
        {
            // Choose an attacker and a victim for team one
            int chooseAttackerTeamOne = UnityEngine.Random.Range(0, teamOneBattleList.Count);
            Character teamOneAttacker = teamOneBattleList[chooseAttackerTeamOne];
            int chooseAttackeeTeamOne = UnityEngine.Random.Range(0, teamTwoBattleList.Count);
            Character teamOneAttackee = teamTwoBattleList[chooseAttackeeTeamOne];

            // Do the damage for team one
            // Dodge chance if statement determines if damage is done
            if (UnityEngine.Random.Range(1, 51) <= teamOneAttackee.speed)
            {
                teamOneAttackee.health = teamOneAttackee.health - (teamOneAttacker.damage * 0);
                Debug.Log("Team Two dodged Team One's attack in Round " + numRounds);
            }
            else
            {
                // Critical hit chance for team one
                if (UnityEngine.Random.Range(1, 51) <= teamOneAttacker.criticalHitChance)
                {
                    teamOneAttackee.health = teamOneAttackee.health - (teamOneAttacker.damage * 2);
                    Debug.Log("Team One hit Team Two for a critical hit in Round " + numRounds);
                }
                else
                {
                    teamOneAttackee.health = teamOneAttackee.health - teamOneAttacker.damage;
                }
            }
                        
            // Choose an attacker an a victim for team two
            int chooseAttackerTeamTwo = UnityEngine.Random.Range(0, teamTwoBattleList.Count);
            Character teamTwoAttacker = teamTwoBattleList[chooseAttackerTeamTwo];
            int chooseAttackeeTeamTwo = UnityEngine.Random.Range(0, teamOneBattleList.Count);
            Character teamTwoAttackee = teamOneBattleList[chooseAttackeeTeamTwo];

            // Do the damage for team two
            // Dodge chance if statement determines if damage is done
            if (UnityEngine.Random.Range(1, 51) < teamTwoAttackee.speed)
            {
                teamTwoAttackee.health = teamTwoAttackee.health - (teamTwoAttackee.damage * 0);
                Debug.Log("Team One dodged Team Two's attack in Round " + numRounds);
            }
            else
            {
                // Critical hit change for team two
                if (UnityEngine.Random.Range(1, 51) <= teamTwoAttacker.criticalHitChance)
                {
                    teamTwoAttackee.health = teamTwoAttackee.health - (teamTwoAttacker.damage * 2);
                    Debug.Log("Team Two hit Team One for a critical hit in Round " + numRounds);
                }
                else
                {
                    teamTwoAttackee.health = teamTwoAttackee.health - teamTwoAttacker.damage;
                }
            }

            // Remove a character if death occurs
            if (teamOneMemberOne.health <= 0)
            {
                teamOneBattleList.Remove(teamOneMemberOne);
            }

            if (teamOneMemberTwo.health <= 0)
            {
                teamOneBattleList.Remove(teamOneMemberTwo);
            }

            if (teamOneMemberThree.health <= 0)
            {
                teamOneBattleList.Remove(teamOneMemberThree);
            }

            if (teamTwoMemberOne.health <= 0)
            {
                teamTwoBattleList.Remove(teamTwoMemberOne);
            }

            if (teamTwoMemberTwo.health <= 0)
            {
                teamTwoBattleList.Remove(teamTwoMemberTwo);
            }

            if (teamTwoMemberThree.health <= 0)
            {
                teamTwoBattleList.Remove(teamTwoMemberThree);
            }

            // Track the number of rounds
            ++numRounds;
        }
        
        // Check the victory/draw conditions for each team
        if(teamOneBattleList.Count > 0)
        {
            Debug.Log("Team One is the winner!");
        }

        if (teamTwoBattleList.Count > 0)
        {
            Debug.Log("Team Two is the winner!");
        }

        if (teamOneBattleList.Count == 0 & teamTwoBattleList.Count == 0)
        {
            Debug.Log("It was a draw");
        }

        // Display feedback about the battle
        Debug.Log(numRounds + " Rounds of battle took place");
        Debug.Log(teamOneBattleList.Count + " members survived from Team One");
        Debug.Log(teamTwoBattleList.Count + " members survived from Team Two");
        if(teamOneMemberOne.health <= 0)
        {
            Debug.Log("Team One Member One carked it");
        }
        if (teamOneMemberTwo.health <= 0)
        {
            Debug.Log("Team One Member Two carked it");
        }
        if (teamOneMemberThree.health <= 0)
        {
            Debug.Log("Team One Member Three carked it");
        }
        if (teamTwoMemberOne.health <= 0)
        {
            Debug.Log("Team Two Member One carked it");
        }
        if (teamTwoMemberTwo.health <= 0)
        {
            Debug.Log("Team Two Member Two carked it");
        }
        if (teamTwoMemberThree.health <= 0)
        {
            Debug.Log("Team Two Member Three carked it");
        }

    }
}
