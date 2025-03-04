using UnityEngine.UI;
using UnityEngine;

public class AiCard : MonoBehaviour
{
    
    public Card_data data;
    private Card_data previousData; // To track data changes
    public string card_name;
    public int health;
    public int cost;
    public int damage;
    public SpriteRenderer sprite;
    public Image spriteImage;
    
    void Update()
    {
        // Only reload if data has changed
        if (data != previousData)
        {
            LoadData();
            previousData = data;
        }
    }

    public void LoadData()
    {
        
            card_name = data.card_name;
            health = data.health;
            cost = data.cost;
            damage = data.damage;
            sprite.sprite = data.sprite;
            
            
                spriteImage.sprite = data.sprite;
            
        
    }
}
