using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JSONreader : MonoBehaviour
{

    public TextAsset textJSON;
    public Cards cards = new Cards();
    // Start is called before the first frame update
    void Start()
    {

        cards = JsonUtility.FromJson<Cards>(textJSON.text);
        Debug.Log(" [JSON READER] riempio le carte da GM");

        GameManager.instance.SetCards(cards);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
