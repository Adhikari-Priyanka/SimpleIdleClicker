using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //if you use text mesh pro
using UnityEngine.SceneManagement;

public class GM_SimpleClicker : MonoBehaviour
{
    public int clicks; //integer to store no. of clicks
    public TMP_Text count; //TMP text to display no of clicks

     public TMP_Text ACText1; //TMP text to display cost of autoclick
    private int ACcost; //integer to store cost of autoclick
    public TMP_Text ACText2; //TMP text to display no.of autoclicks purchase
    private int ACcount;

    public TMP_Text Unafford; //TMP text for when you can't afford

private int i;


    void Start(){
        clicks = 0;
        ACcost = 10;
        ACcount = 0;   
        i=1;     
      
        }

    void Update()
    {
        //update TMP text count 
        count.text = "n clicks:" + clicks;
        ACText1.text = "Buy autoclicks at cost: " + ACcost;
        ACText2.text = "autoclicks purchased: " + ACcount;
        
        if (ACcount >0){StartCoroutine(ACupdate());}/////// :()


        //How to end the game
        if (clicks == 999){count.text = "fin!";}
        if (clicks == 1000){Fin();}

  

    }

    //Function- what ahppens if image is clicked
    public void Clicked(){clicks ++;} 

    //Function to buy autoclick
    public void Buy(){
        if (clicks < ACcost){
            Unafford.text ="You need " + (ACcost-clicks) + " more clicks";
            StartCoroutine(reset1());}
        else {
            clicks = clicks - ACcost; //subtract the cost of the autoclick from clicks collected
            ACcount++; //increase number of AC bought
            ACcost = 10*ACcount;} //increase the cost of the AC
        
    }

    //Function to end the game
    public void Fin(){
        SceneManager.LoadScene("TryAgain");
    }

    //Make a coroutine to remove the Unafford text
    IEnumerator reset1(){
        yield return new WaitForSeconds(1f);
        Unafford.text = ":)";
    }



    //Coroutine for an actual auto click
    IEnumerator ACupdate(){
            while(i <10){
                yield return new WaitForSeconds(2f);
                clicks = clicks + 1;
                i++;}
    }




    }
