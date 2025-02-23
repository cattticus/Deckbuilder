using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card2 card;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    

    public TextMeshProUGUI manaText;
    public TextMeshProUGUI attackText;

    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;

        manaText.text = card.manaCost.ToString();
        attackText.text = card.attack.ToString();
    }

}
