namespace WarmUp
{
    public sealed class LevelFactory: ILevelFactory
    {
        private readonly IPlatformBuilder _platformBuilder;
        private readonly ISetPlatformPosition _setPlatformPosition;

        public LevelFactory(IPlatformBuilder platformBuilder, ISetPlatformPosition setPlatformPosition) 
        {
            _platformBuilder = platformBuilder;
            _setPlatformPosition = setPlatformPosition;
            
        }
        public void BuildLevel() 
        {
            _platformBuilder.BuildPlatforms();
            _setPlatformPosition.SetPlatformsPositions();
        }
    }
}
