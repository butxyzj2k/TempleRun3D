using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObject/CoinConfig")]
public class CoinConfig : ScriptableObject
{
    [Header("Movement")]
    public float InitialMoveSpeed;

    [Header("Despawning")]
    public Vector3 InitialPosToCalculateDespawn;
    public float InitialDisToDespawn;
}