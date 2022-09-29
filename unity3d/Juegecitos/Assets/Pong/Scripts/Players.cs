using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Players : MonoBehaviour
{
    public List<Player> players;
    public List<Text> playersTexts;

    //Singleton pattern
    public static Players instance;

    public void UpdateScore(int player)
    {
        if (player < 0 || player > 2)
            playersTexts[player].text = (++(players[player].score)).ToString();
    }

    //Awake is called before Start
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
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
}
