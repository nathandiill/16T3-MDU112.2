using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Character {

    public int agility = UnityEngine.Random.Range(1, 11);
    public int stamina = UnityEngine.Random.Range(1, 11);
    public int strength = UnityEngine.Random.Range(1, 11);
    public int acuity = UnityEngine.Random.Range(1, 11);

    public float speed;
    public float health;
    public float damage;
    public float criticalHitChance;

    public Character (int _agility, int _stamina, int _strength, int _acuity)
    {
        agility = _agility;
        stamina = _stamina;
        strength = _strength;
        acuity = _acuity;

        speed = Mathf.Pow(agility, 2);
        health = stamina * 2.5f;
        damage = strength * 1.5f;
        criticalHitChance = acuity * 2.0f;
    }

    public void DisplayInfo()
    {
        Debug.Log("Ag:" + agility + " (" + speed + "), " + "Sta:" + stamina + " (" + health + "), " + "Str:" + strength + " (" + damage + "), " + "Ac:" + acuity + " (" + criticalHitChance + ") ");
    }

}
