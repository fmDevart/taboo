using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardReader : MonoBehaviour
{

    private bool ready = false;
    public Cards cards;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("[CARD READER} In attesa di riempire le carte");
        GameManager.CardsFilled += fill;
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void fill() {
        this.cards = GameManager.instance.GetCards();

        Debug.Log("[CARD READER} Ho riempito le carte");

    }
}
