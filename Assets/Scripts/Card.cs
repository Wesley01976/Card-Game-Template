using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public Card_data data;

    public string card_name;
    public int health;
    public int cost;
    public int damage;
    public Sprite sprite;
    public Image spriteImage;
        

    // Start is called before the first frame update
    void Start()
    {
        LoadData();
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadData() 
    {
        cost = data.cost;
        sprite = data.sprite;
        spriteImage.sprite = sprite;
    }
}
