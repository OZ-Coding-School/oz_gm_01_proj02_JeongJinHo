using UnityEngine;

public class GoldManager : MonoBehaviour
{
    public static GoldManager instance;

    public int currentGold = 0;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void AddGold(int amount)
    {
        currentGold += amount;
        Debug.Log("Current Gold: " + currentGold);
    }
}
