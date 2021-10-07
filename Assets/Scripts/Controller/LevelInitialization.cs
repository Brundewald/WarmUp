
namespace WarmUp 
{
    public sealed class LevelInitialization : IInitialize
    {
        private readonly ILevelFactory _levelBuilder;

        public LevelInitialization(ILevelFactory levelBuilder) 
        {
            _levelBuilder = levelBuilder;
            _levelBuilder.BuildLevel();
        }

        public void Initialize()
        {
        }
    }

}
