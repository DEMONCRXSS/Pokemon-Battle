using UnityEngine;

[CreateAssetMenu(fileName = "NewScriptableObjectScript", menuName = "Scriptable Objects/NewScriptableObjectScript")]
public class AttackData : ScriptableObject
{
    public Attack[] attacks;
}

[System.Serializable]

public class Attack
{
    public string attackNamne;

    public float minDamage;

    public float maxDamage;

    public float attackDuration;

    public string animationName;

    public string soundName;

    public GameObject particlesPrefab;

    public GameObject hitParticlesPrefabs;

}
