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
        MarkerAnimation(scoreP1, goalsP1);
    }

    public void Player2Goal()
    {
        goalsP2++;
        MarkerAnimation(scoreP2, goalsP2);
    }

    void MarkerAnimation(TextMeshProUGUI score, int goals)
    {
        LeanTween.scale(score.gameObject, Vector3.one * 0.75f, 0f).setOnComplete(() => {
            score.text = goals.ToString();
            LeanTween.scale(score.gameObject, Vector3.one, 0.35f).setEaseInOutElastic();
        });
    }
}
