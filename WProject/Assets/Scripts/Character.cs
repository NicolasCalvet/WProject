﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

    [Header("Character Stats")]
    public Stats stats;

    public int mana;

    [HideInInspector]
    public ESpellForce shield;
    [HideInInspector]
    public bool reflectingShield = false;
}
