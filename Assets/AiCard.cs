using UnityEngine.UI;
using UnityEngine;

public class AiCard : MonoBehaviour
{
    public Card_data data;
    public string card_name;
    public int health;
    public int cost;
    public int damage;
    public Sprite sprite;
    public Image spriteImage;
    //public Image spriteImage;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        LoadData();
    }

    // Update is called once per frame
    public void LoadData()
    {
        cost = data.cost;
        sprite = data.sprite;
        spriteImage.sprite = sprite;
    }
}
