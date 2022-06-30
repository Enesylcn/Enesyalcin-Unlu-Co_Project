using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class OfferManager : IOfferService
    {
        IOfferDal _offerDal;

        public OfferManager(IOfferDal offerDal)
        {
            _offerDal = offerDal;
        }

        public void Tadd(Offer p)
        {
            _offerDal.Insert(p);
        }

        public void TDelete(Offer p)
        {
            _offerDal.Delete(p);
        }

        public Offer TGetByID(int id)
        {
            return _offerDal.GetByID(id);
        }

        public List<Offer> TGetlist()
        {
            return _offerDal.GetList();
        }

        public void TUpdate(Offer p)
        {
            _offerDal.Update(p);
        }
    }
}
