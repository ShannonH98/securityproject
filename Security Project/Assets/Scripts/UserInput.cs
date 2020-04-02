using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UserInput : MonoBehaviour
{
    string theName;
    public GameObject inputField;
    public GameObject panel;

    string answer1 = "Tg1@vk!";
    public bool canActivate;
    // Start is called before the first frame update

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void storeName()
    {
        theName = inputField.GetComponent<Text>().text;
        if(string.Compare(theName, answer1) == 0)
        {
            Debug.Log("You win");
        }
        else
        {
            Debug.Log("You lose");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        canActivate = true;
        if(other.tag == "Player" && Input.GetButtonDown("Fire1"))
        {
            panel.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        
    }
}
