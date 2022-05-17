using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******* JTL comment
 * Controls visibility of Bag_Contents GameObject (loaded into variable bag here)
 * Tracks state of bag (closed vs. open) via Boolean isClosed
 */

public class Bag : MonoBehaviour {

    bool isClosed;
    public GameObject bag;

    public void OpenCloseBag() {
        if (isClosed == true)
        {
            bag.SetActive(true);
            isClosed = false;
        }
        else {
            bag.SetActive(false);
            isClosed = true;
        }
    }
}
