using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BIPIT_11.Controllers
{
    [Route("api/[ValuesController]")]
    public class ValuesController : ApiController
    {
        бипит3Entities1 context = new бипит3Entities1();

        ValuesController()
        {
            context.Configuration.ProxyCreationEnabled = false;
        }

        [Route("~/api/Fill_Vid_rabot")]
        [HttpGet]
        public IEnumerable<Vid_rabot> Fill_Vid_rabot()
        {
            return context.Vid_rabot;
        }

        [Route("~/api/Vid_rabot_add")]
        [HttpPost]
        public void Vid_rabot_add([FromBody] Vid_rabot h)
        {
            context.Vid_rabot.Add(h);
            context.SaveChanges();
        }

        [Route("~/api/Vid_rabot_delete/{id?}")]
        [HttpDelete]
        public void Vid_rabot_delete(int id)
        {
            Vid_rabot Vid_rabot = context.Vid_rabot.Find(id);
            context.Vid_rabot.Remove(Vid_rabot);
            context.SaveChanges();
        }
        [Route("~/api/Fil_Oboryd")]
        [HttpGet]
        public IEnumerable<Oboryd> Fil_Oboryd()
        {
            return context.Oboryd;
        }

        [Route("~/api/Oboryd_add")]
        [HttpPost]
        public void Oboryd_add([FromBody] Oboryd e)
        {
            context.Oboryd.Add(e);
            context.SaveChanges();
        }

        [Route("~/api/Oboryd_delete/{id?}")]
        [HttpDelete]
        public void Oboryd_delete(int id)
        {
            Oboryd e = context.Oboryd.Find(id);
            context.Oboryd.Remove(e);
            context.SaveChanges();
        }

        [Route("~/api/Fill_Rabot")]
        [HttpGet]
        public IEnumerable<Rabot> Fill_Rabot()
        {
            return context.Rabot;
        }

        [Route("~/api/Rabot_add")]
        [HttpPost]
        public void Rabot_add([FromBody] Rabot t)
        {
            context.Rabot.Add(t);
            context.SaveChanges();
        }

        [Route("~/api/Rabot_delect/{id?}")]
        [HttpDelete]
        public void Rabot_delect(int id)
        {
            Rabot Rabot = context.Rabot.Find(id);
            context.Rabot.Remove(Rabot);
            context.SaveChanges();
        }

        [Route("~/api/Vid_rabot/{id?}")]
        [HttpGet]
        public string Vid_rabot(int id)
        {
            Vid_rabot h = context.Vid_rabot.Find(id);
            return h.Name_vid_rabot;
        }

        [Route("~/api/Oboryd/{id?}")]
        [HttpGet]
        public string Oboryd(int id)
        {
            Oboryd e = context.Oboryd.Find(id);
            return e.Model_oboryd;
        }
    }
}
