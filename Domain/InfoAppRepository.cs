using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DiplomProject.Domain
{
    public class InfoAppRepository
    {
        public AppDbContext context;

        public InfoAppRepository(AppDbContext context)
        {
            this.context = context;
        }

        public IQueryable<InfoAp> GetInfo()
        {
            return context.infoAps.OrderBy(x => x.ID);
        }

        public InfoAp GetInformationById(int id)
        {
            return context.infoAps.Single(x => x.ID == id);
        }

        public int SaveInfoApp(InfoAp entity)
        {
            if (entity.ID == default)
                context.Entry(entity).State = EntityState.Added;
            else
                context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

            return entity.ID;
        }

        public void DeleteInfoApp(InfoAp entity)
        {
            context.infoAps.Remove(entity);
            context.SaveChanges();
        }
    }
}
