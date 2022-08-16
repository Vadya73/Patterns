using UnityEngine;

namespace Assets.Patterns.Fabric.Scripts
{
    public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] private T _prefab;
        [SerializeField] private Transform _spawnPoint;

        private int n = 0;

        public T GetNewInstance()
        {
            Vector3 position = new Vector3(_spawnPoint.position.x, _spawnPoint.position.y, _spawnPoint.position.z + n);
            return Instantiate(_prefab, position, Quaternion.identity);
        }
    }
}