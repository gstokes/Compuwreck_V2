using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compuwreck.Persistance.Interfaces;
using Compwreck.Domain.Models;

namespace Compuwreck.Persistance
{
    public class ShipwreckRepository : IShipwreckRepository, IDisposable
    {

        private readonly CompuwreckEntities _db;

        public ShipwreckRepository(CompuwreckEntities db)
        {
            _db = db;
        }

       
        public IEnumerable<Shipwreck> GetShipwrecks()
        {
            return _db.Shipwrecks.Include(s => s.County).Include(s => s.Event).ToList();
        }

        public Shipwreck GetShipwreckByID(int id)
        {
            return _db.Shipwrecks.Find(id);

        }

        public void InsertShipwreck(Shipwreck shipwreck)
        {
            _db.Shipwrecks.Add(shipwreck);
        }

        public void DeleteShipwreck(int shipwreckID)
        {
            Shipwreck shipwreck = _db.Shipwrecks.Find(shipwreckID);
            _db.Shipwrecks.Remove(shipwreck);
        }

        public void UpdateShipwreck(Shipwreck shipwreck)
        {
            _db.Entry(shipwreck).State = EntityState.Modified;
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed) {
                if (disposing) {
                    _db.Dispose();
                }
            }
            this._disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
