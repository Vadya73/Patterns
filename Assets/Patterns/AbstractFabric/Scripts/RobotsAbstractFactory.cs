using UnityEngine;

namespace Assets.Patterns.AbstractFabric.Scripts
{
    public abstract class RobotsAbstractFactory : MonoBehaviour
    {
        public abstract GameObject CreateRobotStandart();

        public abstract GameObject CreateRobotModernized();
    }
}