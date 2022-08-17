using UnityEngine;

namespace Assets.Patterns.AbstractFabric.Scripts
{
    public class RobotWorkerFactory : RobotsAbstractFactory
    {
        private Transform _spawnPoint;
        private GameObject _spawnPrefab;

        public RobotWorkerFactory(Transform spawnPoint, GameObject spawnPrefab)
        {
            _spawnPoint = spawnPoint;
            _spawnPrefab = spawnPrefab;
        }

        public override GameObject CreateRobotStandart()
        {
            var standardRobotWorker = Instantiate(_spawnPrefab, _spawnPoint.position, Quaternion.identity);

            return standardRobotWorker;
        }

        public override GameObject CreateRobotModernized()
        {
            var modernizeddRobotWorker = Instantiate(_spawnPrefab, _spawnPoint.position, Quaternion.identity);

            return modernizeddRobotWorker;
        }
    }
}