using UnityEngine;

public class CarSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _carPrefabs;

    private void Awake()
    {
        Instantiate(_carPrefabs);
    }
}
