using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();


    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None"));
        cardList.Add(new Card(1, "Human", 2, 1, "Basic human"));
        cardList.Add(new Card(2, "Elf", 3, 3, "Silly lil elf dude"));
        cardList.Add(new Card(3, "Fairy", 4, 4, "Tiny lil guy"));
        cardList.Add(new Card(4, "Ogre", 5, 5, "GET OUT ME SWAMP!"));
    }

}
