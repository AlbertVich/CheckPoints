using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoints : MonoBehaviour
{

    public float xPos;
    public float yPos;
    public float zPos;
    public GameObject thePlayer;
    
    public Text actualChek;

    // Start is called before the first frame update
    void Start()
    {
        xPos = PlayerPrefs.GetFloat("XPosition");
        yPos = PlayerPrefs.GetFloat("YPosition");
        zPos = PlayerPrefs.GetFloat("ZPosition");

        thePlayer.transform.position = new Vector3(xPos, yPos, zPos);
    }

    // Update is called once per frame
    void Update()
    {
        xPos = thePlayer.transform.position.x;
        yPos = thePlayer.transform.position.y;
        zPos = thePlayer.transform.position.z;
        
    }


    void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetFloat("XPosition", xPos);
        PlayerPrefs.SetFloat("YPosition", yPos);
        PlayerPrefs.SetFloat("ZPosition", zPos);


       if(gameObject.CompareTag("Chek1")){
           Debug.Log("1");
           actualChek.text ="Actual ChekPoint: 1";
       }
       if(gameObject.CompareTag("Chek2")){
           Debug.Log("2");
           actualChek.text ="Actual ChekPoint: 2";
       } 
       if(gameObject.CompareTag("Chek3")){
           Debug.Log("3");
           actualChek.text ="Actual ChekPoint: 3";

       }  
    }
}
