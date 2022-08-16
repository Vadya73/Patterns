using UnityEngine;

namespace Assets.Patterns.Fabric.Scripts
{
    public class Buttons : MonoBehaviour
    {
        [SerializeField] private ArcherFactory _archerFactory;
        [SerializeField] private WarriorFactory _warriorFactory;
        [SerializeField] private SomethingFactory _somethingFactory;

        public void ArcherButton()
        {
            var prefab = _archerFactory.GetNewInstance();
        }

        public void WarriorButton()
        {
            var prefab = _warriorFactory.GetNewInstance();

        }

        public void SomethingButton()
        {
            var prefab = _somethingFactory.GetNewInstance();

        }
    }
}