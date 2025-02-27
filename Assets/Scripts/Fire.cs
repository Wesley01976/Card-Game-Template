using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameManager gameManager;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
