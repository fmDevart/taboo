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
    private GameObject[] taboos = new GameObject[5];
    public string titleToShow;
    public GameObject tabooVoice;
    public string[] voices = new string[5];
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.instance.GetCards() != null && this.cards == null)
        {
            this.cards = GameManager.instance.GetCards();
            this.cardToShow = this.cards.cards[index];

          
        }

        if (this.cards != null)
        {

            this.cardToShow = this.cards.cards[index];
            titleToShow = cardToShow.obj;

            if (!spawned)
            {
                spawned = Instantiate(toSpawn, transform);
                titlePanel = spawned.transform.GetChild(0);
                bodyPanel = spawned.transform.GetChild(1);
                for (int i = 0; i < cardToShow.taboos.Length; i++)
                {
                    taboos[i] = Instantiate(tabooVoice, transform);
                    taboos[i].transform.SetParent(bodyPanel);

                }
            }


     

            textComponent = titlePanel.GetComponentInChildren<TMP_Text>();


            textComponent.text = cardToShow.obj;

            for (int i = 0; i < cardToShow.taboos.Length; i++)
            {
                voices[i] = cardToShow.taboos[i];
                taboos[i].GetComponent<TMP_Text>().text = cardToShow.taboos[i];

            }








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
