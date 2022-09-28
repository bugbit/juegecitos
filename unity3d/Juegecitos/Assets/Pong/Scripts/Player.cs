using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum TypePlayers
    {
        Human, IA
    }
    public TypePlayers TypePlayer = TypePlayers.Human;
    public float speed = 30;
    public string axis = "Vertical";
    public int points = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
