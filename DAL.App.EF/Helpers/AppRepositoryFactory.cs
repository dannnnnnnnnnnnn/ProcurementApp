namespace DAL.App.EF.Helpers
{
     public class AppRepositoryFactory : BaseRepositoryFactory<AppDbContext>
        {
            public AppRepositoryFactory()
            {
                RegisterRepositories();
            }
    
            private void RegisterRepositories()
            {
                AddToCreationMethods<IProcurementRepository>(dataContext => new ProcurementRepository(dataContext));
                AddToCreationMethods<IProcurementObjectRepository>(dataContext => new ProcurementObjectRepository(dataContext));
                AddToCreationMethods<ProcurementObjectRowRepository>(dataContext => new ProcurementObjectRowRepository(dataContext));
            }
        }
}