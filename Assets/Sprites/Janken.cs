using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class janken : MonoBehaviour
{

    //Image jankenHand;

    /*public Sprite choki;
    public Sprite gu;
    public Sprite pa;*/

    void Start()
    {
        // 対象を探す
        var button = GameObject.Find("StartButton").GetComponent<Button>();
        var chokiButton = GameObject.Find("choki").GetComponent<Button>();
        var guButton = GameObject.Find("gu").GetComponent<Button>();
        var paButton = GameObject.Find("pa").GetComponent<Button>();
        //jankenHand = GameObject.Find("handImage").GetComponent<Image>();

    }

    void Update()
    {

    }
}
