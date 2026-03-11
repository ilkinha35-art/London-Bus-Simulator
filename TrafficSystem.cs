using UnityEngine;

public class TrafficSystem : MonoBehaviour
{
    public GameObject[] cars;
    public Transform[] waypoints;
    public float carSpeed = 5f;

    void Start()
    {
        foreach (GameObject car in cars)
        {
            StartCoroutine(MoveCar(car));
        }
    }

    System.Collections.IEnumerator MoveCar(GameObject car)
    {
        int i = 0;
        while (true)
        {
            car.transform.position = Vector3.MoveTowards(
                car.transform.position,
                waypoints[i].position,
                carSpeed * Time.deltaTime
            );

            if (Vector3.Distance(car.transform.position, waypoints[i].position) < 0.1f)
            {
                i = (i + 1) % waypoints.Length;
            }
            yield return null;
        }
    }
}
