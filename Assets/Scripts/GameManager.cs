using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gm;
    public List<Card> deck = new List<Card>();
    public List<Card> player_deck = new List<Card>();
    public List<Card> ai_deck = new List<Card>();
    public List<Card> player_hand = new List<Card>();
    public List<Card> ai_hand = new List<Card>();
    public List<Card> discard_pile = new List<Card>();
    public GameObject WaterCard;
    public GameObject FireCard;
    public GameObject PlantCard;

    private void Awake()
    {
        if (gm != null && gm != this)
        {
            Destroy(gameObject);
        }
        else
        {
            gm = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Deal();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            AI_Turn();
        }
    }
    
    int hand_size = 5;
    int AI_hand_size = 5;

    void Deal()
    {
        print("Dealing cards");

        for (int i = 0; i < hand_size; i += 1)
        {
            int randomNumber = Random.Range(0, deck.Count);
            player_hand.Add(deck[randomNumber]);
            //print(i);
        }
        for (int i = 0; i < AI_hand_size; i += 1)
        {
            int randomNumber = Random.Range(0, deck.Count);
            ai_hand.Add(deck[randomNumber]);
            //print(i);
        }
    }

    void Shuffle()
    {
    }

    void AI_Turn()
    {
      int randomNumber = Random.Range(0, ai_hand.Count);
      print("FROM AI TURN: " + randomNumber);
       ai_hand.Remove(ai_hand[randomNumber]);
       Player_Turn();
       int newRandomNumber = Random.Range(0, deck.Count);
            ai_hand.Add(deck[newRandomNumber]);
    }
    void InstantiatePlayerCards()
    {
        for (int i = 0; i < player_hand.Count; i++)
        {
            GameObject cardPrefab = GetCardPrefab(player_hand[i]);
            if (cardPrefab != null)
            {
                GameObject card = Instantiate(cardPrefab, playerHandTransform);
                card.transform.localPosition = new Vector3(i * 2.0f, 0, 0); // Position cards in a row
            }
        }
    }

    GameObject GetCardPrefab(Card card)
    {
        switch (card.type)
        {
            case CardType.Water:
                return Water Card;
            case CardType.Fire:
                return Fire Card;
            case CardType.Plant:
                return Plant Card;
            default:
                return null;
        }
    }

void Player_Turn()
{

}
}
