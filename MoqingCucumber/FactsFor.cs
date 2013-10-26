using System;
using StructureMap.AutoMocking;

namespace MoqingCucumber
{
    public abstract class FactsFor<TSut> : BaseFact where TSut : class
    {
        private readonly MoqAutoMocker<TSut> _autoMocker = new MoqAutoMocker<TSut>();
        private TSut systemUnderTest;

        protected TSut Target
        {
            get { return systemUnderTest; }
        }

        /// <summary>
        ///     Disposes this instance.
        /// </summary>
        public override void Dispose()
        {
            using (var disposable = Target as IDisposable)
            {
                if (disposable != null)
                {
                    disposable.Dispose();
                }
            }
        }


        /// <summary>
        ///     Gets the mock.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Mock{``0}.</returns>
        protected T GetMock<T>() where T : class
        {
            systemUnderTest = _autoMocker.ClassUnderTest;
            return _autoMocker.Get<T>();
        }

        /// <summary>
        ///     Constructs the system under test.
        /// </summary>
        /// <param name="sut">The sut.</param>
        protected void ConstructSystemUnderTest(Func<TSut> sut)
        {
            systemUnderTest = sut();
        }
    }
}