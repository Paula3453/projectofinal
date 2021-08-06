using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class CARD : ScriptableObject
{
    public string PlayerName;
    public string Position;

    public Sprite ArtWork;

    public float Rating;
    public float Shooting;
}
