using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Muffin : MonoBehaviour
{

    public int muffinsPerClick = 1;
    public int numberOfEarnedMuffins = 0; //int to return a value 

    public TMP_Text text;

    public RectTransform spinLight;
    public float spinSpeed = 20; // set a float and assign a number 

    public float 

    public void AddMuffins(int MuffinsToAdd)
    {
        numberOfEarnedMuffins = numberOfEarnedMuffins + MuffinsToAdd; 
    }

    public void UpdateTextUI()
    {
        text.text = numberOfEarnedMuffins.ToString(); //change the int to a string
    }

    public void OnMuffinClick()
    {
        AddMuffins(muffinsPerClick);
        UpdateTextUI();
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start called");
    }

    // Update is called once per frame
    // void Update()
    {
        spinLight.Rotate(0, 0, spinSpeed * Time.deltaTime); //compensates for framerate and how fast your computer's fps is 
        
    }
}
