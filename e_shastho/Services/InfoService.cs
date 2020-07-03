using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using e_shastho.Data;

namespace e_shastho.Services
{
    public class InfoService
    {
        Entities entities = new Entities();
        public List<Advice> GetAdvices()
        {
            return entities.Advices.Where(e => e.IsVerified).ToList();
        }

        public Advice GetDetails(int adviceId)
        {
            return entities.Advices.AsNoTracking().Where(x => x.Id == adviceId).FirstOrDefault();
        }

        public bool SaveAdvice(Advice advice)
        {
            if (advice.AdvisorName.ToLower() == "admin")
                advice.IsVerified = true;

            entities.Advices.Add(advice);
            return 1 == entities.SaveChanges();
        }

        public Advice Like(int adviceId)
        {
            Advice advice = GetDetails(adviceId);
            advice.Likes = advice.Likes + 1;
            entities.SaveChanges();
            return advice;
        }

        public Advice Dislike(int adviceId)
        {
            Advice advice = GetDetails(adviceId);
            advice.Dislikes = advice.Dislikes + 1;
            entities.SaveChanges();
            return advice;
        }
    }
}