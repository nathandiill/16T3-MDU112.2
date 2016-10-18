using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character {

    int agility = UnityEngine.Random.Range(1, 11);
    int stamina = UnityEngine.Random.Range(1, 11);
    int strength = UnityEngine.Random.Range(1, 11);
    int acuity = UnityEngine.Random.Range(1, 11);

    public Character (int _agility, int _stamina, int _strength, int _acuity)
    {
        agility = _agility;
        stamina = _stamina;
        strength = _strength;
        acuity = _acuity;

        float speed = Mathf.Pow(agility, 2);
        float health = stamina * 2.5f;
        float damage = strength * 1.5f;
        float criticalHitChance = acuity * 2.0f;
    }

    public void DisplayInfo()
    {
        Debug.Log(agility + stamina + strength + acuity);
    }

}
