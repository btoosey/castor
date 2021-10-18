using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    public new string name;
    
    public int value;
    public Suit suit;
    public string description = null;
    public Sprite artwork;
    
    
    public enum Suit {
        None,
        Heart,
        Diamond,
        Spade,
        Club
    };
}
