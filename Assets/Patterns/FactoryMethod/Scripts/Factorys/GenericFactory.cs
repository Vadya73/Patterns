using UnityEngine;

namespace Assets.Patterns.FactoryMethod.Scripts.Factorys
{
    public class GenericFactory<T> : MonoBehaviour where T : MonoBehaviour
    {
        [SerializeField] private T _prefab;
        [SerializeField] private Transform _spawnPoint;

        private int _offset = 0;

        public T GetNewInstance()
        {
            Vector3 position = new Vector3(_spawnPoint.position.x + _offset, _spawnPoint.position.y, _spawnPoint.position.z);
            return Instantiate(_prefab, position, Quaternion.identity);
        }
    }
}