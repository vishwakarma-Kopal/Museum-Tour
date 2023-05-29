using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{

    public Transform Player;
    public void TeleportPlayer()
    {
        Player.position = new Vector3(transform.position.x, Player.position.y, transform.position.z);
    }
}
