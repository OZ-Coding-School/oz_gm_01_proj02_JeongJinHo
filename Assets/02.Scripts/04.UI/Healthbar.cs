using UnityEngine;

public class Healthbar : MonoBehaviour
{
    [SerializeField] private Transform healthBar;

    private float lerpSpeed = 5f;
    private float targetYScale = 1f;

    private void Update()
    {
        float currentY = Mathf.Lerp(healthBar.localScale.y, targetYScale, Time.deltaTime * lerpSpeed);

        healthBar.localScale = new Vector3(healthBar.localScale.x, currentY, healthBar.localScale.z);
    }
    public void SetHealthBar(float normalizedHealth)
    {
        targetYScale = Mathf.Clamp01(normalizedHealth);
    }
}
