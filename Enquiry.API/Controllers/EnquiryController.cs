using Enquiry.Domain;
using Enquiry.Infrastructure.Persistence;
using Microsoft.AspNetCore.Mvc;

namespace Enquiry.API.Controllers
{
    public class EnquiryController : Controller
    {
        private readonly AppDbContext _appContext;
        public EnquiryController(AppDbContext appContext)
        {
            _appContext = appContext;
        }
        [HttpGet("GetAllStatus")]
        public List<EnquiryStatus> GetEnquiryStatuses()
        {
            var list = _appContext.EntityStatuses.ToList();
            return list;
        }

        [HttpGet("GetAllTypes")]
        public List<EnquiryType> GetEnquiryTypes()
        {
            var types = _appContext.EntityTypes.ToList();
            return types;
        }

        [HttpGet("GetAllEnquiry")]
        public List<EnquiryModel> GetAllEnquiry()
        {
            var model = _appContext.EntityModels.ToList();
            return model;
        }

        [HttpPost("CreateNewEnquiry")]
        public EnquiryModel AddnewEnquiry(EnquiryModel model)
        {


            model.createdDate = DateTime.Now;
            _appContext.EntityModels.Add(model);
            _appContext.SaveChanges();
            return model;

        }
        [HttpPut("UpdateEnquiry")]
        public EnquiryModel Update(EnquiryModel model)
        {

            {
                var record = _appContext.EntityModels.SingleOrDefault(m => m.enquiryId == model.enquiryId);
                if (record != null)
                {
                    record.resolution = model.resolution;
                    record.enquiryStatusId = model.enquiryStatusId;
                    _appContext.SaveChanges();
                }

                return model;


            }
        }

        [HttpPut("DeleteEnquirybyId")]
        public bool DeleteEnquirybyId(int id)
        {

            {
                var record = _appContext.EntityModels.SingleOrDefault(m => m.enquiryId == id);
                if (record != null)

                {
                    _appContext.EntityModels.Remove(record);
                    _appContext.SaveChanges();
                    return true;
                }

                else
                {
                    return false;
                }



            }
        }
    }
}

