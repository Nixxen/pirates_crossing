using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterExit : MonoBehaviour
{
    public GameObject TeleporterTarget;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = TeleporterTarget.transform.position;
    }

}
