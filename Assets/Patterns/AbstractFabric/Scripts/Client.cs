using UnityEngine;

namespace Assets.Patterns.AbstractFabric.Scripts
{
    public class Client : MonoBehaviour
    {
        [SerializeField] private Transform _spawnPoint1;
        [SerializeField] private Transform _spawnPoint2;

        [SerializeField] private GameObject _worker;
        [SerializeField] private GameObject _workerModernized;

        private RobotsAbstractFactory _factory;

        public void CreateStandardWorker()
        {
            _factory = new RobotWorkerFactory(_spawnPoint1, _worker);
            _factory.CreateRobotStandart();
        }

        public void CreateModernizedWorker()
        {
            _factory = new RobotWorkerFactory(_spawnPoint2, _workerModernized);
            _factory.CreateRobotModernized();
        }
    }
}