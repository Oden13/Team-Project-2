using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class Collecting : MonoBehaviour
{
    public Text tomeCounting;
    public Text exitHint;
    private int tomeNumber = 0;

    public AudioClip book;
    public AudioSource bookSound;
    // [SerializeField] private string WinScreen;

    // Start is called before the first frame update
    void Start()
    {
        SetCountingText();
        exitHint.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Tome")
        {
            Debug.Log ("Got Tome!");
            tomeNumber = tomeNumber + 1;
            bookSound.clip = book;
            bookSound.Play();
            SetCountingText();
            Destroy(other.gameObject,0.2f);
          
        }

        if (other.gameObject.tag == "Exit")
        {
            if (tomeNumber == 4)
            {
                SceneManager.LoadScene("WinScreen");
            }

            else
            {
                exitHint.text = "Collect all four tomes to exit!";
            }

        }
    }

    void OnTriggerExit(Collider other)
    {
        exitHint.text = "";
    }

    void SetCountingText()
    {
        tomeCounting.text = tomeNumber.ToString() + " / 4";
    }
}
