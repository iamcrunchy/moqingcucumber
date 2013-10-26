namespace MoqingCucumber
{
    public abstract class BaseFact
    {
        protected BaseFact()
        {
            BeforeTesting();

            Given();
            When();

            Dispose();
        }

        /// <summary>
        ///     Disposes this instance.
        /// </summary>
        public abstract void Dispose();

        /// <summary>
        ///     When this instance.
        /// </summary>
        public abstract void When();

        /// <summary>
        ///     Givens this instance.
        /// </summary>
        public abstract void Given();

        /// <summary>
        ///     Set up before the test runs
        /// </summary>
        public virtual void BeforeTesting()
        {
        }
    }
}