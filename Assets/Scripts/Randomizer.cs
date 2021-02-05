using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Randomizer : MonoBehaviour
{
    [SerializeField] private GameObject _template;
    [SerializeField] private List<Transform> _points;

    private void Start()
    {
        Spawn();
    }

    private void Spawn()
    {
        Instantiate(_template, GetRandomPoint(), Quaternion.identity);
    }

    private Vector3 GetRandomPoint() { return _points[Random.Range(0, _points.Count)].position; }
}
