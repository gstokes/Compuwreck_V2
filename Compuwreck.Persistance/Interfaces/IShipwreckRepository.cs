using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compwreck.Domain.Models;



namespace Compuwreck.Persistance.Interfaces
{
    public interface IShipwreckRepository : IDisposable
    {
        IEnumerable<Shipwreck> GetShipwrecks();
        Shipwreck GetShipwreckByID(int shipwreckId);
        void InsertShipwreck(Shipwreck shipwreck);
        void DeleteShipwreck(int shipwreckId);
        void UpdateShipwreck(Shipwreck shipwreck);
        void Save();
    }
}
