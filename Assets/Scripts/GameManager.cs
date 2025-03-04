using System.Collections;
using System.Collections.Generic;
using Unity.Android.Gradle;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ai_card_deploy;
    public static GameManager gm;
    public List<Card> deck = new List<Card>();
    public List<Card> player_deck = new List<Card>();
    public List<Card> ai_deck = new List<Card>();
    public List<Card> player_hand = new List<Card>();
    public List<Card> ai_hand = new List<Card>();
    public List<Card> discard_pile = new List<Card>();
    public List<Card> PlayerCard = new List<Card>();
    public List<Card> AiCard = new List<Card>();
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
        if (AiCard.Count > 0)
        {
            AiCard.RemoveAt(0);
        }

        int randomNumber = Random.Range(0, ai_hand.Count);
        print("FROM AI TURN: " + randomNumber);
        
        ai_card_deploy.GetComponent<AiCard>().data = ai_hand[randomNumber].GetComponent<Card>().data;
        
        AiCard.Add(ai_hand[randomNumber]);
        ai_hand.Remove(ai_hand[randomNumber]);
        
        Player_Turn();
        
        int newRandomNumber = Random.Range(0, deck.Count);
        ai_hand.Add(deck[newRandomNumber]);
    }

    public void Player_Turn()
    {
        print("Player Turn");
    }

    public void click(GameObject card, int index)
    {
        //PlayerCard = card.GetComponent<Card>().data;
        //player_hand[index].Remove;
    }
}
