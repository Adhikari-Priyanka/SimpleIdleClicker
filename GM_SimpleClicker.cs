using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //if you use text mesh pro

public class GM_SimpleClicker : MonoBehaviour
{
    public int clicks;
    public TMP_Text count;

    void Start(){
        clicks = 5;}

    void Update()
    {
        count.text = "n clicks:" + clicks;
        if (clicks == 0){count.text = "fin!";}
    }

    public void Clicked(){clicks --;}
}
