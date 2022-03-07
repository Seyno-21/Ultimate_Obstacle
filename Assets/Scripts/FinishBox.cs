using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishBox : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) 
    {
        GameObject.Find("Player").SendMessage("Finish");
    }
}
