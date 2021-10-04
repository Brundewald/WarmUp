using UnityEngine;

namespace WarmUp
{
    public class GameInitialization
    {
        public GameInitialization(Controllers controllers, Data data) 
        {
            Camera camera = Camera.main;
            var platformBuilder = new PlatformBuilder(data.Level);
            var setPlatformPosition = new SetPlatformPosition(data.Level, platformBuilder);
            var levelBuilder = new LevelBuilder(platformBuilder, setPlatformPosition);
            var levelInitialization = new LevelInitialization(levelBuilder);
            controllers.Add(levelInitialization);
        }

    }
}
