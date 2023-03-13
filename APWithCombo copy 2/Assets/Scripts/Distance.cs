using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour
{
    public GameObject player;
    public GameObject hazard;
    public Text dist;
    [SerializeField] private Rigidbody2D rbPlayer;
    [SerializeField] private Rigidbody2D rbHazard;
    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = player.GetComponent<Rigidbody2D>();
        rbHazard = hazard.GetComponent<Rigidbody2D>();
        dist.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        float distance = rbPlayer.position.y - rbHazard.position.y;
        Debug.Log(rbPlayer.position.y);
        int intDist = (int) distance;
        dist.text = intDist + "m";
    }
}
