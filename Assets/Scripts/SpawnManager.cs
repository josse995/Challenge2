using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] ballsContainer;

    public float spawnsPerSeconds = 5;
    public float spawnRangeX = 20;
    public float spawnPosY = 20;
    private float startDelay = 2;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(SpawnBalls), startDelay, spawnsPerSeconds);
    }

    private void SpawnBalls()
    {
        var spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, 0);
        int ballIndex = Random.Range(0, ballsContainer.Length);
        Instantiate(ballsContainer[ballIndex], spawnPos, ballsContainer[ballIndex].transform.rotation);
    }
}
