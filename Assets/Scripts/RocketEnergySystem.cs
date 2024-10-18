using UnityEngine;
using UnityEngine.UI;

public class RocketEnergySystem : MonoBehaviour
{
    [Header("TargetRocket")]
    [SerializeField] private Rocket playerRocket;

    [Header("UI")]
    [SerializeField] private Image gasGage;

    private void Start()
    {
        playerRocket = GetComponent<Rocket>();
    }

    private void Update()
    {
        gasGage.fillAmount = playerRocket.fuel / 100;
    }
}
