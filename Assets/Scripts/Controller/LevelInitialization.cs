
namespace WarmUp 
{
    public sealed class LevelInitialization : IInitialize
    {
        private readonly ILevelBuilder _levelBuilder;

        public LevelInitialization(ILevelBuilder levelBuilder) 
        {
            _levelBuilder = levelBuilder;
            _levelBuilder.BuildLevel();
        }

        public void Initialize()
        {
        }
    }

}
