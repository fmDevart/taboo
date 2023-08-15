using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public GameObject toSpawn;
    private GameObject spawned;
    private Cards cards;
    public Card cardToShow;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.GetCards() != null)
        {
            this.cards = GameManager.instance.GetCards();
        }

        if(this.cards != null)
        {
            
                this.cardToShow =  this.cards.cards[index];

            if(!spawned)
            {
                spawned = Instantiate(toSpawn, transform);
            }


            Transform titlePanel = spawned.transform.GetChild(0);
            Transform bodyPanel = spawned.transform.GetChild(1);

            Text textComponent = titlePanel.GetComponentInChildren<Text>();

            // Modifica il testo nel componente di testo
            if (textComponent != null)
            {
                textComponent.text = cardToShow.obj;
            }

        }
 
    }
    public void NextCard()
    {
        this.index++;

    }

    public void PrevCard()
    {
        this.index--;

    }

}
