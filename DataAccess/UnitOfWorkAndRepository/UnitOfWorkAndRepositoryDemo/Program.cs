namespace UnitOfWorkAndRepositoryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var presenter = new PatternPresenter();
            presenter.AlterCustomersDemo();
            presenter.ReadFromDatabaseDemo();
        }
    }
}
