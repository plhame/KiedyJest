namespace KiedyJestWeb.DataAccess
{
    using System;

    /// <summary>
    /// Interface that needs to be implemented by all data services.
    /// </summary>
    public interface IDataService
    {
        void CreateSession();
        void BeginTransaction();
        void CommitTransaction(Boolean closeSession);
        void RollbackTransaction(Boolean closeSession);
        void CloseSession();
    }
}
