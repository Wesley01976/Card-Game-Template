using UnityEngine;

public class DeckBehaviour : MonoBehaviour
{
    public GameManager gm;
    public Card[] deck = new Card[5];
    public GameObject[] cards = new GameObject[5];
    public GameObject aiCard;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gm = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < deck.Length; i++)
        {
            deck[i] = gm.player_hand[i];
            cards[i].GetComponent<Card>().data = deck[i].data;
            cards[i].GetComponent<Card>().LoadData();
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            aiCard.GetComponent<AiCard>().data = gm.AiCard[0].data;
            aiCard.GetComponent<AiCard>().LoadData();
        }
            
    }
}

