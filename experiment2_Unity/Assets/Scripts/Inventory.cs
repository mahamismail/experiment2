using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/******* JTL comment
 * This script is entirely for holding data used elsewhere. This could be part of the PlayerController, but this way, our Inventory is sort of its own "object" (accessible via GetComponent<Inventory>() on whatever object the Inventory is attached to -- the player, for now).
 * 
 * If we were to change this to a game with several NPCs (non-player characters controlled by the computer), each with their own inventories, we could add this Inventory class to each NPC and modify each instance of Inventory separately, depending on which character is doing something.
 * 
 * By declaring these arrays without a specific number of slots, and as public, we are able to configure how many items should be holdable via the Unity editor.
 */

public class Inventory : MonoBehaviour {


    public int[] items;
    public GameObject[] slots;
}
