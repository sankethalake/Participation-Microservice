using ParticipationMicroservice.DBContexts;
using ParticipationMicroservice.Model;
using ParticipationMicroservice.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ParticipationMicroservice.Models.DataManager
{
    public class ParticipationManager: IDataRepository<Participation>
    {
        readonly ParticipationContext _participationContext;
        public ParticipationManager(ParticipationContext context)
        {
            _participationContext = context;
        }

        //method to get all participation
        public IEnumerable<Participation> GetAll()
        {
            return _participationContext.Participations.ToList();
        }
        public Participation Get(long id)
        {
            return _participationContext.Participations
                  .FirstOrDefault(p => p.ParticipationId == id);
        }

        //method to add participation
        public void Add(Participation entity)
        {
            _participationContext.Participations.Add(entity);
            _participationContext.SaveChanges();
        }

        //method to update status of participation
        public void Update(Participation participation, string status)
        {
            //participation.Events = entity.Events;
            //participation.PlayerName = entity.PlayerName;
            ParticipationStatus enumStatus = (ParticipationStatus)Enum.Parse(typeof(ParticipationStatus), status);
            participation.Status = enumStatus;
            _participationContext.SaveChanges();
        }

        public IEnumerable<Participation> GetByStatus(string status)
        {
            ParticipationStatus enumStatus = (ParticipationStatus)Enum.Parse(typeof(ParticipationStatus), status);
            return _participationContext.Participations.Where(s => s.Status == enumStatus);
        }
    }
}
