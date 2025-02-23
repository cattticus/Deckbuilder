using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardData : MonoBehaviour
{
    public static List<Card> cardList = new List<Card>();


    void Awake()
    {
        cardList.Add(new Card(0, "None", 0, 0, "None", Resources.Load<Sprite>("elfPunkF") ));
        cardList.Add(new Card(1, "Human", 2, 1, "Basic human", Resources.Load<Sprite>("humanF")));
        cardList.Add(new Card(2, "Elf", 3, 3, "Silly lil elf dude", Resources.Load<Sprite>("elfM")));
        cardList.Add(new Card(3, "Vampire", 4, 4, "You dont wanna get a paper cut around these guys", Resources.Load<Sprite>("vampireM")));
        cardList.Add(new Card(4, "Medusa", 5, 5, "Don't look her in the eyes", Resources.Load<Sprite>("medusa")));
    }

}
