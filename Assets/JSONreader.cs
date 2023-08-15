using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.Networking; 



public class JSONreader : MonoBehaviour
{

    public TextAsset textJSON;
    public Cards cards = new Cards();
    private string mainDir = "Cards";
    
    IEnumerator Start()
    {
        string folderPath = Path.Combine(Application.streamingAssetsPath, mainDir);

        if (Directory.Exists(folderPath))
        {
            string[] categories = Directory.GetDirectories(folderPath);

            foreach (string category in categories)
            {
                string catName = Path.GetFileName(category);
                
                
        
                string[] decks = Directory.GetFiles(category, "*.json");
                foreach (string deck in decks)
                {
                    
                    string deckName = Path.GetFileName(deck);
                    
                    Cards cards = JsonUtility.FromJson<Cards>(File.ReadAllText(deck));
                    GameManager.instance.addCard(catName, cards);
                }
               
                
            }
        }
        else
        {
            Debug.LogWarning("La cartella non esiste negli Streaming Assets.");
        }

        yield return null; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
