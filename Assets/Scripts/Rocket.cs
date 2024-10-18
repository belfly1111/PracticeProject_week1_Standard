using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class Rocket : MonoBehaviour
{
    [Header("Rocket")]
    private Rigidbody2D _rb2d;
    public float fuel { get; private set; } = 100;
    public float score { get; private set; } = 0;
    public float highScore { get; private set; } = 0;
    private readonly float SPEED = 5f;
    private readonly float FUELPERSHOOT = 10f;

    private void Awake()
    {
        // TODO : Rigidbody2D 컴포넌트를 가져옴(캐싱) 
        _rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        score = transform.position.y - 0.4f; // 기본 피벗에서 빼줌.
        if (highScore < score) highScore = score;

        fuel += 0.1f;
    }

    public void Shoot()
    {
        // TODO : fuel이 넉넉하면 윗 방향으로 SPEED만큼의 힘으로 점프, 모자라면 무시
        if (fuel < FUELPERSHOOT) return;
        fuel -= FUELPERSHOOT;

        _rb2d.AddForce(Vector2.up * SPEED, ForceMode2D.Impulse);
    }
}
