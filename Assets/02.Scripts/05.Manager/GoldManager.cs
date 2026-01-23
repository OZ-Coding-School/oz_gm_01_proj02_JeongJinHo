using UnityEngine;

public class GoldManager : MonoBehaviour
{

    public static GoldManager instance;

    public int currentGold = 0;

    private GoldUi goldUi;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Ui(GoldUi ui)
    {
        goldUi = ui;
        GoldUI();
    }
    public void AddGold(int amount)
    {
        currentGold += amount;
        GoldUI();
    }
    public bool SpendGold(int amount)
    {
        if(currentGold >= amount)
        {
            currentGold -= amount;
            GoldUI();
            return true;
        }
        else
        {
            return false;
        }
    }
    private void GoldUI()
    {
        goldUi.AddGold(currentGold);
    }
   
}
