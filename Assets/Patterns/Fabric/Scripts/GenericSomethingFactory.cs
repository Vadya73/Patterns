using UnityEngine;

namespace Assets.Patterns.Fabric.Scripts
{
    public class GenericSomethingFactory<T> : MonoBehaviour where T : Transform
    {
        [SerializeField] private T _prefab;
        [SerializeField] private Transform _spawnPoint;

        private float _offset = 1f;

        public T GetNewInstance()
        {
            Vector3 position = new Vector3(_spawnPoint.position.x + _offset, _spawnPoint.position.y, _spawnPoint.position.z);
            _offset++;
            return Instantiate(_prefab, position, Quaternion.identity);
        }
    }
}