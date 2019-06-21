using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cb125 : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("COLLISION");

        if (other.gameObject.tag == "Player")
        {
            PlayerQuest q = other.GetComponent<PlayerQuest>();
            for (int i = 0; i < q.quests.Count; i++)
            {
                if (q.quests[i].name == "Big Trouble In Little China!")
                {
                    q.quests[i].goal.ObjectCollected();
                    
                }
            }
        }


    }
}
