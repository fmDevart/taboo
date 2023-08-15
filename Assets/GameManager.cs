using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public delegate void CardFilledEventHandler();
public class GameManager : MonoBehaviour
{

    public static GameManager instance  { get; private set; }

    [SerializeField]
    private Cards cards;
    public static event CardFilledEventHandler CardsFilled;
    [SerializeField]
    public Dictionary<string, Cards> catAndDecks = new Dictionary<string, Cards>();

    private void Awake()
    {
        Debug.Log(" [GAME MANAGER] creao istanza");

        if (instance == null )
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Cards GetCards()
    {
        return cards;
    }

    public void SetCards( Cards cards)
    {
        this.cards = cards;
        
    }
    public void addCard(string cat, Cards deck) {
        catAndDecks.Add(cat, deck);
        Debug.Log("aggiungo alla categoria: " + cat + " il deck:" + deck);
        CardsFilled?.Invoke();
    }
    public Dictionary<string, Cards> getAll() {
        return catAndDecks;
    }



}
