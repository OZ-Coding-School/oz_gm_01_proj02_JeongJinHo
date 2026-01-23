using TMPro;
using UnityEngine;

public class GoldUi : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI goldText;

    private void Start()
    {
        if(GoldManager.instance != null)
        {
            GoldManager.instance.Ui(this);

        }
    }
    public void AddGold(int gold)
    {
        goldText.text="Gold : "+gold.ToString();

        //goldText.text = gold.ToString("Gold:0000");
    }
}
