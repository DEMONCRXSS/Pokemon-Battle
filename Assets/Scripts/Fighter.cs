using UnityEngine;
using UnityEngine.Events;

public class Fighter : MonoBehaviour
{
    [SerializeField]

    private string _fighterName;

    public string FighterName => _fighterName;
    [SerializeField]

    private AttackData _AttackData;

    public AttackData AttackData => _AttackData;
    [SerializeField]

    private Health _health;

    public Health Health => _health;
    [SerializeField]

    private Animator _CharacterAnimator;

    public Animator CharacterAnimator => _CharacterAnimator;
    [SerializeField]

    private UnityEvent _onInitialize;

    public void InitializeFighter()
    {
        _onInitialize?.Invoke();
    }
}
