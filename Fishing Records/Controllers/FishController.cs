using Fishing_Records.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Fishing_Records.Controllers {

    public class FishController : ApiController {

        private FRDBContext db = new FRDBContext();

        [HttpGet]
        [ActionName("List")]
        public IEnumerable<Fish> List() {
            return db.Fish.ToList();
        }

        [HttpGet]
        [ActionName("Get")]
        public Fish Get(int? Id) {
            if(Id == null) {
                return null;
            }
            return db.Fish.Find(Id);
        }

        [HttpPost]
        [ActionName("Create")]
        public bool Create(Fish fish) {
            if(fish == null) {
                return false;
            }
            if(!ModelState.IsValid) {
                return false;
            }
            db.Fish.Add(fish);
            db.SaveChanges();
            return true;
        }

        [HttpPost]
        [ActionName("Change")]
        public bool Change(Fish fish) {
            if (fish == null) {
                return false;
            }

            if(!ModelState.IsValid) {
                return false;
            }

            var f = db.Fish.Find(fish.Id);
            f.Species = fish.Species;
            f.Weight = fish.Weight;
            f.Bait = fish.Bait;

            db.SaveChanges();
            return true;
        }

        [HttpPost]
        [ActionName("Remove")]
        public bool Remove(Fish fish) {
            if(fish == null) {
                return false;
            }
            if(!ModelState.IsValid) {
                return false;
            }

            var f = db.Fish.Find(fish.Id);
            db.Fish.Remove(f);
            db.SaveChanges();
            return true;
        }

    }
}
