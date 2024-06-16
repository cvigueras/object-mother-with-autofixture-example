using AutoFixture;
using Object.Mother.AutoFixture.App;

namespace Object.Mother.AutoFixture.Test.Fixtures
{
    public class UserMother
    {
        private static Fixture _fixture = new Fixture();

        public static User UserUnderEighteen()
        {
            return _fixture.Build<User>()
                            .With(u => u.Age, 16)
                            .Create();
        }

        public static User UserOverEighteenUnderThirty()
        {
            return _fixture.Build<User>()
                            .With(u => u.Age, 29)
                            .Create();
        }

        public static User UserOverThirtyUnderSixtyFive()
        {
            return _fixture.Build<User>()
                            .With(u => u.Age, 46)
                            .Create();
        }

        public static User UserOverSixtyFive()
        {
            return _fixture.Build<User>()
                            .With(u => u.Age, 67)
                            .Create();
        }
    }
}
