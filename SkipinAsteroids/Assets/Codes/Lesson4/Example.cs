using UnityEngine;


namespace SkipinAsteroids.Builder
{
    internal sealed class Example : MonoBehaviour
    {
        [SerializeField] private Sprite _sprite;

        private void Start()
        {
            var gameObjectBuilder = new GameObjectBuilder();

            GameObject player = gameObjectBuilder.Visual.Name("Mikhail").Sprite(_sprite).Physics.Rigidbody2D(50)
                .BoxCollider2D();


            //new GameObject().SetName("Enemy").AddBoxCollider2D().AddRigidbody2D(5.0f).AddSprite(_sprite);


        }

    }
}

