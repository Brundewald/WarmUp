using UnityEngine;


namespace WarmUp
{
    internal sealed class GameInitialization
    {
        public GameInitialization(Controllers controllers)
        {
            Camera camera = Camera.main;
            var inputInitialization = new InputInitialization();
            var playerFactory = new PlayerFactory("Player");
            var playerInitialization = new PlayerInitialization(playerFactory);
            controllers.Add(inputInitialization);
            controllers.Add(playerInitialization);
            controllers.Add(new InputController(inputInitialization.GetInput()));
            controllers.Add(new MovementLogic(inputInitialization.GetInput(), playerInitialization.GetPlayer()));
            controllers.Add(new CameraController(playerInitialization.GetPlayer(), camera.transform));
            //controllers.Add(new EndGameController(enemyInitialization.GetEnemies(), playerInitialization.GetPlayer().gameObject.GetInstanceID()));
        }
    }
}

