using Unity.VisualScripting;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "PlayerData/PlayerDataSO")]
public class PlayerData : ScriptableObject
{
    [SerializeField] public float maxHp = 100f;
    [SerializeField] public float playerHp;

    public void MaxHp()
    {
        playerHp= maxHp;
    }
}
