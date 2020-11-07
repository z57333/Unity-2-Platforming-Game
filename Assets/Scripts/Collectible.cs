using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class Collectible : MonoBehaviour
{
    public string CollectibleName;
    public string description;
    public GameObject player;

    public abstract void Use();
}
