using Assets.Patterns.FactoryMethod.Scripts.Factorys.Archers;
using Assets.Patterns.FactoryMethod.Scripts.Factorys.Warriors;
using Assets.Patterns.FactoryMethod.Scripts.SomethingFactorys.Something;
using UnityEngine;

namespace Assets.Patterns.FactoryMethod.Scripts.UI
{
    public class Buttons : MonoBehaviour
    {
        [SerializeField] private ArcherFactory _archerFactory;
        [SerializeField] private WarriorFactory _warriorFactory;
        [SerializeField] private SomethingFactory _somethingFactory;

        public void SpawnArcher()
        {
            var prefab = _archerFactory.GetNewInstance();
        }

        public void SpawnWarrior()
        {
            var prefab = _warriorFactory.GetNewInstance();

        }

        public void SpawnSomething()
        {
            var prefab = _somethingFactory.GetNewInstance();

        }
    }
}