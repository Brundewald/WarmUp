using UnityEngine;

namespace WarmUp
{
    public class GameInitialization
    {
        public GameInitialization(Controllers controllers, Data data) 
        {
            Camera camera = Camera.main;
            var inputInitialization = new InputInitialization();
            var playerFactory = new PlayerFactory(data.Player);
            var platformBuilder = new PlatformBuilder(data.Level);
            var setPlatformPosition = new SetPlatformPosition(data.Level, platformBuilder);
            var levelBuilder = new LevelBuilder(platformBuilder, setPlatformPosition);
            var levelInitialization = new LevelInitialization(levelBuilder);
            var playerInitialization = new PlayerInitialization(playerFactory, data.Level.StartPlatformPosition, data.Player.Offset);
            controllers.Add(inputInitialization);
            controllers.Add(levelInitialization);
            controllers.Add(playerInitialization);
            controllers.Add(new InputController(inputInitialization.GetInput()));
            controllers.Add(new MovementController(inputInitialization.GetInput(), playerInitialization.GetPlayer(), data.Player));
            controllers.Add(new CameraController(playerInitialization.GetPlayer(), camera.transform));
            
        }

    }
}
