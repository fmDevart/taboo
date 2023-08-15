using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{

    public GameObject toSpawn;
    public GameObject spawned;
    private Cards cards;
    public Card cardToShow;
    public int index = 0;
    public Transform bodyPanel;
    public Transform titlePanel;
    public TMP_Text textComponent;
    private TMP_Text[] taboos;
    public string titleToShow;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.GetCards() != null)
        {
            this.cards = GameManager.instance.GetCards();
        }

        if (this.cards != null)
        {

            this.cardToShow = this.cards.cards[index];
            titleToShow = cardToShow.obj;

            if (!spawned)
            {
                spawned = Instantiate(toSpawn, transform);
            }


            titlePanel = spawned.transform.GetChild(0);
            bodyPanel = spawned.transform.GetChild(1);

            textComponent = titlePanel.GetComponentInChildren<TMP_Text>();


            textComponent.text = cardToShow.obj;

            



        }

    }
    public void NextCard()
    {
        if(index < this.cards.cards.Length -1)
        {
            this.index++;
            Debug.Log("pressed next");
        }
        else
        {
            Debug.Log("no more cards");
        }
    }

    public void PrevCard()
    {

        if (index > 0)
        {
            Debug.Log("pressed Prev");
            this.index--;
        }
        else
        {
            Debug.Log("no more cards prev");
        }


     

    }

}
