using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechControlCode : MonoBehaviour
{
    public float score;
    public float maxScore;
    private GameObject[] burnable;
    private int maxHealth, totalBurnt;
    
    // Start is called before the first frame update
    void Start()
    {
        findAllBurnable();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //Calculate the score by dividing the  total burntHealth  by the  total maxHealth 
        for (int i=0;i<burnable.Length;i++){
            score += (burnable[i].getComponent<ObjectBio>().getHealth) - 100;
        }
    } 

    public void outOfTime()
    {
        // display end game screen for Fighter victory

    }

    //HELPER METHODS
    public void findAllBurnable(){
        burnable = GameObject.FindGameObjectsWithTag("burnable");
        maxScore = 100 * burnable.Length;
    }
    
    //ACCESSORS
    public float getMaxScore(){
        return (float) maxHealth;
    }
}
