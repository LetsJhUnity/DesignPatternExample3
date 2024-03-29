using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public List<Collider2D> targetList = new List<Collider2D>();


    private void OnTriggerEnter2D(Collider2D collision)
    {
        targetList.Add(collision);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        targetList.Remove(collision);
    }
}
