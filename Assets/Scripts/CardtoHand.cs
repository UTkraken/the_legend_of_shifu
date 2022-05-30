 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardtoHand : MonoBehaviour
{
    public GameObject Hand;
    public GameObject It;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Hand = GameObject.Find("Hand");
        It.transform.SetParent(Hand.transform);
        It.transform.localScale = Vector3.one;
        It.transform.position = new Vector3(transform.position.x, transform.position.y, -1);
        It.transform.eulerAngles = new Vector3(25,0,0);
    }
}