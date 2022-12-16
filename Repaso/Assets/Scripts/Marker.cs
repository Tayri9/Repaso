using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Marker : MonoBehaviour
{
    public static Marker instance;

    [SerializeField]
    TextMeshProUGUI scoreP1, scoreP2;

    int goalsP1, goalsP2;

    private void Awake()
    {
        if (Marker.instance == null)
        {
            Marker.instance = this;

        } else
        {
            Destroy(this);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        goalsP1 = 0;
        goalsP2 = 0;
    }

    public void Player1Goal()
    {
        goalsP1++;
        scoreP1.text = goalsP1.ToString();
    }

    public void Player2Goal()
    {
        goalsP2++;
        scoreP2.text = goalsP2.ToString();
    }
}
