using UnityEngine;

[CreateAssetMenu]
public class PlayerConfig : ScriptableObject
{
    [Range(0f, 100f)] public float StartingHP;
    [Range(0f, 10f)] public float StartingSpeed;
    [Range(0f, 1f)] public float StartingAttack;
}

