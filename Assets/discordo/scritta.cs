using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scritta : MonoBehaviour
{
    public TextMeshProUGUI testo;
    public string[] lines;
    public float textspeed;
    public AudioSource bip;
    public Transform posizione;
    public Transform rotazione;
    public GameObject Movimento;
    public GameObject Guardare;
    public static float contatore = 0;
    public GameObject corpo;
    CharacterController cc;
    

    private int index;
    // Start is called before the first frame update
    void Start()
    {
        
        testo.text = string.Empty;
        StartDialogue();
        Movimento.GetComponent<playerscript>().enabled = false;
        Guardare.GetComponent<MouseLook>().enabled = false;
        corpo.GetComponent<CharacterController>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (testo.text == lines[index])
            {
                Nextline();
            }
            else
            {
                StopAllCoroutines();
                testo.text = lines[index];
            }
        }
    }

    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            testo.text += c;
            yield return new WaitForSeconds(textspeed);
        }
    }

    void Nextline()
    {
        if ( index < lines.Length - 1)
        {
            index++;
            testo.text = string.Empty;
            bip.Play();
            StartCoroutine(TypeLine());

            
        }
        else
        {
            posizione.position = new Vector3(-57.43f, 42.812f, -28.24f);
            rotazione.transform.eulerAngles = new Vector3 (0, 180 -180, 0);
            gameObject.SetActive(false);
            scritta.contatore = +1;


        }
    }
}
